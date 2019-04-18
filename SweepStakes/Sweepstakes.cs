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
        public Random rand;
        public Dictionary<int, Contestant> contestantInfo;
        public List<int> contestantNumbers;
        public Contestant winTestant;
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
            contestantInfo = new Dictionary<int, Contestant>();
            contestantNumbers = new List<int>();
    }
        // member methods
        void RegisterContestant(Contestant contestant)
        {
            contestantInfo.Add(contestant.registrationNumber, contestant);
            contestantNumbers.Add(contestant.registrationNumber);
        }
        public string PickWinner()
        { // min = beginning key & max = ending key
            int win = rand.Next(contestantNumbers.Count);
            int winner = contestantNumbers[win];
            Console.WriteLine($"And the winning number is...  {winner}");
            winTestant = contestantInfo[winner];
            return winTestant.firstName + winTestant.lastName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"Congratulations to {winTestant.firstName} {winTestant.lastName}");
        }

    }
}
