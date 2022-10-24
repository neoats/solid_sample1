using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solid_sample1.CustomException;

namespace solid_sample1
{
    public class TestClass
    {
        public void CalculateUsing()
        {
            var calculator = new UsingTimeCalculator();
            var cost = calculator.Calculate(new App1());
            Console.WriteLine($"Total cost for app hourly price{cost}$");
        }

        public void TestLog()
        {
            try
            {
                var appsample = new App1();
                appsample.Open();
                appsample.Close();
                appsample.SendUsingInfoToSmsUser(new Users());

            }
            catch (OutOfMemoryException ex)
            {
                new SoftwareInfoLogger(new MainLogger()).Log(ex.Message);
            }
            catch (FreezeException ex)
            {
                new SoftwareInfoLogger(new ClusterLogger()).Log(ex.Message);
            }

            //add new logger add new exception
        }
    }
}
