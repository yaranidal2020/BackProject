using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackProject.Interface
{
    public interface IWorker
    {
        int WorkHour();
        string TypeOfWork();
        int PriceOfWorkHour();
    }
}
