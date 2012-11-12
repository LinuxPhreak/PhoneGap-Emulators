<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbxPhoneType = New System.Windows.Forms.ComboBox()
        Me.tbWebLocation = New System.Windows.Forms.TextBox()
        Me.cbWebLocation = New System.Windows.Forms.Button()
        Me.lblWebLocation = New System.Windows.Forms.Label()
        Me.lblPhoneType = New System.Windows.Forms.Label()
        Me.lblCalling = New System.Windows.Forms.Label()
        Me.cmboCalling = New System.Windows.Forms.ComboBox()
        Me.lblSMS = New System.Windows.Forms.Label()
        Me.cmboSMS = New System.Windows.Forms.ComboBox()
        Me.lblMailTo = New System.Windows.Forms.Label()
        Me.cmboMailTo = New System.Windows.Forms.ComboBox()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tbpMain = New System.Windows.Forms.TabPage()
        Me.cbLaunch = New System.Windows.Forms.Button()
        Me.lblPicLoc = New System.Windows.Forms.Label()
        Me.tbPhotoLoc = New System.Windows.Forms.TextBox()
        Me.cbPicLoc = New System.Windows.Forms.Button()
        Me.cmboPhotos = New System.Windows.Forms.ComboBox()
        Me.lblPhotos = New System.Windows.Forms.Label()
        Me.tbpEMail = New System.Windows.Forms.TabPage()
        Me.cbSave = New System.Windows.Forms.Button()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.gbSSL = New System.Windows.Forms.GroupBox()
        Me.rbSSLNo = New System.Windows.Forms.RadioButton()
        Me.rbSSLYes = New System.Windows.Forms.RadioButton()
        Me.tbSMTP = New System.Windows.Forms.TextBox()
        Me.lblSMTP = New System.Windows.Forms.Label()
        Me.tbConfirm = New System.Windows.Forms.TextBox()
        Me.tbPW = New System.Windows.Forms.TextBox()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.tbUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.lblEMailAddress = New System.Windows.Forms.Label()
        Me.opnWebSite = New System.Windows.Forms.OpenFileDialog()
        Me.opnPics = New System.Windows.Forms.FolderBrowserDialog()
        Me.tbcMain.SuspendLayout()
        Me.tbpMain.SuspendLayout()
        Me.tbpEMail.SuspendLayout()
        Me.gbSSL.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbxPhoneType
        '
        Me.cmbxPhoneType.FormattingEnabled = True
        Me.cmbxPhoneType.Items.AddRange(New Object() {"Android", "Black Berry", "iPhone", "Windows Phone"})
        Me.cmbxPhoneType.Location = New System.Drawing.Point(6, 70)
        Me.cmbxPhoneType.Name = "cmbxPhoneType"
        Me.cmbxPhoneType.Size = New System.Drawing.Size(260, 21)
        Me.cmbxPhoneType.TabIndex = 0
        '
        'tbWebLocation
        '
        Me.tbWebLocation.Location = New System.Drawing.Point(6, 25)
        Me.tbWebLocation.Name = "tbWebLocation"
        Me.tbWebLocation.Size = New System.Drawing.Size(227, 20)
        Me.tbWebLocation.TabIndex = 1
        '
        'cbWebLocation
        '
        Me.cbWebLocation.Location = New System.Drawing.Point(239, 23)
        Me.cbWebLocation.Name = "cbWebLocation"
        Me.cbWebLocation.Size = New System.Drawing.Size(27, 23)
        Me.cbWebLocation.TabIndex = 2
        Me.cbWebLocation.Text = "..."
        Me.cbWebLocation.UseVisualStyleBackColor = True
        '
        'lblWebLocation
        '
        Me.lblWebLocation.AutoSize = True
        Me.lblWebLocation.Location = New System.Drawing.Point(7, 7)
        Me.lblWebLocation.Name = "lblWebLocation"
        Me.lblWebLocation.Size = New System.Drawing.Size(90, 13)
        Me.lblWebLocation.TabIndex = 3
        Me.lblWebLocation.Text = "Website Location"
        '
        'lblPhoneType
        '
        Me.lblPhoneType.AutoSize = True
        Me.lblPhoneType.Location = New System.Drawing.Point(7, 54)
        Me.lblPhoneType.Name = "lblPhoneType"
        Me.lblPhoneType.Size = New System.Drawing.Size(65, 13)
        Me.lblPhoneType.TabIndex = 4
        Me.lblPhoneType.Text = "Phone Type"
        '
        'lblCalling
        '
        Me.lblCalling.AutoSize = True
        Me.lblCalling.Location = New System.Drawing.Point(5, 99)
        Me.lblCalling.Name = "lblCalling"
        Me.lblCalling.Size = New System.Drawing.Size(71, 13)
        Me.lblCalling.TabIndex = 5
        Me.lblCalling.Text = "Skype Calling"
        '
        'cmboCalling
        '
        Me.cmboCalling.FormattingEnabled = True
        Me.cmboCalling.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmboCalling.Location = New System.Drawing.Point(6, 115)
        Me.cmboCalling.Name = "cmboCalling"
        Me.cmboCalling.Size = New System.Drawing.Size(68, 21)
        Me.cmboCalling.TabIndex = 6
        '
        'lblSMS
        '
        Me.lblSMS.AutoSize = True
        Me.lblSMS.Location = New System.Drawing.Point(79, 99)
        Me.lblSMS.Name = "lblSMS"
        Me.lblSMS.Size = New System.Drawing.Size(82, 13)
        Me.lblSMS.TabIndex = 7
        Me.lblSMS.Text = "Text Messaging"
        '
        'cmboSMS
        '
        Me.cmboSMS.FormattingEnabled = True
        Me.cmboSMS.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmboSMS.Location = New System.Drawing.Point(82, 115)
        Me.cmboSMS.Name = "cmboSMS"
        Me.cmboSMS.Size = New System.Drawing.Size(79, 21)
        Me.cmboSMS.TabIndex = 8
        '
        'lblMailTo
        '
        Me.lblMailTo.AutoSize = True
        Me.lblMailTo.Location = New System.Drawing.Point(175, 99)
        Me.lblMailTo.Name = "lblMailTo"
        Me.lblMailTo.Size = New System.Drawing.Size(36, 13)
        Me.lblMailTo.TabIndex = 9
        Me.lblMailTo.Text = "E-Mail"
        '
        'cmboMailTo
        '
        Me.cmboMailTo.FormattingEnabled = True
        Me.cmboMailTo.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmboMailTo.Location = New System.Drawing.Point(178, 115)
        Me.cmboMailTo.Name = "cmboMailTo"
        Me.cmboMailTo.Size = New System.Drawing.Size(79, 21)
        Me.cmboMailTo.TabIndex = 10
        '
        'tbcMain
        '
        Me.tbcMain.Controls.Add(Me.tbpMain)
        Me.tbcMain.Controls.Add(Me.tbpEMail)
        Me.tbcMain.Location = New System.Drawing.Point(2, 2)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(276, 273)
        Me.tbcMain.TabIndex = 12
        '
        'tbpMain
        '
        Me.tbpMain.Controls.Add(Me.cbLaunch)
        Me.tbpMain.Controls.Add(Me.lblPicLoc)
        Me.tbpMain.Controls.Add(Me.tbPhotoLoc)
        Me.tbpMain.Controls.Add(Me.cbPicLoc)
        Me.tbpMain.Controls.Add(Me.cmboPhotos)
        Me.tbpMain.Controls.Add(Me.lblPhotos)
        Me.tbpMain.Controls.Add(Me.tbWebLocation)
        Me.tbpMain.Controls.Add(Me.cmbxPhoneType)
        Me.tbpMain.Controls.Add(Me.cmboMailTo)
        Me.tbpMain.Controls.Add(Me.cbWebLocation)
        Me.tbpMain.Controls.Add(Me.lblMailTo)
        Me.tbpMain.Controls.Add(Me.lblWebLocation)
        Me.tbpMain.Controls.Add(Me.cmboSMS)
        Me.tbpMain.Controls.Add(Me.lblPhoneType)
        Me.tbpMain.Controls.Add(Me.lblSMS)
        Me.tbpMain.Controls.Add(Me.lblCalling)
        Me.tbpMain.Controls.Add(Me.cmboCalling)
        Me.tbpMain.Location = New System.Drawing.Point(4, 22)
        Me.tbpMain.Name = "tbpMain"
        Me.tbpMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpMain.Size = New System.Drawing.Size(268, 247)
        Me.tbpMain.TabIndex = 0
        Me.tbpMain.Text = "Settings"
        Me.tbpMain.UseVisualStyleBackColor = True
        '
        'cbLaunch
        '
        Me.cbLaunch.Location = New System.Drawing.Point(6, 186)
        Me.cbLaunch.Name = "cbLaunch"
        Me.cbLaunch.Size = New System.Drawing.Size(260, 58)
        Me.cbLaunch.TabIndex = 16
        Me.cbLaunch.Text = "Launch"
        Me.cbLaunch.UseVisualStyleBackColor = True
        '
        'lblPicLoc
        '
        Me.lblPicLoc.AutoSize = True
        Me.lblPicLoc.Location = New System.Drawing.Point(79, 143)
        Me.lblPicLoc.Name = "lblPicLoc"
        Me.lblPicLoc.Size = New System.Drawing.Size(83, 13)
        Me.lblPicLoc.TabIndex = 15
        Me.lblPicLoc.Text = "Gallery Location"
        Me.lblPicLoc.Visible = False
        '
        'tbPhotoLoc
        '
        Me.tbPhotoLoc.Location = New System.Drawing.Point(82, 159)
        Me.tbPhotoLoc.Name = "tbPhotoLoc"
        Me.tbPhotoLoc.Size = New System.Drawing.Size(151, 20)
        Me.tbPhotoLoc.TabIndex = 13
        Me.tbPhotoLoc.Visible = False
        '
        'cbPicLoc
        '
        Me.cbPicLoc.Location = New System.Drawing.Point(239, 156)
        Me.cbPicLoc.Name = "cbPicLoc"
        Me.cbPicLoc.Size = New System.Drawing.Size(27, 23)
        Me.cbPicLoc.TabIndex = 14
        Me.cbPicLoc.Text = "..."
        Me.cbPicLoc.UseVisualStyleBackColor = True
        Me.cbPicLoc.Visible = False
        '
        'cmboPhotos
        '
        Me.cmboPhotos.FormattingEnabled = True
        Me.cmboPhotos.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmboPhotos.Location = New System.Drawing.Point(6, 159)
        Me.cmboPhotos.Name = "cmboPhotos"
        Me.cmboPhotos.Size = New System.Drawing.Size(70, 21)
        Me.cmboPhotos.TabIndex = 12
        '
        'lblPhotos
        '
        Me.lblPhotos.AutoSize = True
        Me.lblPhotos.Location = New System.Drawing.Point(5, 143)
        Me.lblPhotos.Name = "lblPhotos"
        Me.lblPhotos.Size = New System.Drawing.Size(70, 13)
        Me.lblPhotos.TabIndex = 11
        Me.lblPhotos.Text = "Photo Gallery"
        '
        'tbpEMail
        '
        Me.tbpEMail.Controls.Add(Me.cbSave)
        Me.tbpEMail.Controls.Add(Me.tbPort)
        Me.tbpEMail.Controls.Add(Me.lblPort)
        Me.tbpEMail.Controls.Add(Me.gbSSL)
        Me.tbpEMail.Controls.Add(Me.tbSMTP)
        Me.tbpEMail.Controls.Add(Me.lblSMTP)
        Me.tbpEMail.Controls.Add(Me.tbConfirm)
        Me.tbpEMail.Controls.Add(Me.tbPW)
        Me.tbpEMail.Controls.Add(Me.lblConfirm)
        Me.tbpEMail.Controls.Add(Me.lblPW)
        Me.tbpEMail.Controls.Add(Me.tbUserName)
        Me.tbpEMail.Controls.Add(Me.lblUserName)
        Me.tbpEMail.Controls.Add(Me.tbAddress)
        Me.tbpEMail.Controls.Add(Me.lblEMailAddress)
        Me.tbpEMail.Location = New System.Drawing.Point(4, 22)
        Me.tbpEMail.Name = "tbpEMail"
        Me.tbpEMail.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEMail.Size = New System.Drawing.Size(268, 247)
        Me.tbpEMail.TabIndex = 1
        Me.tbpEMail.Text = "E-Mail"
        Me.tbpEMail.UseVisualStyleBackColor = True
        '
        'cbSave
        '
        Me.cbSave.Location = New System.Drawing.Point(96, 174)
        Me.cbSave.Name = "cbSave"
        Me.cbSave.Size = New System.Drawing.Size(166, 63)
        Me.cbSave.TabIndex = 9
        Me.cbSave.Text = "Save"
        Me.cbSave.UseVisualStyleBackColor = True
        '
        'tbPort
        '
        Me.tbPort.Location = New System.Drawing.Point(85, 148)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(177, 20)
        Me.tbPort.TabIndex = 6
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(6, 151)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 11
        Me.lblPort.Text = "Port:"
        '
        'gbSSL
        '
        Me.gbSSL.Controls.Add(Me.rbSSLNo)
        Me.gbSSL.Controls.Add(Me.rbSSLYes)
        Me.gbSSL.Location = New System.Drawing.Point(3, 174)
        Me.gbSSL.Name = "gbSSL"
        Me.gbSSL.Size = New System.Drawing.Size(78, 64)
        Me.gbSSL.TabIndex = 8
        Me.gbSSL.TabStop = False
        Me.gbSSL.Text = "Use SSL"
        '
        'rbSSLNo
        '
        Me.rbSSLNo.AutoSize = True
        Me.rbSSLNo.Checked = True
        Me.rbSSLNo.Location = New System.Drawing.Point(7, 43)
        Me.rbSSLNo.Name = "rbSSLNo"
        Me.rbSSLNo.Size = New System.Drawing.Size(39, 17)
        Me.rbSSLNo.TabIndex = 6
        Me.rbSSLNo.TabStop = True
        Me.rbSSLNo.Text = "No"
        Me.rbSSLNo.UseVisualStyleBackColor = True
        '
        'rbSSLYes
        '
        Me.rbSSLYes.AutoSize = True
        Me.rbSSLYes.Location = New System.Drawing.Point(6, 19)
        Me.rbSSLYes.Name = "rbSSLYes"
        Me.rbSSLYes.Size = New System.Drawing.Size(43, 17)
        Me.rbSSLYes.TabIndex = 7
        Me.rbSSLYes.Text = "Yes"
        Me.rbSSLYes.UseVisualStyleBackColor = True
        '
        'tbSMTP
        '
        Me.tbSMTP.Location = New System.Drawing.Point(85, 122)
        Me.tbSMTP.Name = "tbSMTP"
        Me.tbSMTP.Size = New System.Drawing.Size(177, 20)
        Me.tbSMTP.TabIndex = 5
        '
        'lblSMTP
        '
        Me.lblSMTP.AutoSize = True
        Me.lblSMTP.Location = New System.Drawing.Point(6, 125)
        Me.lblSMTP.Name = "lblSMTP"
        Me.lblSMTP.Size = New System.Drawing.Size(40, 13)
        Me.lblSMTP.TabIndex = 8
        Me.lblSMTP.Text = "SMTP:"
        '
        'tbConfirm
        '
        Me.tbConfirm.Location = New System.Drawing.Point(85, 94)
        Me.tbConfirm.Name = "tbConfirm"
        Me.tbConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirm.Size = New System.Drawing.Size(177, 20)
        Me.tbConfirm.TabIndex = 4
        '
        'tbPW
        '
        Me.tbPW.Location = New System.Drawing.Point(85, 68)
        Me.tbPW.Name = "tbPW"
        Me.tbPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPW.Size = New System.Drawing.Size(177, 20)
        Me.tbPW.TabIndex = 3
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(6, 97)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(45, 13)
        Me.lblConfirm.TabIndex = 5
        Me.lblConfirm.Text = "Confirm:"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Location = New System.Drawing.Point(6, 71)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(56, 13)
        Me.lblPW.TabIndex = 4
        Me.lblPW.Text = "Password:"
        '
        'tbUserName
        '
        Me.tbUserName.Location = New System.Drawing.Point(85, 40)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(177, 20)
        Me.tbUserName.TabIndex = 2
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(6, 44)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(63, 13)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "User Name:"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(85, 13)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(177, 20)
        Me.tbAddress.TabIndex = 1
        '
        'lblEMailAddress
        '
        Me.lblEMailAddress.AutoSize = True
        Me.lblEMailAddress.Location = New System.Drawing.Point(6, 16)
        Me.lblEMailAddress.Name = "lblEMailAddress"
        Me.lblEMailAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblEMailAddress.TabIndex = 0
        Me.lblEMailAddress.Text = "Address:"
        '
        'opnWebSite
        '
        Me.opnWebSite.FileName = "OpenFileDialog1"
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 274)
        Me.Controls.Add(Me.tbcMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ControlPanel"
        Me.ShowIcon = False
        Me.Text = "Control Panel"
        Me.tbcMain.ResumeLayout(False)
        Me.tbpMain.ResumeLayout(False)
        Me.tbpMain.PerformLayout()
        Me.tbpEMail.ResumeLayout(False)
        Me.tbpEMail.PerformLayout()
        Me.gbSSL.ResumeLayout(False)
        Me.gbSSL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbxPhoneType As System.Windows.Forms.ComboBox
    Friend WithEvents tbWebLocation As System.Windows.Forms.TextBox
    Friend WithEvents cbWebLocation As System.Windows.Forms.Button
    Friend WithEvents lblWebLocation As System.Windows.Forms.Label
    Friend WithEvents lblPhoneType As System.Windows.Forms.Label
    Friend WithEvents lblCalling As System.Windows.Forms.Label
    Friend WithEvents cmboCalling As System.Windows.Forms.ComboBox
    Friend WithEvents lblSMS As System.Windows.Forms.Label
    Friend WithEvents cmboSMS As System.Windows.Forms.ComboBox
    Friend WithEvents lblMailTo As System.Windows.Forms.Label
    Friend WithEvents cmboMailTo As System.Windows.Forms.ComboBox
    Friend WithEvents tbcMain As System.Windows.Forms.TabControl
    Friend WithEvents tbpMain As System.Windows.Forms.TabPage
    Friend WithEvents cbLaunch As System.Windows.Forms.Button
    Friend WithEvents lblPicLoc As System.Windows.Forms.Label
    Friend WithEvents tbPhotoLoc As System.Windows.Forms.TextBox
    Friend WithEvents cbPicLoc As System.Windows.Forms.Button
    Friend WithEvents cmboPhotos As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhotos As System.Windows.Forms.Label
    Friend WithEvents tbpEMail As System.Windows.Forms.TabPage
    Friend WithEvents cbSave As System.Windows.Forms.Button
    Friend WithEvents tbPort As System.Windows.Forms.TextBox
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents gbSSL As System.Windows.Forms.GroupBox
    Friend WithEvents rbSSLNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbSSLYes As System.Windows.Forms.RadioButton
    Friend WithEvents tbSMTP As System.Windows.Forms.TextBox
    Friend WithEvents lblSMTP As System.Windows.Forms.Label
    Friend WithEvents tbConfirm As System.Windows.Forms.TextBox
    Friend WithEvents tbPW As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents lblPW As System.Windows.Forms.Label
    Friend WithEvents tbUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblEMailAddress As System.Windows.Forms.Label
    Friend WithEvents opnWebSite As System.Windows.Forms.OpenFileDialog
    Friend WithEvents opnPics As System.Windows.Forms.FolderBrowserDialog

End Class
