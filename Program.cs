using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        public static Contestant ContestantName { get; private set; }

        static void Main(string[] args)
        {
            UserInterface.FirstName();
            UserInterface.LastName();
            UserInterface.Email();
            UserInterface.RegistrationNumber();
            Sweepstakes.RegisterContestant(ContestantName);




        }
    }
}
