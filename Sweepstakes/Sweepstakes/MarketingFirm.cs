using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public Sweepstakes sweepstakes;
        private string managementOption;

        //As a developer, I want to implement dependency injection in my MarketingFirm class 
        //so that I can utilize a sweepstakes manager.
        //As a developer, I want to use the factory design pattern to allow a user to choose 
        //between a SweepstakesStackManager or a SweepstakesQueueManager to manage the sweepstakes objects

        //get a sweepstakes name
        //choose stack or queue
        //enter contestants
        //get a winner
        //print contestant info

            public void SetUpSweepstakes ()
        {
            //sweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
            managementOption = UserInterface.GetStackOrQueueSelection();
            switch (managementOption)
            {
                case "stack":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();                    
                    break;
                case "queue":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    break;
                default:
                    break;
            }


        }


    }
}