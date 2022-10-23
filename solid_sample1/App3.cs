using solid_sample1.SmsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_sample1
{
    public class App3 : BaseMethod, ISmsSendable, IEmailSendableMulti
    {
        public override double GetCost()
        {
            throw new NotImplementedException();
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

  
        public void SendUsingInfoEmailToUser(List<Users> users)
        {
            foreach (var user in users)
            {
                SendUsingInfoEmailToUser(user);
            }
        }
    }
}
