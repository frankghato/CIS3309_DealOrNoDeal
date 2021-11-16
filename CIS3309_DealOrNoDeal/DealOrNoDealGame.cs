using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_DealOrNoDeal
{
    class DealOrNoDealGame
    {
        private int numCasesOpened = 0;
        private double[] caseValues = { 0.01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
        private List<Case> unopenedCases = new List<Case>();
        private Player player = new Player();
        Random rand = new Random();

        public DealOrNoDealGame(int IndexOfPlayerCase)
        {
            ShuffleCaseValues();
            AddCasesToList();
            playerCaseValue = unopenedCases[IndexOfPlayerCase];
        }

        public double PlayerCaseValue
        {
           get{return this.playerCaseValue;}
        }

        //using the Fisher-Yates shuffle to shuffle the case values 
        private void ShuffleCaseValues()
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

        //the caseValues array contains all of the values inside cases
        //the unopenedCases list contains the index of all cases that have yet to be opened
        //when a case is selected to be opened, remove its index from the unopened cases list and return the value inside the case
        public double OpenCase(int caseIndex)
        {
            caseIndex--;
            unopenedCases.Remove(caseIndex);
            return caseValues[caseIndex];
        }

        //calculating the mean of the values inside all unopened cases
        private double CalculateMeanOfUnopenedCases()
        {
            double sum = 0;
            for(int i = 0; i < unopenedCases.Count; i++)
            {
                sum += caseValues[unopenedCases[i]];
            }
            return sum / unopenedCases.Count;
        }

        //finding the largest value inside all unopened cases
        private double GetLargestRemainingCaseValue()
        {
            double largest = caseValues[unopenedCases[0]];
            for (int i = 1; i < unopenedCases.Count; i++)
            {
                if(caseValues[unopenedCases[i]] > largest)
                {
                    largest = caseValues[unopenedCases[i]];
                }
            }
            return largest;
        }

        //formula used on the game show, created by Samuel Bradley
        //source: http://commcognition.blogspot.com/2007/06/deal-or-no-deal-bankers-formula.html
        public double CalculateBankerOffer()
        {
            double mean = CalculateMeanOfUnopenedCases();
            int casesLeft = unopenedCases.Count;
            return 12275.30 + (7.48 * mean) + (-2714.74 * casesLeft) 
                   + (-.04 * GetLargestRemainingCaseValue())
                   + (.0000006986 * mean * mean)
                   + (32.623 * casesLeft * casesLeft);
        }
    }
}
