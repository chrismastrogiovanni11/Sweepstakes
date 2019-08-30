using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Factory
    {
        public ISweepstakesManager CreateManager(string input)
        {
            ISweepstakesManager manager = null;
            switch (input)
            {
                case "stack":
                   return manager = new SweepstakesStackManager();
                    
                case "queue":
                   return manager = new SweepstakesQueueManager();
                    
            }
            return manager;
        }
    }

}
