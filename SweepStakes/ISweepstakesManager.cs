using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    interface ISweepstakesManager
    {
        Sweepstakes Sweepstakes { get; set; }

        // member methods
        void InsertSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();
        
    }
}
