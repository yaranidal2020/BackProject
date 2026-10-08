using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackProject.Interface;

namespace BackProject.Models
{
    public class Trainer : Person , IWorker
    {
        public int WorkHour()
        {
            Console.WriteLine("You should work daily Except for Fridays, at an average of 6 hours.");
            return 6;
        }
        public string TypeOfWork()
        {
            return "Training participants with appropriate exercises and focusing on the work.";

        }
        public int PriceOfWorkHour()
        {
            return WorkHour() * 20;

        }
        public override void JobTitle()
        {
            Console.WriteLine("Trainer");

        }

    }
}
