using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackProject.Services
{
    public class Calculation
    {
       public Func<string, int> CalculationFees = time =>
        {
            Console.Write("Daily Or Monthly Or Yearly : ");
            string TheType = Console.ReadLine()?.ToLower();
            if (TheType == "daily")
            {
              
                return 1 * 7;
                
            }
            if (TheType == "monthly")
            {
              
                return 30 * 6;
                

            }
            if (TheType == "yearly")

            { 
                return 365 * 5;
            }

            return 0;
       };
    }
}
