using CommonLayer.Services;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Managers
{
    public class EmailBuilderManager : IEmailBuilderService
    {
        public MimeMessage BuildEmail(string fromEmail, string toEmail, string subject, string body)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Admin", fromEmail));
            mimeMessage.To.Add(new MailboxAddress("User", toEmail));

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = subject;

            return mimeMessage;
        }

        public MimeMessage BuildEmailConfirmation(string fromEmail, string toEmail, string subject, string body)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("Admin", fromEmail));
            mimeMessage.To.Add(new MailboxAddress("User", toEmail));

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = subject;

            return mimeMessage;
        }
    }
}
