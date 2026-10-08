using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackProject.Interface;


namespace BackProject.Services
{
    public class Visa : IPay
    {
        public void Pay()
        {
            Console.WriteLine("visa");

        }


    }
}
