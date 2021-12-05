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
    public class PlayerTests
    {
        [TestMethod()]
        public void PlayerTest()
        {
            Player player1 = new Player(1, "Kevin", "Smith", "01/01/2001", "1234 4th St");
            Player player2 = new Player(2, "John", "Johnson", "02/02/2002", "1235 5th St");
            Assert.IsNotNull(player1);
            Assert.IsNotNull(player2);
            Assert.AreNotEqual(player1, player2);
            Assert.IsNotNull(player1.ID);
            Assert.IsNotNull(player1.FirstName);
            Assert.IsNotNull(player1.LastName);
            Assert.IsNotNull(player1.Address);
            Assert.IsNotNull(player1.DateOfBirth);
            Assert.IsNotNull(player2.ID);
            Assert.IsNotNull(player2.FirstName);
            Assert.IsNotNull(player2.LastName);
            Assert.IsNotNull(player2.Address);
            Assert.IsNotNull(player2.DateOfBirth);

        }
    }
}