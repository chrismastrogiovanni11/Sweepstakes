using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{

    //use stack as underlying structure
    class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> Manager = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Manager.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return Manager.Pop();
            
        }

    }
    
    
}
