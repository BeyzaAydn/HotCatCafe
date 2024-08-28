using System.Net;
using System.Net.Mail;

namespace HotCatCafe.CMN.EmailHelpers
{
    public  class EmailSender
    {
        public static void SendEmail(string email,string subject,string body) 
        {
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("hotcatcafe1@outlook.com", "HotCatCafe");
            sender.Subject = subject;
            sender.Body = body;
            sender.To.Add(email);

            //smtp
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("hotcatcafe1@outlook.com", "dody9yy3E,.");
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;

            smtpClient.Send(sender);

        }

        //public static void SendConfirmEmail(string email, string subject, string body)
        //{
        //    MailMessage sender = new MailMessage();
        //    sender.From = new MailAddress("hotcatcafe1@outlook.com", "HotCat Cafe Aktivasyon Maili");
        //    sender.Subject = subject;
        //    sender.Body = body;
        //    sender.To.Add(email);

        //    //smtp
        //    SmtpClient smtpClient = new SmtpClient();
        //    smtpClient.Credentials = new NetworkCredential("hotcatcafe1@outlook.com", "dody9yy3E,.");
        //    smtpClient.Host = "smtp-mail.outlook.com";
        //    smtpClient.Port = 587;
        //    smtpClient.EnableSsl = true;

        //    smtpClient.Send(sender);

        //}
    }
}
