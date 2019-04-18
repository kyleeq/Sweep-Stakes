using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager : ISweepstakesManager 
    {
        // member variable
        Sweepstakes Sweepstakes { get; set; }


        // constructor
        public SweepstakesStackManager()
        {
            Stack<Sweepstakes> SweepstakesStack = new Stack<Sweepstakes>();
        }

        // member method
        void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        Sweepstakes GetSweepstakes()
        {

        }


    }
}
