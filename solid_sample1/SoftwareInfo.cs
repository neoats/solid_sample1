using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_sample1
{
    public class SoftwareInfoLogger
    {   //top level classes should not depend on lower level classes. we should solve this with abstract
        //log to main server class is depend to mainlogger class
        private readonly ILogger logger;

        public SoftwareInfoLogger(ILogger logger)
        {
                this.logger = logger;
        }
      /*  public void LogToMainServer(string swinfo)
        {
            new MainLogger().Log(swinfo);
        }
        public void LogToClusterServer(string swinfo)
        {
            new ClusterLogger().Log(swinfo);
        }*/
      public void Log(string log)
      {
          logger.Log(log);
      }
    }

    public interface ILogger
    {
        void Log(string log);
    }

    public class MainLogger : ILogger
    {
        public void Log(string log)
        {
            //send problems log to main server 
        }
    }
    public class ClusterLogger : ILogger
    {
        public void Log(string log)
        {
            //send problems log to main server 
        }
    }
}
