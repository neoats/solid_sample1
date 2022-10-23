using solid_sample1.SmsModels;

namespace solid_sample1
{
    public class App1 : BaseMethod ,ISmsSendable
    {
        public float price { get; set; }
        public override double GetCost()
        {
            return 1.25;
        }

        public void Open()
        {
           
        }

        public void Close()
        {

        }

     
        /* public void SendUsingInfoToUser(Users user)
         {
        //separated the methods and wrote them inside the basemethod class.
             if (!string.IsNullOrEmpty(user.EmailAdress))
             {
                 var mailMessage = new MailMessage();
                 mailMessage.To.Add(user.EmailAdress);

                 var client = new SmtpClient("mail.radiogaga.com", 587);
                 client.Send(mailMessage);
             }
             if (!string.IsNullOrEmpty(user.PhoneNumber))
             {
                 var smsSender = new SmsSender();
                 smsSender.SendSms(new SmsModel()
                 {
                     Message = "open time",
                     PhoneNumber = user.PhoneNumber,
                     SendTime= DateTime.Now
                 });

             }
         }*/

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