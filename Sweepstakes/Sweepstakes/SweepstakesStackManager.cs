using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> theStack;

        public Sweepstakes GetSweepstakes()
        {
            //get sweepstakes from top of stack
            return theStack.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            //add sweepstakes to top of stack
            theStack.Push(sweepstakes);
        }
    }
}