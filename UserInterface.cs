using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class UserInterface
    {
        public static string firstName;
        public static string lastName;
        public static int registerNumber;
        public static string email;

        public  static void FirstName()
        {
            Console.WriteLine("Enter Contestant first name");
            firstName = Console.ReadLine();

        }
        public static void LastName()
        {

            Console.WriteLine("Enter Contestant last name");
            lastName = Console.ReadLine();

        }
        public static void RegistrationNumber()
        {
            Console.WriteLine("Enter contestant registration Number");
            registerNumber = int.Parse(Console.ReadLine());

        }

        public static void Email()
        {
            Console.WriteLine("Enter contestant email");
            email = Console.ReadLine();
        }
    }
}
