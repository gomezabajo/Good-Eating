using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net;
using System.Net.Mail;

/// <summary>
/// Descripción breve de SendMail
/// </summary>
public class SendMail
{
    private string smtpAddress = "smtp.server.net";
    private int portNumber = 587;
    private bool enableSSL = false;
    private string emailFrom = "server@server.net";
    private string password = "password";

    public string emailTo = string.Empty;
    public List<string> emailCC = null;
    public string subject = string.Empty;
    public string body = string.Empty;

    public void Send()
    {
        try
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                if (emailCC != null)
                {
                    foreach (string ecc in emailCC)
                    {
                        mail.CC.Add(ecc);
                    }
                }
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                // Can set to false, if you are sending pure text.

                //mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
                //mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

                SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);
                smtp.Credentials = new NetworkCredential(emailFrom, password);
                smtp.EnableSsl = enableSSL;
                smtp.Send(mail);
            }
        }
        catch
        {
            throw;
        }
    }

    public SendMail()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}
