using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        // member variables
        Contestant contestant;
        Queue<Sweepstakes> SweepstakesQueue;
        Sweepstakes Sweepstakes { get; set; }


        // constructor
        public SweepstakesQueueManager()
        {
            Queue<Sweepstakes> SweepstakesQueue = new Queue<Sweepstakes>();
        }

        // member methods
        void InsertSweepstakes(Sweepstakes sweepstakesName)
        {
            SweepstakesQueue.Enqueue(sweepstakesName);
        }

        public Sweepstakes GetSweepstakes()
        {
            return SweepstakesQueue.Dequeue();
        }
    }
}
