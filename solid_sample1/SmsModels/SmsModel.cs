using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_sample1.SmsModels
{
    public class SmsModel
    {
        public int PhoneNumber { get; set; }

        public string Message { get; set; }

        public DateTime? SendTime { get; set; }
    }
}
