using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ga.Services;
using System.Windows;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace Ga.ViewModels
{
    class LoginViewModel : ObservableObject
    {
        readonly DB dB = new();

        string _loginId;
        public string LoginId { get => _loginId; set => OnPropertyChanged(ref _loginId, value); }

        public void Login()
        {
            var user =  dB.Users.Where(c => c.Mail == _loginId).FirstOrDefault();

            if(user == null)
            {
                MessageBox.Show("Erreur","Erreur", MessageBoxButton.OK);
            }
            else
            {
                sendEmail(user.Mail);
                MessageBox.Show("OK", "OK", MessageBoxButton.OK);
            }
            
        }

        public void sendEmail(string mail)
        {
            var smtpServerName = ConfigurationManager.AppSettings["SmtpServer"];
            var port = ConfigurationManager.AppSettings["Port"];
            var senderEmailId = ConfigurationManager.AppSettings["SenderEmailId"];
            var senderPassword = ConfigurationManager.AppSettings["SenderPassword"];

            string to = mail;
            string from = "andry@gmail.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the new SMTP client.";
            message.Body = @"Using this new feature, you can send an email message from an application very easily.";
            SmtpClient client = new SmtpClient(smtpServerName,Convert.ToInt32(port));
            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(senderEmailId, senderPassword);
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }


        }
    }
}
