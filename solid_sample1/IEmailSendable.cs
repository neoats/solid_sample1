﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_sample1
{
    public interface IEmailSendable
    {
        public void SendUsingInfoEmailToUser(Users user);

        public void SendUsingInfoEmailToUser(List<Users> user);
    }
}
