using HotCatCafe.Common.EmailHelpers.Abstracts;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace HotCatCafe.Common.EmailHelpers.Concretes
{
    public class EMailService : IEmailService
    {
        readonly IConfiguration _config;

        public EMailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendMessageAsync(string to, string subject, string body)
        {
            MailMessage mail = new();
            mail.To.Add(to);
            mail.Subject=subject;
            mail.Body=body;
            mail.From = new(_config["Mail:Username"],"HotCatCafeYetkilisi",System.Text.Encoding.UTF8);

            SmtpClient smtp = new();
            smtp.Credentials = new NetworkCredential(_config["Mail:Username"], _config["Mail:Password"]);
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Host= "smtp-mail.outlook.com";
            await smtp.SendMailAsync(mail);

        }
    }
}
