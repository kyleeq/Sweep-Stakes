using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager 
    {
        // member variable
        public Sweepstakes Sweepstakes;
        public Stack<Sweepstakes> SweepstakesStack;


        // constructor
        public SweepstakesStackManager()
        {
            Stack<Sweepstakes> SweepstakesStack = new Stack<Sweepstakes>();
        }

        // member method
        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakesName)
        {
            SweepstakesStack.Push(sweepstakesName);
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            return SweepstakesStack.Pop();
        }
    }
}
