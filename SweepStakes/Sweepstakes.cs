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
        Dictionary<int, Contestant> contestantInfo;
        public Contestant Contestant;
        public string SweepstakesName
        {
            get
            {
                string sweepstakesName = UserInterface.SweepstakePrompt();
                return sweepstakesName;
            }
        }

        // constructor
        public Sweepstakes(string sweepstakesName)
        {
            rand = new Random();
            Dictionary<int, Contestant> contestantInfo = new Dictionary<int, Contestant>();
        }
        // member methods
        void RegisterContestant(Contestant contestant)
        {
            contestantInfo.Add(contestant.registrationNumber, contestant);
        }
        public string PickWinner(int min, int max)
        { // min = beginning key & max = ending key
            int winner = rand.Next(contestantInfo.Count);

            return $"And the winning number is...  ";
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
