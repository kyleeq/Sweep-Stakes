using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        // member variables
        Random rand;
        public Contestant Contestant;

        // constructor
        public Sweepstakes(string name)
        {
            rand = new Random();
            Dictionary<string, Contestant> contestantInfo = new Dictionary<string, Contestant>();
        }
        // member methods
        public string PickWinner(int min, int max)
        {
            int winner = rand.Next(1000, 10000);

            return $"Congratulation ";
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
