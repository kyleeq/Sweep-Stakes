using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class UserInterface
    {
        // member variables
        Contestant contestant = new Contestant();

        // constructor

        // member methods
        public void GetInfo()
        {
            Console.WriteLine("To start, we're gonna need to information to enter you into our Sweepstakes! Please enter in the following information.");
            Console.WriteLine("First name:");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Email Address: ");
            contestant.emailAddress = Console.ReadLine();
            Console.WriteLine("Registration Number: ");
            contestant.registrationNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
