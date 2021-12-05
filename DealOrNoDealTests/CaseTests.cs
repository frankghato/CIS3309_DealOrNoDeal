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
    public class CaseTests
    {
        [TestMethod()]
        public void CaseTest()
        {
            Case case1 = new Case(1,100);
            Assert.IsNotNull(case1);
            Assert.AreEqual(1, case1.ID);
            Assert.AreEqual(100, case1.Value);

            Case case2 = case1;
            Assert.AreEqual(case1, case2);
            case2 = new Case(2, 200);
            Assert.AreNotEqual(case1, case2);
            Assert.AreEqual(2, case2.ID);
            Assert.AreEqual(200, case2.Value);
        }
    }
}