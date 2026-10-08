using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using BackProject.Interface;

namespace BackProject.Services
{
    public class Pay
    {
        public void TypeOfPay(IPay payType)
        {
            payType.Pay();
           
        }

        public bool CompletePayment()
        {
            Console.Write("Has the payment been completed successfully? (yes/no): ");
            string answer = Console.ReadLine()?.ToLower();
            
            if (answer=="yes" || answer == "y")
            {
                Console.WriteLine("You can train now !");
                return true;
            }
            else
            {
                Console.WriteLine("You should Pay");
                return false;
            }
        }
    }
}
