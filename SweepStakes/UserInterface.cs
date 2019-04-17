﻿using System;
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
            Console.WriteLine("Hello! Let's start by entering in some Sweepstakes!");
        }
        public static string SweepstakePrompt()
        {
            Console.WriteLine("Please enter in the name of your Sweepstake.");
            string sweepstakeName = Console.ReadLine();
            return sweepstakeName;
        }
        public static void StackOrQueuePrompt()
        {
            Console.WriteLine("Please enter whether you would like to use a 'stack' or 'queue'.");
            string promptAnswer = Console.ReadLine();
            if (promptAnswer == "stack")
            {

            }
            else if (promptAnswer == "queue")
            {

            }
            else
            {
                StackOrQueuePrompt();
            }
            
        }
        public static void ContestantInformationStatement()
        {
            Console.WriteLine("To start, we're gonna need the information for the people who are entering your Sweepstake! Please enter in the following information.");
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
    }
}
