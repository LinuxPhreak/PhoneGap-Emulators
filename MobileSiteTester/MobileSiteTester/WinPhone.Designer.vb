<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinPhone
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
        Me.wbIEMobi = New System.Windows.Forms.WebBrowser()
        Me.cbAction = New System.Windows.Forms.Button()
        Me.tbNumber = New System.Windows.Forms.TextBox()
        Me.pbxIE = New System.Windows.Forms.PictureBox()
        Me.pbxDialer = New System.Windows.Forms.PictureBox()
        Me.pbxSMS = New System.Windows.Forms.PictureBox()
        Me.pbxCam = New System.Windows.Forms.PictureBox()
        Me.pbxEMail = New System.Windows.Forms.PictureBox()
        Me.pbxSettings = New System.Windows.Forms.PictureBox()
        Me.pbxGallery = New System.Windows.Forms.PictureBox()
        Me.tbmsgBody = New System.Windows.Forms.TextBox()
        Me.tbSubject = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblUName = New System.Windows.Forms.Label()
        Me.lblPW = New System.Windows.Forms.Label()
        Me.lblSMTP = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblSSL = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        CType(Me.pbxIE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDialer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEMail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGallery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wbIEMobi
        '
        Me.wbIEMobi.Location = New System.Drawing.Point(30, 111)
        Me.wbIEMobi.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbIEMobi.Name = "wbIEMobi"
        Me.wbIEMobi.Size = New System.Drawing.Size(230, 378)
        Me.wbIEMobi.TabIndex = 0
        '
        'cbAction
        '
        Me.cbAction.Location = New System.Drawing.Point(100, 452)
        Me.cbAction.Name = "cbAction"
        Me.cbAction.Size = New System.Drawing.Size(75, 23)
        Me.cbAction.TabIndex = 1
        Me.cbAction.UseVisualStyleBackColor = True
        Me.cbAction.Visible = False
        '
        'tbNumber
        '
        Me.tbNumber.Location = New System.Drawing.Point(37, 124)
        Me.tbNumber.Name = "tbNumber"
        Me.tbNumber.Size = New System.Drawing.Size(217, 20)
        Me.tbNumber.TabIndex = 2
        Me.tbNumber.Visible = False
        '
        'pbxIE
        '
        Me.pbxIE.Image = Global.MobileSiteTester.My.Resources.Resources.iephone
        Me.pbxIE.Location = New System.Drawing.Point(42, 111)
        Me.pbxIE.Name = "pbxIE"
        Me.pbxIE.Size = New System.Drawing.Size(66, 58)
        Me.pbxIE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxIE.TabIndex = 3
        Me.pbxIE.TabStop = False
        '
        'pbxDialer
        '
        Me.pbxDialer.Image = Global.MobileSiteTester.My.Resources.Resources.windialer
        Me.pbxDialer.Location = New System.Drawing.Point(112, 111)
        Me.pbxDialer.Name = "pbxDialer"
        Me.pbxDialer.Size = New System.Drawing.Size(66, 58)
        Me.pbxDialer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDialer.TabIndex = 4
        Me.pbxDialer.TabStop = False
        '
        'pbxSMS
        '
        Me.pbxSMS.Image = Global.MobileSiteTester.My.Resources.Resources.winsms
        Me.pbxSMS.Location = New System.Drawing.Point(183, 111)
        Me.pbxSMS.Name = "pbxSMS"
        Me.pbxSMS.Size = New System.Drawing.Size(66, 58)
        Me.pbxSMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSMS.TabIndex = 5
        Me.pbxSMS.TabStop = False
        '
        'pbxCam
        '
        Me.pbxCam.Location = New System.Drawing.Point(112, 175)
        Me.pbxCam.Name = "pbxCam"
        Me.pbxCam.Size = New System.Drawing.Size(66, 58)
        Me.pbxCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCam.TabIndex = 6
        Me.pbxCam.TabStop = False
        '
        'pbxEMail
        '
        Me.pbxEMail.Image = Global.MobileSiteTester.My.Resources.Resources.winemail
        Me.pbxEMail.Location = New System.Drawing.Point(42, 175)
        Me.pbxEMail.Name = "pbxEMail"
        Me.pbxEMail.Size = New System.Drawing.Size(66, 58)
        Me.pbxEMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEMail.TabIndex = 7
        Me.pbxEMail.TabStop = False
        '
        'pbxSettings
        '
        Me.pbxSettings.Location = New System.Drawing.Point(30, 239)
        Me.pbxSettings.Name = "pbxSettings"
        Me.pbxSettings.Size = New System.Drawing.Size(66, 58)
        Me.pbxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSettings.TabIndex = 8
        Me.pbxSettings.TabStop = False
        '
        'pbxGallery
        '
        Me.pbxGallery.Location = New System.Drawing.Point(183, 175)
        Me.pbxGallery.Name = "pbxGallery"
        Me.pbxGallery.Size = New System.Drawing.Size(66, 58)
        Me.pbxGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGallery.TabIndex = 9
        Me.pbxGallery.TabStop = False
        '
        'tbmsgBody
        '
        Me.tbmsgBody.Location = New System.Drawing.Point(37, 185)
        Me.tbmsgBody.Multiline = True
        Me.tbmsgBody.Name = "tbmsgBody"
        Me.tbmsgBody.Size = New System.Drawing.Size(217, 253)
        Me.tbmsgBody.TabIndex = 10
        Me.tbmsgBody.Visible = False
        '
        'tbSubject
        '
        Me.tbSubject.Location = New System.Drawing.Point(37, 159)
        Me.tbSubject.Name = "tbSubject"
        Me.tbSubject.Size = New System.Drawing.Size(217, 20)
        Me.tbSubject.TabIndex = 11
        Me.tbSubject.Visible = False
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(97, 271)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(39, 13)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Label1"
        Me.lblAddress.Visible = False
        '
        'lblUName
        '
        Me.lblUName.AutoSize = True
        Me.lblUName.Location = New System.Drawing.Point(97, 284)
        Me.lblUName.Name = "lblUName"
        Me.lblUName.Size = New System.Drawing.Size(39, 13)
        Me.lblUName.TabIndex = 13
        Me.lblUName.Text = "Label1"
        Me.lblUName.Visible = False
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Location = New System.Drawing.Point(97, 297)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(39, 13)
        Me.lblPW.TabIndex = 14
        Me.lblPW.Text = "Label1"
        Me.lblPW.Visible = False
        '
        'lblSMTP
        '
        Me.lblSMTP.AutoSize = True
        Me.lblSMTP.Location = New System.Drawing.Point(132, 271)
        Me.lblSMTP.Name = "lblSMTP"
        Me.lblSMTP.Size = New System.Drawing.Size(39, 13)
        Me.lblSMTP.TabIndex = 15
        Me.lblSMTP.Text = "Label1"
        Me.lblSMTP.Visible = False
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(132, 284)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(39, 13)
        Me.lblPort.TabIndex = 16
        Me.lblPort.Text = "Label1"
        Me.lblPort.Visible = False
        '
        'lblSSL
        '
        Me.lblSSL.AutoSize = True
        Me.lblSSL.Location = New System.Drawing.Point(132, 297)
        Me.lblSSL.Name = "lblSSL"
        Me.lblSSL.Size = New System.Drawing.Size(39, 13)
        Me.lblSSL.TabIndex = 17
        Me.lblSSL.Text = "Label1"
        Me.lblSSL.Visible = False
        '
        'lblClose
        '
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Location = New System.Drawing.Point(123, 514)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(43, 23)
        Me.lblClose.TabIndex = 18
        '
        'lblBack
        '
        Me.lblBack.BackColor = System.Drawing.Color.Transparent
        Me.lblBack.Location = New System.Drawing.Point(37, 514)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(31, 23)
        Me.lblBack.TabIndex = 19
        '
        'WinPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MobileSiteTester.My.Resources.Resources.winphone
        Me.ClientSize = New System.Drawing.Size(288, 563)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblSSL)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblSMTP)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.lblUName)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.tbSubject)
        Me.Controls.Add(Me.tbmsgBody)
        Me.Controls.Add(Me.pbxGallery)
        Me.Controls.Add(Me.pbxSettings)
        Me.Controls.Add(Me.pbxEMail)
        Me.Controls.Add(Me.pbxCam)
        Me.Controls.Add(Me.pbxSMS)
        Me.Controls.Add(Me.pbxDialer)
        Me.Controls.Add(Me.pbxIE)
        Me.Controls.Add(Me.tbNumber)
        Me.Controls.Add(Me.cbAction)
        Me.Controls.Add(Me.wbIEMobi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinPhone"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Windows Phone"
        CType(Me.pbxIE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDialer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEMail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGallery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wbIEMobi As System.Windows.Forms.WebBrowser
    Friend WithEvents cbAction As System.Windows.Forms.Button
    Friend WithEvents tbNumber As System.Windows.Forms.TextBox
    Friend WithEvents pbxIE As System.Windows.Forms.PictureBox
    Friend WithEvents pbxDialer As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSMS As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCam As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEMail As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSettings As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGallery As System.Windows.Forms.PictureBox
    Friend WithEvents tbmsgBody As System.Windows.Forms.TextBox
    Friend WithEvents tbSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblUName As System.Windows.Forms.Label
    Friend WithEvents lblPW As System.Windows.Forms.Label
    Friend WithEvents lblSMTP As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents lblSSL As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label
End Class
