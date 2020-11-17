Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Windows will now activate, some messaage boxes will appear after this program closes, that is just windows telling you, there should be 3-4")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "PaintDesktopVersion", 4, Microsoft.Win32.RegistryValueKind.DWord)
        Shell("cmd.exe /c gpupdate /force")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\svsvc", "Start", 4, Microsoft.Win32.RegistryValueKind.DWord)
        My.Computer.Registry.LocalMachine.CreateSubKey("SYSTEM\CurrentControlSet\Services\svsvc\KMS")
        My.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\svsvc\KMS", True).SetValue("(Default)", "kms_4")
        Shell("cmd.exe /c gpupdate /force")
        'System.Threading.Thread.CurrentThread.Sleep(5000)
        If RadioButton1.Checked = True Then
            Shell("cmd.exe /c slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX")
            ' System.Threading.Thread.CurrentThread.Sleep(10000)
            Shell("cmd.exe /c slmgr /skms kms8.msguides.com")
            ' System.Threading.Thread.CurrentThread.Sleep(10000)
            Shell("cmd.exe /c slmgr /ato")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "PaintDesktopVersion", 0, Microsoft.Win32.RegistryValueKind.DWord)
            Shell("cmd.exe /c gpupdate /force")
            ' System.Threading.Thread.CurrentThread.Sleep(5000)
            'MsgBox("Done! Please refresh your desktop, to get rid of the version message")
        ElseIf RadioButton2.Checked = True Then
            Shell("cmd.exe /c slmgr /ipk TX9XD-98N7V-6WMQ6-BX7FG-H8Q99")
            'System.Threading.Thread.CurrentThread.Sleep(10000)
            Shell("cmd.exe /c slmgr /skms kms8.msguides.com")
            'System.Threading.Thread.CurrentThread.Sleep(10000)
            Shell("cmd.exe /c slmgr /ato")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "PaintDesktopVersion", 0, Microsoft.Win32.RegistryValueKind.DWord)
            Shell("cmd.exe /c gpupdate /force")
            'System.Threading.Thread.CurrentThread.Sleep(5000)
            'MsgBox("Done! Please refresh your desktop, to get rid of the version message")
        ElseIf RadioButton3.Checked = True Then
            Shell("cmd.exe /c slmgr /ipk 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH")
            'System.Threading.Thread.CurrentThread.Sleep(10000)
            Shell("cmd.exe /c slmgr /skms kms8.msguides.com")
            ' System.Threading.Thread.CurrentThread.Sleep(10000)
            Shell("cmd.exe /c slmgr /ato")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "PaintDesktopVersion", 0, Microsoft.Win32.RegistryValueKind.DWord)
            Shell("cmd.exe /c gpupdate /force")
            'System.Threading.Thread.CurrentThread.Sleep(5000)
            'MsgBox("Done! Please refresh your desktop, to get rid of the version message")
        ElseIf RadioButton4.Checked = True Then
            Shell("cmd.exe /c slmgr /ipk PVMJN-6DFY6-9CCP6-7BKTT-D3WVR")
            'System.Threading.Thread.CurrentThread.Sleep(10000)
            Shell("cmd.exe /c slmgr /skms kms8.msguides.com")
            '  System.Threading.Thread.CurrentThread.Sleep(10000)
            Shell("cmd.exe /c slmgr /ato")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "PaintDesktopVersion", 0, Microsoft.Win32.RegistryValueKind.DWord)
            Shell("cmd.exe /c gpupdate /force")
            '  System.Threading.Thread.CurrentThread.Sleep(5000)
            'MsgBox("Done! Please refresh your desktop, to get rid of the version message")
        End If
        MsgBox("Should be done, check your windows settings and see if you can personalize your computer.")
        'MsgBox("Thank you for using my windows activator")
        Application.Exit()
    End Sub
    'To deactivate windows, type slmgr /upk into an admin command prompt



End Class
