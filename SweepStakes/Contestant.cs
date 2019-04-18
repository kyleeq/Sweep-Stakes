using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        // member variables
        
        public string firstName;
        public string lastName;
        public string emailAddress;

        public int registrationNumber;
        public Random rand;

        public List<int> contestantNumbers = new List<int>();

        // constructor
        public Contestant(string firstName, string lastName, string emailAddress)
        {
            rand = new Random();
        }

        // member methods
        public void GetInfo()
        {
            firstName = UserInterface.FirstNamePrompt();
            lastName = UserInterface.LastNamePrompt();
            emailAddress = UserInterface.EmailAddress();
        }

        public int GetRegistrationNumber(int min, int max)
        {
            registrationNumber = rand.Next(1000, 10000);
            Console.WriteLine($"You're registration number is {registrationNumber}. Make sure to write it down!");
            contestantNumbers.Add(registrationNumber);
            return registrationNumber;
        }
    }
}
