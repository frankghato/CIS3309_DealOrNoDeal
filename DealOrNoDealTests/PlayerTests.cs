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
            Player player1 = new Player();
            Player player2 = new Player(1, 100000, 90000, 5, 0);
            Player player3 = new Player("John", "Johnson", "02/02/2002", "1235 5th St");

            Assert.IsNotNull(player1);
            Assert.IsNotNull(player2);
            Assert.IsNotNull(player3);
            Assert.AreNotEqual(player1, player2);
            Assert.AreNotEqual(player2, player3);
            Assert.AreNotEqual(player1, player3);

            Assert.AreEqual(0, player1.ID);
            Assert.IsNull(player1.FirstName);
            Assert.IsNull(player1.LastName);
            Assert.IsNull(player1.Address);
            Assert.IsNull(player1.DateOfBirth);
            Assert.AreEqual(0, player1.LowestWinnings);
            Assert.AreEqual(0, player1.GamesPlayed);
            Assert.AreEqual(0, player1.MillionsWon);

            Assert.AreEqual(1, player2.ID);
            Assert.IsNull(player2.FirstName);
            Assert.IsNull(player2.LastName);
            Assert.IsNull(player2.Address);
            Assert.IsNull(player2.DateOfBirth);
            Assert.AreEqual(100000, player2.HighestWinnings);
            Assert.AreEqual(90000, player2.LowestWinnings);
            Assert.AreEqual(5, player2.GamesPlayed);
            Assert.AreEqual(0, player2.MillionsWon);

            Assert.AreEqual(0, player3.ID);
            Assert.AreEqual("John", player3.FirstName);
            Assert.AreEqual("Johnson", player3.LastName);
            Assert.AreEqual("02/02/2002", player3.DateOfBirth);
            Assert.AreEqual("1235 5th St", player3.Address);
            Assert.AreEqual(0, player3.HighestWinnings);
            Assert.AreEqual(0, player3.LowestWinnings);
            Assert.AreEqual(0,player3.GamesPlayed);
            Assert.AreEqual(0, player3.MillionsWon);
        }
    }
}