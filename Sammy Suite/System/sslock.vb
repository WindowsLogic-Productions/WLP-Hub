Imports Microsoft.Win32

Public Class sslock
#Region "Disable Close Button"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
#End Region
#Region "DisableWinKey"
    'Event types
    Private Const WM_KEYUP As Integer = &H101
    Private Const WM_KEYDOWN As Short = &H100S
    Private Const WM_SYSKEYDOWN As Integer = &H104
    Private Const WM_SYSKEYUP As Integer = &H105
    'Event Info structure
    Public Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure
    'Keyboard hook related functions
    Private Declare Function UnhookWindowsHookEx Lib "user32" (ByVal hHook As Integer) As Integer
    Private Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal idHook As Integer, ByVal lpfn As KeyboardHookDelegate, ByVal hmod As Integer, ByVal dwThreadId As Integer) As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
    Private Declare Function CallNextHookEx Lib "user32" (ByVal hHook As Integer, ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As KBDLLHOOKSTRUCT) As Integer
    Private Delegate Function KeyboardHookDelegate(ByVal Code As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    Private KeyboardHandle As IntPtr = 0 'Handle of the hook
    Private callback As KeyboardHookDelegate = Nothing 'Delegate for the hook
    Private Function Hooked()
        Return KeyboardHandle <> 0 'If KeyboardHandle = 0 it means that it isn't hooked so return false, otherwise return true
    End Function
    Public Sub HookKeyboard()
        callback = New KeyboardHookDelegate(AddressOf KeyboardCallback)
        KeyboardHandle = SetWindowsHookEx(13, callback, Process.GetCurrentProcess.MainModule.BaseAddress, 0)
        If KeyboardHandle <> 0 Then
            Debug.Write(vbCrLf & "[Keyboard Hooked]" & vbCrLf)
        End If
    End Sub
    Public Sub UnhookKeyboard()
        If (Hooked()) Then
            If UnhookWindowsHookEx(KeyboardHandle) <> 0 Then
                Debug.Write(vbCrLf & "[Keyboard Unhooked]")
                KeyboardHandle = 0 'We have unhooked successfully
            End If
        End If
    End Sub
    Public Function KeyboardCallback(ByVal Code As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
        'Variable to hold the text describing the key pressed
        Dim Key = lParam.vkCode
        'If event is KEYDOWN
        If wParam = WM_KEYDOWN Or wParam = WM_SYSKEYDOWN Then
            'If we can block events
            If Code >= 0 Then
                If Key = 91 Or Key = 92 Then
                    Return 1 'Block event
                End If
            End If
        End If
        Debug.Write(Key)
        'Return CallNextHookEx(KeyboardHandle, Code, wParam, lParam) 'Let event go to the other applications
    End Function
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UnhookKeyboard()

        'Enable Task Manager
        Dim SysRegistry As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
        SysRegistry.SetValue("DisableTaskMgr", 0)
        SysRegistry.SetValue("DisableLockWorkstation", 0)
        SysRegistry.SetValue("DisableChangePassword", 0)
        SysRegistry.Close()

        Dim SysReg As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer")
        SysReg.SetValue("NoLogoff", 0)

        Dim MachineReg As RegistryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System")
        MachineReg.SetValue("HideFastUserSwitching", 0)
        MachineReg.Close()

        Dim MachineRegistry As RegistryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\policies\Explorer")
        MachineRegistry.SetValue("NoClose", 0)
        MachineRegistry.Close()

        'Run Explorer.exe
        Process.Start("C:\Windows\explorer.exe")
    End Sub
#End Region
#Region "Keyboard Jammer"
    Private Sub Form1_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        KeyboardJammer.Jam()
    End Sub
    Private Sub Form1_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        KeyboardJammer.UnJam()
    End Sub
#End Region
#Region "Load Settings"
    Private Sub sslock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HookKeyboard()

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        Label3.Text = "Only " + System.Windows.Forms.SystemInformation.UserName + " or an administrator can unlock this computer."

        'Disable Windows administrative components.
        Dim SysRegistry As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")
        SysRegistry.SetValue("DisableTaskMgr", 1)
        SysRegistry.SetValue("DisableLockWorkstation", 1)
        SysRegistry.SetValue("DisableChangePassword", 1)
        SysRegistry.Close()

        Dim SysReg As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer")
        SysReg.SetValue("NoLogoff", 1)
        SysReg.Close()

        Dim MachineReg As RegistryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System")
        MachineReg.SetValue("HideFastUserSwitching", 1)
        MachineReg.Close()

        Dim MachineRegistry As RegistryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsft\Windows\CurrentVersion\Policies\Explorer")
        MachineRegistry.SetValue("NoClose", 1)
        MachineRegistry.Close()

        'Kill Explorer.exe.
        Dim taskkill As New ProcessStartInfo
        taskkill.FileName = "cmd.exe"
        taskkill.Arguments = "/c taskkill /F /IM explorer.exe"
        taskkill.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(taskkill)

    End Sub
#End Region
#Region "Other"
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If UsernameBox.Text = My.Settings.Username And PasswordBox.Text = My.Settings.Password Then
            sssecurity.Show()
            Me.Close()
            sssecuritybackground.Close()
        Else
            sserror.Show()
            sserror.Label1.Text = "The credentials you have entered are incorrect."
        End If
    End Sub
#End Region

    Private Sub sslock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.Control Then
            e.Handled = True
        End If
    End Sub
End Class