using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{

    //use dictionary
    public class Sweepstakes
    {
        Contestant contestant = new Contestant();
        public string input;

        public Contestant UserInterface { get; private set; }

        public void SweepstakesNames(string name)
        {
            
            Dictionary<string, UserInterface> contestantName = new Dictionary<string, UserInterface>();
            contestantName.Add(contestant.email , UserInterface);
            
  
        }

        public void RegisterContestant(Contestant contestant)
        {
            Dictionary<int, string> contestantRegistration = new Dictionary<int, string>();
            contestantRegistration.Add(contestant.registrationNumber, contestant.firstName);
            contestantRegistration.Add(6874, "Seth");
            contestantRegistration.Add(5322, "Robert");
            contestantRegistration.Add(3238, "Isabell");
            contestantRegistration.Add(2408, "James");

            

        }

        public void PickWinner()
        {
            Dictionary<string, string> sweepstakesWinner = new Dictionary<string, string>();

        }

        public void PrintContestantInfo(Contestant contestant)
        {

            Console.ReadLine();

        }



    }


}
