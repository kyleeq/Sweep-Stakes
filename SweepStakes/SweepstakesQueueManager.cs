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
        public Sweepstakes Sweepstakes;
        public Queue<Sweepstakes> SweepstakesQueue;

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

        Sweepstakes GetSweepstakes()
        {
            return SweepstakesQueue.Dequeue();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }
    }
}
