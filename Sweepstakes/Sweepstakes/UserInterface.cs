using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //User story suggests getting a registration number from user input
        //but shouldn't that just be incremented with each addition?

        private static string Input;

        private static string GetUserInput(string validationType)
        {
            do
            {
                Input = Console.ReadLine();
            } while (!InputValidation(Input, validationType));
            return Input;
        }

        private static bool InputValidation(string input, string validationType)
        {
            switch (validationType)
            {
                case "yesNo":
                    if (input == "yes" || input == "no")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "string":
                    return true;
                case "stackQueue":
                    if (input == "stack" || input == "queue")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }
        }

        public static string GetSweepstakesName()
        {
            Console.WriteLine("Enter the name of the sweepstakes");
            return GetUserInput("string");
        }

        public static string GetStackOrQueueSelection()
        {      
            Console.WriteLine("Would you like your sweepstakes to be in a stack or queue?");
            return GetUserInput("stackQueue");
        }

        public static string GetFirstName()
        {
            Console.WriteLine("Enter first name");
            return GetUserInput("string");
        }

        public static string GetLastName()
        {
            Console.WriteLine("Enter last name");
            return GetUserInput("string");
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("Enter email address");
            return GetUserInput("string");
        }

        public static string GetMoreSweepstakes()
        {
            Console.WriteLine();
            return GetUserInput("yesNo");
        }
    }
}