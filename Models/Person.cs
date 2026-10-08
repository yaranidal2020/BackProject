using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackProject.Models
{
    public class Person
    {
       public string Name {get; set;}
       public int Age {get; set;}
       public string Phone { get; private set;}
       public int Id {get; private set;}
       public virtual void JobTitle() {
            Console.WriteLine("JobTitle");
       }
        public Person() { }
       
        

        public Person(string MemberName,int MemberId)
        {
            this.Name = MemberName;
            this.Id = MemberId;
        }

    }
}
