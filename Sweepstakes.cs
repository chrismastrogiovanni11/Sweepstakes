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
       static Dictionary<int, Contestant> contestantName = new Dictionary<int, Contestant>();
        public string Winner;
        Random rand;
        public string name;
        int counter = 1;

        public Sweepstakes()
        {
            rand = new Random();
            
        }
            


        public Sweepstakes(string name)
        {

            this.name = name;
            


        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = counter;
            contestantName.Add(contestant.registrationNumber, contestant);
            counter++;
        }

        public string PickWinner()
        {
               int randWin = rand.Next(1,contestantName.Count);
               var winner = contestantName[randWin];
            
            return winner.firstName + winner.lastName;
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
