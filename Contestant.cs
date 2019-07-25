using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{

    //use interface
    public class Contestant:UserInterface
    {
        public string firstName;
        public string lastName;
        public int registrationNumber;
        public string email;
        public void FirstName()
        {
            Console.WriteLine("Enter contestant first name");
            firstName = Console.ReadLine();
            
        }
        public void LastName()
        {
            Console.WriteLine("Enter contestant last name");
            lastName = Console.ReadLine();
        }

        public void RegistrationNumber()
        {
            Console.WriteLine("Enter contestant registration number");
            registrationNumber = int.Parse(Console.ReadLine());
        }

        public void Email()
        {
            Console.WriteLine("Enter contestant email address");
            email = Console.ReadLine();
        }
    }
}
