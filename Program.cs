using BackProject.Extensions;
using BackProject.Interface;
using BackProject.Models;
using BackProject.Services;

namespace BackProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    GYM MANAGEMENT SYSTEM INTEGRATION TEST   ");
            Console.WriteLine();
            Trainer trainer1 = new Trainer();
            Cleaner cleaner1 = new Cleaner();
            
            trainer1.Name = "Sara";
            Member member1 = new Member("yara",101,trainer1);
            Console.WriteLine($"The Mmber : {member1.Name}   || Assigned Trainer : {trainer1.Name} ");

            Calculation c1 = new Calculation();
            int amount = c1.CalculationFees("");
            Console.WriteLine();
            Console.Write($"{member1.Name} subscription fees are: ");
            amount.Coin();
            Console.WriteLine();

            Pay pay1 = new Pay();
            Console.Write($"{member1.Name} Want to pay ");
            pay1.TypeOfPay(new CashPay());
            Console.WriteLine();

            bool isSuccess = pay1.CompletePayment();
            if (isSuccess) {
                Registration registrationService = new Registration();
                registrationService.RegistrationMembr(new OnlineRegistration (), member1.Id, member1.Name);
                Console.WriteLine($"{member1.Name} has been successfully added to the Registration system!");

            }
            else
            {
                Console.WriteLine($"Failed: Registration canceled for {member1.Name} due to incomplete payment.");
            }



        }
    }
}
