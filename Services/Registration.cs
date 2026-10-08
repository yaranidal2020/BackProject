using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using BackProject.Interface;

namespace BackProject.Services
{
    public class Registration  
    {
        public Dictionary<int, string> RegistrationMembr(IRegistration registration,int id ,string name)
        {

            return registration.MemberRegistration(id, name);
        }
    }


    
}
