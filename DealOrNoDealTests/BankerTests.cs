using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS3309_DealOrNoDeal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_DealOrNoDeal.Tests
{
    [TestClass()]
    public class BankerTests
    {
        [TestMethod()]
        public void CalculateBankerOfferTest()
        {
            List<Case> unopenedCases = new List<Case>();
            unopenedCases.Add(new Case(1, 1));
            unopenedCases.Add(new Case(2, 2));
            unopenedCases.Add(new Case(3, 3));
            double firstOffer = Banker.CalculateBankerOffer(unopenedCases);
            unopenedCases.Add(new Case(4, 4));
            double secondOffer = Banker.CalculateBankerOffer(unopenedCases);
            Assert.AreNotEqual(firstOffer, secondOffer);
            unopenedCases.Add(new Case(4, 5));
            double thirdOffer = Banker.CalculateBankerOffer(unopenedCases);
            Assert.AreNotEqual(firstOffer, thirdOffer);
            Assert.AreNotEqual(secondOffer, thirdOffer);
        }

        [TestMethod()]
        public void CalculateMeanOfUnopenedCasesTest()
        {
            List<Case> unopenedCases = new List<Case>();
            unopenedCases.Add(new Case(1, 1));
            unopenedCases.Add(new Case(2, 2));
            unopenedCases.Add(new Case(3, 3));
            double mean = (1 + 2 + 3) / 3;
            Assert.AreEqual(mean, Banker.CalculateMeanOfUnopenedCases(unopenedCases));
            unopenedCases.Add(new Case(4, 4));
            mean = (double)(1 + 2 + 3 + 4) / 4;
            Assert.AreEqual(mean, Banker.CalculateMeanOfUnopenedCases(unopenedCases));
        }

        [TestMethod()]
        public void GetLargestRemainingCaseValueTest()
        {
            List<Case> unopenedCases = new List<Case>();
            unopenedCases.Add(new Case(1, 1));
            unopenedCases.Add(new Case(2, 2));
            unopenedCases.Add(new Case(3, 3));
            Assert.AreEqual(3, Banker.GetLargestRemainingCaseValue(unopenedCases));
            unopenedCases.Add(new Case(4, 4));
            Assert.AreEqual(4, Banker.GetLargestRemainingCaseValue(unopenedCases));
            unopenedCases.Remove(unopenedCases.ElementAt(unopenedCases.Count-1));
            Assert.AreEqual(3, Banker.GetLargestRemainingCaseValue(unopenedCases));
        }
    }
}