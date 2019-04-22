using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        // member variables
        public Sweepstakes Sweepstakes;
        public Queue<Sweepstakes> SweepstakesQueue;

        // constructor
        public SweepstakesQueueManager()
        {
            Queue<Sweepstakes> SweepstakesQueue = new Queue<Sweepstakes>();
        }

        // member methods
        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakesName)
        {
            SweepstakesQueue.Enqueue(sweepstakesName);
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            return SweepstakesQueue.Dequeue();
        }
    }
}
