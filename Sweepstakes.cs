using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{

    public class Sweepstakes
    {
        
        public string input;
       static Dictionary<string, Contestant> contestantName = new Dictionary<string, Contestant>();
        public string Winner;
        Random rand;
        public string name;
        

        public Sweepstakes()
        {
            rand = new Random();
            
        }
            


        public Sweepstakes(string name)
        {

            this.name = name;
            


        }

        public static void RegisterContestant(Contestant contestant)
        {

            contestantName.Add(UserInterface.firstName, contestant);
            contestantName.Add(UserInterface.lastName, contestant);
            contestantName.Add(UserInterface.email, contestant);
            contestantName.Add(UserInterface.registerNumber.ToString(), contestant);
            


        }

        public int PickWinner()
        {
            Dictionary<string, Contestant> sweepstakesWinner = new Dictionary<string, Contestant>();
            int randWin = 0;
            for (int i = 0; i < sweepstakesWinner.Count; i++)
            {
               randWin = rand.Next(sweepstakesWinner.Count);
            }
            return randWin;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.registrationNumber);
            Console.WriteLine(contestant.email);

        }



    }


}
