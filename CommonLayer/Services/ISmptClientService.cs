using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Services
{
    public interface ISmptClientService
    {
        SmtpClient CreateSmtpClient(string smptServer, int smptPort, string smptUsername, string smtpPassword);
    }
}
