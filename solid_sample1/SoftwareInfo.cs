using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_sample1
{
    public class SoftwareInfoLogger
    {
        public void LogToMainServer(string swinfo)
        {
            new MainLogger().Log(swinfo);
        }
    }

    public class MainLogger
    {
        public void Log(string log)
        {
            //send problems log to main server 
        }
    }
}
