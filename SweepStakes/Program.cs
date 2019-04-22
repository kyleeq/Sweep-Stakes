using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate marketing firm
            ISweepstakesManager sweepstakesManagerQueue = new SweepstakesQueueManager();
            ISweepstakesManager sweepstakesManagerStack = new SweepstakesStackManager();

            // marketting does functionality upon injection
            MarketingFirm marketingFirm = new MarketingFirm(UserInterface.StackOrQueuePrompt()); ; // interchangable with sweepstakesManagerStack depending on the user's choice
                                   
        }
    }
}
