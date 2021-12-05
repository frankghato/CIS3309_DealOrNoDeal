using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_DealOrNoDeal
{
    public class Banker
    {
        //calculating the mean of the values inside all unopened cases
        public static double CalculateMeanOfUnopenedCases(List<Case> unopenedCases)
        {
            double sum = 0;
            for (int i = 0; i < unopenedCases.Count; i++)
            {
                sum += unopenedCases[i].Value;
            }
            return sum / unopenedCases.Count;
        }

        //finding the largest value inside all unopened cases
        public static double GetLargestRemainingCaseValue(List<Case> unopenedCases)
        {
            double largest = unopenedCases[0].Value;
            for (int i = 1; i < unopenedCases.Count; i++)
            {
                if (unopenedCases[i].Value > largest)
                {
                    largest = unopenedCases[i].Value;
                }
            }
            return largest;
        }

        //formula used on the game show, created by Samuel Bradley
        //source: http://commcognition.blogspot.com/2007/06/deal-or-no-deal-bankers-formula.html
        public static double CalculateBankerOffer(List<Case> unopenedCases)
        {
            double mean = CalculateMeanOfUnopenedCases(unopenedCases);
            int casesLeft = unopenedCases.Count;
            return 12275.30 + (7.48 * mean) + (-2714.74 * casesLeft)
                   + (-.04 * GetLargestRemainingCaseValue(unopenedCases))
                   + (.0000006986 * mean * mean)
                   + (32.623 * casesLeft * casesLeft);
        }

    }
}
