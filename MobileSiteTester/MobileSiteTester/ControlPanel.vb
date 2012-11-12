Imports Microsoft.Win32
Imports System.IO

Public Class ControlPanel

    Public Function ProcessesRunning(ByVal ProcessName As String) As Integer
        Try
            Return Process.GetProcessesByName(ProcessName).GetUpperBound(0) + 1
        Catch
            Return 0
        End Try
    End Function

    Private Sub cmboMailTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboMailTo.SelectedIndexChanged
        If cmboMailTo.Text = "Yes" Then
            tbcMain.SelectedIndex = 1
        End If
    End Sub

    Private Sub cmboPhotos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboPhotos.SelectedIndexChanged
        If cmboPhotos.Text = "Yes" Then
            lblPicLoc.Visible = True
            tbPhotoLoc.Visible = True
            cbPicLoc.Visible = True
        End If
    End Sub

    Private Sub cbWebLocation_Click(sender As Object, e As EventArgs) Handles cbWebLocation.Click
        opnWebSite.InitialDirectory = System.Environment.GetEnvironmentVariable("userprofile")
        opnWebSite.Filter = "html files (*.htm)|*.html"
        opnWebSite.FilterIndex = 1
        opnWebSite.FileName = "index.html"
        opnWebSite.RestoreDirectory = True
        opnWebSite.ShowDialog()
        Dim websitefile As String
        websitefile = opnWebSite.FileName
        tbWebLocation.Text = websitefile
    End Sub

    Private Sub cbPicLoc_Click(sender As Object, e As EventArgs) Handles cbPicLoc.Click
        opnPics.ShowNewFolderButton = False
        opnPics.ShowDialog()
        Dim openPicDir As String
        openPicDir = opnPics.SelectedPath
        tbPhotoLoc.Text = openPicDir
    End Sub

    Private Sub cbLaunch_Click(sender As Object, e As EventArgs) Handles cbLaunch.Click
        If cmbxPhoneType.Text = "Windows Phone" Then
            WinPhone.Show()
        End If
    End Sub

    Private Sub cbSave_Click(sender As Object, e As EventArgs) Handles cbSave.Click
        Dim mkkey As RegistryKey
        mkkey = Registry.CurrentUser.OpenSubKey("SOFTWARE", True)
        mkkey.CreateSubKey("Phonegap Phone Emulator")
        mkkey.Close()

        Dim mkvalue As RegistryKey
        mkvalue = Registry.CurrentUser.OpenSubKey("SOFTWARE\Phonegap Phone Emulator", True)
        mkvalue.SetValue("E-Mail Address", tbAddress.Text)
        mkvalue.SetValue("User Name", tbUserName.Text)
        mkvalue.SetValue("Password", tbPW.Text)
        mkvalue.SetValue("SMTP", tbSMTP.Text)
        mkvalue.SetValue("Port", tbPort.Text)
        If rbSSLYes.Checked = True Then
            mkvalue.SetValue("SSL", "Yes")
        ElseIf rbSSLNo.Checked = True Then
            mkvalue.SetValue("SSL", "No")
        End If
        mkvalue.Close()
        MessageBox.Show("Your Settings Are Now Saved")
    End Sub

    Private Sub tbAddress_Leave(sender As Object, e As EventArgs) Handles tbAddress.Leave
        If tbAddress.Text.Contains("@") = False Or tbAddress.Text.Contains(".") = False Then
            MessageBox.Show("Invalid E-Mail Format")
        End If
    End Sub

    Private Sub tbConfirm_Leave(sender As Object, e As EventArgs) Handles tbConfirm.Leave
        If tbPW.Text = tbConfirm.Text = False Then
            MessageBox.Show("Passwords don't match")
        End If
    End Sub

    Private Sub tbPort_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPort.KeyDown
        If e.KeyCode = Keys.A Or e.KeyCode = Keys.B Or e.KeyCode = Keys.C Or e.KeyCode = Keys.D Or e.KeyCode = Keys.E Or e.KeyCode = Keys.F Or e.KeyCode = Keys.G Or e.KeyCode = Keys.H Or e.KeyCode = Keys.I Or e.KeyCode = Keys.J Or e.KeyCode = Keys.K Or e.KeyCode = Keys.L Or e.KeyCode = Keys.M Or e.KeyCode = Keys.N Or e.KeyCode = Keys.O Or e.KeyCode = Keys.P Or e.KeyCode = Keys.Q Or e.KeyCode = Keys.R Or e.KeyCode = Keys.S Or e.KeyCode = Keys.T Or e.KeyCode = Keys.U Or e.KeyCode = Keys.V Or e.KeyCode = Keys.W Or e.KeyCode = Keys.X Or e.KeyCode = Keys.Y Or e.KeyCode = Keys.Z Or e.KeyCode = Keys.Space Or e.KeyCode = Keys.Decimal Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cmboCalling_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboCalling.SelectedIndexChanged
        If cmboCalling.Text = "Yes" Then
            If ProcessesRunning("Skype") = 0 Then
                MessageBox.Show("You Need to have Skype Running for this feature to work.")
            End If
        End If
    End Sub

    Private Sub cmbxPhoneType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxPhoneType.SelectedIndexChanged
        If cmbxPhoneType.Text = "Android" Or cmbxPhoneType.Text = "Black Berry" Or cmbxPhoneType.Text = "iPhone" Then
            MessageBox.Show("Only Windows Phone is supported right now.")
        End If
    End Sub
End Class
