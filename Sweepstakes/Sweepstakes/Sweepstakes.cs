using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Contestant Contestant;
        Dictionary<int, string> contestants;
        

        public Sweepstakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNum, ("" + contestant.FirstName + " " + contestant.LastName + " " + contestant.EmailAddress));
        }

        public string PickWinner()
        {
            
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}