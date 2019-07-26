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
            

        public Sweepstakes()
        {
            
        }

        public void SweepstakesNames(string name)
        {
            
           
  
        }

        public void RegisterContestant(Contestant contestant)
        {
            
            contestantName.Add(contestant.email, contestant);



        }

        public void PickWinner()
        {
            Dictionary<string, string> sweepstakesWinner = new Dictionary<string, string>();

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Dictionary<string, UserInterface> information = new Dictionary<string, UserInterface>();
            Console.ReadLine();

        }



    }


}
