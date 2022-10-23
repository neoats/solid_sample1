using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace solid_sample1
{
    public class UsingTimeCalculator
    {
        //we have made changes in the code and we have to add something every time, this breaks the close principle

        /* public double Calculate(BaseMethod total)
         {


             if (total is App1)
                 return total.price * 0.9;
             else if (total is App2)
                 return total.price * 0.5;
             else
                 return total.price = 0;
         }
 */
        public double Calculate(BaseMethod total)
        {
            return total.price * total.GetCost();
        }
    }
}
