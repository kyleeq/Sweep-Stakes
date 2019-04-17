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
        int initialKey;

        // constructor
        public Sweepstakes(string name)
        {
            initialKey = 1000;
            rand = new Random();
            Dictionary<int, Contestant> contestantInfo = new Dictionary<int, Contestant>();
        }
        // member methods
        void RegisterContestant(Contestant contestant)
        {
            contestantInfo.Add(initialKey);
        }
        public string PickWinner(int min, int max)
        { // min = beginning key & max = ending key
            int winner = rand.Next(1000, 10000);

            return $"And the winning number is...  ";
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
