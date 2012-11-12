Imports System.Net.Mail
Imports Microsoft.Win32

Public Class WinPhone
    Public WithEvents oSkype As New SKYPE4COMLib.Skype

    Private Sub WinPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNumber.Visible = False
        cbAction.Visible = False
        wbIEMobi.Navigate(ControlPanel.tbWebLocation.Text)
        wbIEMobi.Hide()

        Dim regemail As String
        Dim reguname As String
        Dim regPW As String
        Dim regSMTP As String
        Dim regPort As String
        Dim regSSL As String
        regemail = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Phonegap Phone Emulator", "E-Mail Address", Nothing)
        reguname = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Phonegap Phone Emulator", "User Name", Nothing)
        regPW = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Phonegap Phone Emulator", "Password", Nothing)
        regSMTP = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Phonegap Phone Emulator", "SMTP", Nothing)
        regPort = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Phonegap Phone Emulator", "Port", Nothing)
        regSSL = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Phonegap Phone Emulator", "SSL", Nothing)
        lblAddress.Text = regemail
        lblUName.Text = reguname
        lblPW.Text = regPW
        lblSMTP.Text = regSMTP
        lblPort.Text = regPort
        lblSSL.Text = regSSL
    End Sub

    Private Sub pbxIE_Click(sender As Object, e As EventArgs) Handles pbxIE.Click
        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False
        wbIEMobi.Show()
    End Sub

    Private Sub wbIEMobi_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbIEMobi.DocumentCompleted
        Dim link As HtmlElement
        Dim links As HtmlElementCollection = wbIEMobi.Document.Links

        For Each link In links
            Dim digits As String = link.GetAttribute("HREF")

            If ((digits IsNot Nothing) And (digits.StartsWith("txt:"))) Then
                link.AttachEventHandler("onclick", AddressOf TXTMSGer)
            ElseIf ((digits IsNot Nothing) And (digits.StartsWith("tel:"))) Then
                link.AttachEventHandler("onclick", AddressOf PhoneNumberClick)
            ElseIf ((digits IsNot Nothing) And (digits.StartsWith("sms:"))) Then
                link.AttachEventHandler("onclick", AddressOf SMSer)
            ElseIf ((digits IsNot Nothing) And (digits.StartsWith("mms:"))) Then
                link.AttachEventHandler("onclick", AddressOf MMSer)
            ElseIf ((digits IsNot Nothing) And (digits.StartsWith("mailto:"))) Then
                link.AttachEventHandler("onclick", AddressOf EMAIL)
            End If
        Next
    End Sub

    Private Sub TXTMSGer(ByVal sender As Object, ByVal e As EventArgs)
        wbIEMobi.AllowNavigation = False
        Dim link As HtmlElement = wbIEMobi.Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        wbIEMobi.Hide()
        tbNumber.Visible = True
        tbmsgBody.Visible = True
        cbAction.Visible = True
        cbAction.Text = "Send"
        tbNumber.Text = url.Remove(0, 6).Replace("-", "").Replace("+", "")
    End Sub

    Private Sub EMAIL(ByVal sender As Object, ByVal e As EventArgs)
        wbIEMobi.AllowNavigation = False
        Dim link As HtmlElement = wbIEMobi.Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        wbIEMobi.Hide()
        tbNumber.Visible = True
        tbSubject.Visible = True
        tbmsgBody.Visible = True
        cbAction.Visible = True
        cbAction.Text = "Send"
        tbNumber.Text = url.Remove(0, 7)
    End Sub

    Private Sub PhoneNumberClick(ByVal sender As Object, ByVal e As EventArgs)
        wbIEMobi.AllowNavigation = False
        Dim link As HtmlElement = wbIEMobi.Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        wbIEMobi.Hide()
        tbNumber.Visible = True
        cbAction.Visible = True
        cbAction.Text = "Call"
        tbNumber.Text = url.Remove(0, 4).Replace("-", "")
    End Sub

    Private Sub SMSer(ByVal sender As Object, ByVal e As EventArgs)
        wbIEMobi.AllowNavigation = False
        Dim link As HtmlElement = wbIEMobi.Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        wbIEMobi.Hide()
        tbNumber.Visible = True
        tbmsgBody.Visible = True
        cbAction.Visible = True
        cbAction.Text = "Send"
        tbNumber.Text = url.Remove(0, 6).Replace("-", "").Replace("+", "")
    End Sub

    Private Sub MMSer(ByVal sender As Object, ByVal e As EventArgs)
        wbIEMobi.AllowNavigation = False
        Dim link As HtmlElement = wbIEMobi.Document.ActiveElement
        Dim url As String = link.GetAttribute("href")

        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        wbIEMobi.Hide()
        tbNumber.Visible = True
        tbmsgBody.Visible = True
        cbAction.Visible = True
        cbAction.Text = "Send"
        tbNumber.Text = url.Remove(0, 6).Replace("-", "").Replace("+", "")
    End Sub

    Private Sub cbAction_Click(sender As Object, e As EventArgs) Handles cbAction.Click
        If cbAction.Visible = True And cbAction.Text = "Call" Then
            oSkype.PlaceCall(tbNumber.Text)
            cbAction.Text = "End"
        ElseIf cbAction.Visible = True And cbAction.Text = "Send" And tbSubject.Visible = True Then
            Dim email As New MailMessage
            Dim mailfrom As String
            Dim mailto As String

            mailfrom = lblAddress.Text
            mailto = tbNumber.Text

            email.To.Add(mailto)
            email.From = New MailAddress(mailfrom)
            email.Body = tbmsgBody.Text

            Dim sendserver As String

            sendserver = lblSMTP.Text
            Dim SMTP As New SmtpClient(sendserver)
            Dim username As String
            Dim password As String

            username = lblUName.Text
            password = lblPW.Text

            If lblSSL.Text = "Yes" Then
                SMTP.EnableSsl = True
            Else : SMTP.EnableSsl = False
            End If

            SMTP.Credentials = New System.Net.NetworkCredential(username, password)
            Dim portnum As String

            portnum = lblPort.Text
            SMTP.Port = portnum
            SMTP.Send(email)
            MessageBox.Show("Message Sent")
        ElseIf cbAction.Visible = True And cbAction.Text = "Send" And tbSubject.Visible = False Then
            Dim email As New MailMessage
            Dim mailfrom As String
            Dim mailto As String

            mailfrom = lblAddress.Text
            mailto = tbNumber.Text
            'Now lets add our SMS Gateways
            email.Bcc.Add(mailto + "@myboostmobile.com")
            email.Bcc.Add(mailto + "@vtext.com")
            email.Bcc.Add(mailto + "@sms.airfiremobile.com")
            email.Bcc.Add(mailto + "@msg.acsalaska.com")
            email.Bcc.Add(mailto + "@sms.alltelwireless.com")
            email.Bcc.Add(mailto + "@mms.alltelwireless.com")
            email.Bcc.Add(mailto + "@message.Alltel.com")
            email.Bcc.Add(mailto + "@text.wireless.alltel.com")
            email.Bcc.Add(mailto + "@mms.alltel.net")
            email.Bcc.Add(mailto + "@paging.acswireless.com")
            email.Bcc.Add(mailto + "@txt.att.net")
            email.Bcc.Add(mailto + "@mmode.com")
            email.Bcc.Add(mailto + "@mms.att.net")
            email.Bcc.Add(mailto + "@txt.att.net")
            email.Bcc.Add(mailto + "@cingularme.com")
            email.Bcc.Add(mailto + "@mobile.mycingular.com")
            email.Bcc.Add(mailto + "@page.att.net")
            email.Bcc.Add(mailto + "@sms.smartmessagingsuite.com")
            email.Bcc.Add(mailto + "@bellsouth.cl")
            email.Bcc.Add(mailto + "@sms.bluecell.com")
            email.Bcc.Add(mailto + "@mms.myblueworks.com")
            email.Bcc.Add(mailto + "@cellcom.quiktxt.com")
            email.Bcc.Add(mailto + "@csouth1.com")
            email.Bcc.Add(mailto + "@cwemail.com")
            email.Bcc.Add(mailto + "@sms.cvalley.net")
            email.Bcc.Add(mailto + "@cingular.com")
            email.Bcc.Add(mailto + "@cingular.com")
            email.Bcc.Add(mailto + "@mobile.mycingular.com")
            email.Bcc.Add(mailto + "@cingulartext.com")
            email.Bcc.Add(mailto + "@sms.cleartalk.us")
            email.Bcc.Add(mailto + "@sms.mycricket.com")
            email.Bcc.Add(mailto + "@mms.mycricket.com")
            email.Bcc.Add(mailto + "@cspire1.com")
            email.Bcc.Add(mailto + "@sms.edgewireless.com")
            email.Bcc.Add(mailto + "@SMS.elementmobile.net")
            email.Bcc.Add(mailto + "@mobile.gci.net")
            email.Bcc.Add(mailto + "@gscsms.com")
            email.Bcc.Add(mailto + "@hawaii.sprintpcs.com")
            email.Bcc.Add(mailto + "@myhelio.com")
            email.Bcc.Add(mailto + "@iwirelesshometext.com")
            email.Bcc.Add(mailto + "@mobile.kajeet.net")
            email.Bcc.Add(mailto + "@text.longlines.com")
            email.Bcc.Add(mailto + "@mymetropcs.com")
            email.Bcc.Add(mailto + "@messaging.sprintpcs.com")
            email.Bcc.Add(mailto + "@pm.sprint.com")
            email.Bcc.Add(mailto + "@messaging.nextel.com")
            email.Bcc.Add(mailto + "@page.nextel.com")
            email.Bcc.Add(mailto + "@tmomail.net")
            email.From = New MailAddress(mailfrom)
            email.Subject = tbSubject.Text
            email.Body = tbmsgBody.Text

            Dim sendserver As String

            sendserver = lblSMTP.Text
            Dim SMTP As New SmtpClient(sendserver)
            Dim username As String
            Dim password As String

            username = lblUName.Text
            password = lblPW.Text

            If lblSSL.Text = "Yes" Then
                SMTP.EnableSsl = True
            Else : SMTP.EnableSsl = False
            End If

            SMTP.Credentials = New System.Net.NetworkCredential(username, password)
            Dim portnum As String

            portnum = lblPort.Text
            SMTP.Port = portnum
            SMTP.Send(email)
            MessageBox.Show("Message Sent")
        End If
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        pbxIE.Visible = True
        pbxDialer.Visible = True
        pbxSettings.Visible = True
        pbxSMS.Visible = True
        pbxCam.Visible = True
        pbxEMail.Visible = True
        pbxGallery.Visible = True
        tbNumber.Visible = False
        tbSubject.Visible = False
        cbAction.Visible = False
        wbIEMobi.Hide()
    End Sub

    Private Sub pbxDialer_Click(sender As Object, e As EventArgs) Handles pbxDialer.Click
        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        tbNumber.Visible = True
        cbAction.Visible = True
        cbAction.Text = "Call"
    End Sub

    Private Sub pbxSMS_Click(sender As Object, e As EventArgs) Handles pbxSMS.Click
        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        tbNumber.Visible = True
        cbAction.Visible = True
        cbAction.Text = "Send"
    End Sub

    Private Sub pbxEMail_Click(sender As Object, e As EventArgs) Handles pbxEMail.Click
        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        pbxIE.Visible = False
        pbxDialer.Visible = False
        pbxSettings.Visible = False
        pbxSMS.Visible = False
        pbxCam.Visible = False
        pbxEMail.Visible = False
        pbxGallery.Visible = False

        tbNumber.Visible = True
        tbSubject.Visible = True
        cbAction.Visible = True
        cbAction.Text = "Send"
    End Sub
End Class