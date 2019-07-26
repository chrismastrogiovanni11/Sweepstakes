using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{

    
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public int registrationNumber;
        public string email;

        public Contestant()
        {
            firstName = UserInterface.firstName;
            lastName = UserInterface.lastName;
            registrationNumber = UserInterface.registerNumber;
            email = UserInterface.email;
        }

    }
}