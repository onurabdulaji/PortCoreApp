using CommonLayer.Services;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Managers
{
    public class SmptClientManager : ISmptClientService
    {
        public SmtpClient CreateSmtpClient(string smptServer, int smptPort, string smptUsername, string smtpPassword)
        {
            var client = new SmtpClient();
            client.Connect(smptServer, smptPort, false);
            client.Authenticate(smptUsername, smtpPassword);
            return client;
        }
    }
}
