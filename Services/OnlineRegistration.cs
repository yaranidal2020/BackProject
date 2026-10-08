using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackProject.Interface;

namespace BackProject.Services
{
    public class OnlineRegistration : IRegistration
    {
        public Dictionary<int, string> MemberRegistration(int memberId, string memberName)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(memberId, memberName);
            Console.WriteLine("We add you on the System whith Type of Registration : Online");
            return dic;
        }
    }

    
}
