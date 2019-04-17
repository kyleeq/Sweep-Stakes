using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {

        // member methods
        public static void InitialStatement()
        {
            Console.WriteLine("To start, we're gonna need to information to enter you into our Sweepstakes! Please enter in the following information.");
        }
        public static string FirstNamePrompt()
        {
            Console.WriteLine("First name:");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string LastNamePrompt()
        {
            Console.WriteLine("Last name: ");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string EmailAddress()
        {
            Console.WriteLine("Email Address: ");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }
        public static int RegistrationNumber()
        {
            Console.WriteLine("Registration Number: ");
            int registrationNumber = Convert.ToInt32(Console.ReadLine());
            return registrationNumber;
        }

    }
}
