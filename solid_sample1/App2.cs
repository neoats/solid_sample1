using solid_sample1.SmsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace solid_sample1
{
    internal class App2 : BaseMethod , ISmsSendable , IEmailSendable
    {
        public float price { get; set; }

        public override double GetCost()
        {
            return 1.5;
        }

        public void Open()
        {

        }

        public void Close()
        {

        }

        public void SendUsingInfoEmailToUser(Users user)
        {
            
                if (!string.IsNullOrEmpty(user.EmailAddress))
                {
                    var mailMessage = new MailMessage();
                    mailMessage.To.Add(user.EmailAddress);

                    var client = new SmtpClient("mail.radiogaga.com", 587);
                    client.Send(mailMessage);
                }

        }

        public void SendUsingInfoEmailToUser(List<Users> users)
        {
            foreach (var user in users)
            {
                SendUsingInfoEmailToUser(user);
            }
        }

        public void SendUsingInfoToSmsUser(Users user)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(user.PhoneNumber)))
            {
                var smsSender = new SmsSender();
                smsSender.SendSms(new SmsModel()
                {
                    Message = "open time",
                    PhoneNumber = user.PhoneNumber,
                    SendTime = DateTime.Now
                });

            }
        }
    }
}
