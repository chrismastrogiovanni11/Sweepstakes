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
        
        public string input;
        public Contestant contestant;
        Dictionary<string, Contestant> contestantName = new Dictionary<string, Contestant>();
        public string Winner;
        Random rand;
        

        public Sweepstakes()
        {
            rand = new Random();
            
        }
            


        public void SweepstakesNames(string name)
        {

            name = contestant.firstName + contestant.lastName;
            Console.ReadLine();


        }

        public void RegisterContestant(Contestant contestant)
        {
            
            contestantName.Add(contestant.email, contestant);



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
            Dictionary<string, Contestant> information = new Dictionary<string, Contestant>();
            Console.ReadLine();

        }



    }


}
