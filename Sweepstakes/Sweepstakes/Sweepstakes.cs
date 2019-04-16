using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class Sweepstakes : ISweepstakesManager
    {
        public Contestant Contestant;

        public Sweepstakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public string PickWinner()
        {
            
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}