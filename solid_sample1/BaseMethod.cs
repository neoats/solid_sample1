using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using solid_sample1.SmsModels;

namespace solid_sample1
{
    public abstract  class BaseMethod
    {
        public float price { get; set; }

        public abstract double GetCost();


        #region seperate implementation for liskov
      /*  public void SendUsingInfoEmailToUser(Users user)
        {
            if (!string.IsNullOrEmpty(user.EmailAddress))
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(user.EmailAddress);

                var client = new SmtpClient("mail.radiogaga.com", 587);
                client.Send(mailMessage);
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
*/

        #endregion

    }
}
