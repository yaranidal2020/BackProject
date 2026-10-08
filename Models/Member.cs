using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackProject.Models
{
     public class Member : Person
     {
        public string TypeOfSubscription { get; set; }
        public string TypeOfExercise { get; set; }
            public override void JobTitle()
            {
            Console.WriteLine("Member");
 
            }
        public Trainer trainerOfMember { get; set; }

        public Member(string MemberName ,int MemberId , Trainer trainerMember) : base(MemberName, MemberId)
        {
            this.trainerOfMember = trainerMember;
        }




     }
}
