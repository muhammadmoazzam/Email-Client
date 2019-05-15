Imports System.Net.Mail
Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential(TextBox1.Text, TextBox5.Text)
        Smtp_Server.Port = TextBox4.Text
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = textbox6.text

        e_mail = New MailMessage()
        e_mail.From = New MailAddress(TextBox1.Text)
        e_mail.To.Add(TextBox2.Text)
        e_mail.Subject = "Email Sending"
        e_mail.IsBodyHtml = False
        e_mail.Body = TextBox3.Text
        Smtp_Server.Send(e_mail)
        MsgBox("Mail Sent")

        'Catch error_t As Exception
        '    MsgBox(error_t.ToString)
        'End Try
    End Sub
End Class
