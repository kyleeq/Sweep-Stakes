using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        // member variables
        ISweepstakesManager SweepstakesManager;
        
        // constructor
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            SweepstakesManager = sweepstakesManager;
        }
       
        // member methods
    }
}
