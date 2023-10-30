using CommonLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Managers
{
    public class EmailSenderManager : IEmailSenderService
    {
        private readonly ISmptClientService _smtpClientService;
        private readonly IEmailBuilderService _emailBuilderService;

        public EmailSenderManager(ISmptClientService smtpClientService, IEmailBuilderService emailBuilderService)
        {
            _smtpClientService = smtpClientService;
            _emailBuilderService = emailBuilderService;
        }


        public async Task SendConfirmationEmail(string fromEmail, string toEmail, string subject, string body)
        {

            var mimeMessage = _emailBuilderService.BuildEmail(fromEmail, toEmail, subject, body);
            using (var client = _smtpClientService.CreateSmtpClient("smtp.gmail.com", 587, "onurabdulaji@gmail.com", "emqqkljmtmfgnmaa"))
            {
                try
                {
                    await client.SendAsync(mimeMessage);
                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    throw new Exception("E-posta gönderme hatası: " + ex.Message, ex);
                }
            }
        }

        public void SendEmail(string fromEmail, string toEmail, string subject, string body)
        {
            var mimeMessage = _emailBuilderService.BuildEmail(fromEmail, toEmail, subject, body);

            using (var client = _smtpClientService.CreateSmtpClient("smtp.gmail.com", 587, "onurabdulaji@gmail.com", "emqqkljmtmfgnmaa"))
            {
                client.Send(mimeMessage);
                client.Disconnect(true);
            }
        }

        public async Task SendEmailAsync(string fromEmail, string toEmail, string subject, string body)
        {
            var mimeMessage = _emailBuilderService.BuildEmail(fromEmail, toEmail, subject, body);

            using (var client = _smtpClientService.CreateSmtpClient("smtp.gmail.com", 587, "onurabdulaji@gmail.com", "emqqkljmtmfgnmaa"))
            {
                try
                {
                    await client.SendAsync(mimeMessage);
                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    throw new Exception("E-posta gönderme hatası: " + ex.Message, ex);
                }

            }
        }
    }
}
