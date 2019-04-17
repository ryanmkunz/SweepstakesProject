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

        public void ManagerFactory()
        {
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
            MakeMoreSweepstakes();            
        }

        public void MakeMoreSweepstakes()
        {
            if (UserInterface.GetMoreSweepstakes() == "yes")
            {
                SetUpSweepstakes(manager);
            }
            else
            {
                GetOneWinner();
            }
        }
        public void GetOneWinner()
        {            
            Contestant winner = manager.GetSweepstakes().PickWinner();
            UserInterface.DisplayWinnerMessage();
            sweepstakes.PrintContestantInfo(winner);
            if (UserInterface.GetMoreWinners() == "yes")
            {
                UserInterface.DisplayOkThenWinners();
                GetOneWinner();
            }
            else
            {
                UserInterface.DisplayOkThenMoreSweepstakes();
                MakeMoreSweepstakes();
            }
        }
    }
}