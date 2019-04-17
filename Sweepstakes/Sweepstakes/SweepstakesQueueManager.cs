﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> theQueue;
        public Sweepstakes GetSweepstakes()
        {
            return theQueue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            theQueue.Enqueue(sweepstakes);
        }
    }
}