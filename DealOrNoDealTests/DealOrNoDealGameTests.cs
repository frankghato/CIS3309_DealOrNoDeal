using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CIS3309_DealOrNoDeal;
using System.Collections.Generic;

namespace DealOrNoDealTests
{
    [TestClass]
    public class DealOrNoDealGameTests
    {

        Random rand = new Random();

        [TestMethod]
        public void DealOrNoDealGame()
        {
            DealOrNoDealGame game = new DealOrNoDealGame(1, new Player(1,"","","",""));
            Assert.IsNotNull(game);
        }

        private void ShuffleCases(double[] caseValues)
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

        [TestMethod]
        public void ShuffleCases_Tests()
        {
            double[] caseValues = { 0.01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
            double[] arrayToShuffle = { 0.01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
            ShuffleCases(arrayToShuffle);

            int totalSameIndex = 0;
            for(int i = 0; i < caseValues.Length; i++)
            {
                if(caseValues[i] == arrayToShuffle[i])
                {
                    totalSameIndex++;
                }
            }

            Assert.IsTrue(totalSameIndex < caseValues.Length * .1);

        }

        private void AddCasesToList(double[] caseValues, List<Case> unopenedCases)
        {
            for (int i = 0; i < caseValues.Length; i++)
            {
                unopenedCases.Add(new Case(i+1, caseValues[i]));
            }
        }


        [TestMethod()]
        public void AddCasesToList_Tests()
        {
            double[] caseValues = { 0.01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
            List<Case> unopenedCases = new List<Case>();
            Assert.AreEqual(0, unopenedCases.Count);
            AddCasesToList(caseValues, unopenedCases);
            Assert.IsTrue(unopenedCases.Count > 0);
            for(int i = 0; i < caseValues.Length; i++)
            {
                Assert.AreEqual(i + 1, unopenedCases[i].ID);
                Assert.AreEqual(caseValues[i], unopenedCases[i].Value);
            }
        }

        private double OpenCase(int idOfCase, List<Case> unopenedCases)
        {
            for (int i = 0; i < unopenedCases.Count; i++)
            {
                if (unopenedCases[i].ID == idOfCase)
                {
                    unopenedCases.Remove(unopenedCases[i]);
                }
            }

            return -1;
        }

        [TestMethod()]
        public void OpenCase_Tests()
        {
            double[] caseValues = { 0.01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
            List<Case> unopenedCases = new List<Case>();
            AddCasesToList(caseValues, unopenedCases);
            Assert.AreEqual(caseValues.Length, unopenedCases.Count);
            OpenCase(1, unopenedCases);
            Assert.AreEqual(caseValues.Length - 1, unopenedCases.Count);
            for(int i = 0; i < unopenedCases.Count; i++)
            {
                Assert.AreNotEqual(1, unopenedCases[i].ID);
                Assert.AreNotEqual(caseValues[0], unopenedCases[i].Value);
            }
        }

        private bool ShouldOfferBePresented(int round, int numCasesOpened)
        {
            if (round >= 6 && round <= 9)
            {
                if (numCasesOpened == 1)
                {
                    return true;
                }
            }
            
            else if(round == 10)
            {
                if(numCasesOpened == 2)
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

        [TestMethod()]
        public void ShouldOfferBePresented_Tests()
        {
            Assert.IsFalse(ShouldOfferBePresented(6, 0));
            Assert.IsTrue(ShouldOfferBePresented(1, 6));
            Assert.IsTrue(ShouldOfferBePresented(2, 5));
            Assert.IsTrue(ShouldOfferBePresented(3, 4));
            Assert.IsTrue(ShouldOfferBePresented(4, 3));
            Assert.IsTrue(ShouldOfferBePresented(5, 2));
            Assert.IsTrue(ShouldOfferBePresented(6, 1));
            for(int i = 6; i <= 9; i++)
            {
                Assert.IsTrue(ShouldOfferBePresented(i, 1));
            }
            Assert.IsTrue(ShouldOfferBePresented(10, 2));
        }

    }
}
