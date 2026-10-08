using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackProject.Interface;

namespace BackProject.Models
{
    public class Cleaner :Person , IWorker
    {
        public int WorkHour()
        {
            Console.WriteLine("You should work daily Except for Fridays, at an average of 5 hours.");
            return 5;
        }
        public string TypeOfWork()
        {
            return "Cleaning gym facilities and organizing equipment.";

        }
        public int PriceOfWorkHour()
        {
            return WorkHour() * 10;

        }
        public override void JobTitle()
        {
            Console.WriteLine("Cleaner");

        }


    }
}
