using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            catch (ExecutionEngineException ex)
            {
                new SoftwareInfoLogger().LogToMainServer(ex);
            }
        }
    }
}
