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

        int registrationNumber;
        Random rand;

        // constructor
        public Contestant(string firstName, string lastName, string emailAddress)
        {
            
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
            registrationNumber = rand.Next();
            Console.WriteLine($"You're registration number is {registrationNumber}. Make sure to write it down!");
            return registrationNumber;
        }
    }
}
