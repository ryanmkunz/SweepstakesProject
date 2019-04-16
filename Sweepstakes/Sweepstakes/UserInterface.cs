using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public static class UserInterface
    {
        private static string Input;

        public static string GetUserInput(string validationType)
        {
            do
            {
                Input = Console.ReadLine();
            } while (!InputValidation(Input, validationType));
            return Input;
        }

        public static bool InputValidation(string input, string validationType)
        {
            switch (validationType)
            {
                case "yesNo":
                    return true;
                default:
                    return false;
            }
        }
    }
}