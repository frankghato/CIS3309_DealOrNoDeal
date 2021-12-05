using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_DealOrNoDeal
{
    public class DealOrNoDealGame
    {
        private int numCasesOpened = 1;
        private double[] caseValues = { 0.01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
        private int round = 0;
        private List<Case> unopenedCases = new List<Case>();
        private Player player = new Player();
        private Case playerCase;
        Random rand = new Random();

        public DealOrNoDealGame(int idOfPlayerCase)
        {
            ShuffleCases();
            AddCasesToList();
            playerCase = unopenedCases[idOfPlayerCase - 1];
        }

        //using the Fisher-Yates shuffle to shuffle the case values 
        private void ShuffleCases()
        {
            int n = caseValues.Length;
            while (n > 1)
            {
                int k = rand.Next(n--);
                double temp = caseValues[n];
                caseValues[n] = caseValues[k];
                caseValues[k] = temp;
            }
        }

        //populating a list with the indexes of each case
        private void AddCasesToList()
        {
            for(int i = 0; i < caseValues.Length; i++)
            {
                unopenedCases.Add(new Case(i, caseValues[i]));
            }
        }

        //removes the case that the player selected and increments the counter for cases opened
        //if the maximum number of cases per round is opened, present an offer to the player
        //else return -1 to indicate the round is not over 
        private double OpenCase(int idOfCase)
        {
            for(int i = 0; i < unopenedCases.Count; i++)
            {
                if(unopenedCases[i].ID == idOfCase)
                {
                    unopenedCases.Remove(unopenedCases[i]);
                }
            }
            numCasesOpened++;

            if(ShouldOfferBePresented())
            {
                return Banker.CalculateBankerOffer(unopenedCases);
            }

            else
            {
                return -1;
            }
        }
        
        //determines if an offer should be presented to the player based on the first round and number of cases opened
        //in the first round a player may open 6 cases
        //in the second round a player may open 5 cases
        //it follows the pattern until the 6th to 9th rounds, where a player opens 1 case per round until the 10th round
        //where the player will open two cases
        private bool ShouldOfferBePresented()
        {
            if (round >= 6 && round <= 9)
            {
                if (numCasesOpened == 1)
                {
                    return true;
                }
            }

            else if (round == 10)
            {
                if (numCasesOpened == 2)
                {
                    return true;
                }
            }

            else if (numCasesOpened == 6 - round + 1)
            {
                return true;
            }

            return false;
        }

    }
}
