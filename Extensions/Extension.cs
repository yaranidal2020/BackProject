using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackProject.Extensions
{
    public static class Extension
    {
        public static void Coin(this int fees)
        {
            Console.WriteLine($"{fees}$");
        }


    }
}
