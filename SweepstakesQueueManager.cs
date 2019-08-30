using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    //use Queue as underlying structure
    class SweepstakesQueueManager:ISweepstakesManager
    {
        public Queue<Sweepstakes> Manager = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Manager.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {

            return Manager.Dequeue();
        }



    }
}
