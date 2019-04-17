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
        ISweepstakesManager manager;
        Contestant contestant;

        public void ManagerFactory ()
        {
            ticketNumber = 0;
            managementOption = UserInterface.GetStackOrQueueSelection();            
            switch (managementOption)
            {
                case "stack":
                    manager = new SweepstakesStackManager();                    
                    break;
                case "queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    break;
            }
            SetUpSweepstakes(manager);
        }

        public void SetUpSweepstakes(ISweepstakesManager manager)
        {
            sweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
            for (int i = 0; i < 3; i++)
            {
                contestant = new Contestant();
                sweepstakes.RegisterContestant(contestant);
            }
            manager.InsertSweepstakes(sweepstakes);
            

            if (UserInterface.GetMoreSweepstakes() == "yes")
            {
                ManagerFactory();
            }
            else
            {
                sweepstakes.PickWinner();
            }
        }
    }
}