using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS3309_DealOrNoDeal;
using System;
using System.Data;
//using System.Data.OleDb;

namespace DealOrNoDealTests
{
    [TestClass]
    public class StatsDatabaseTests
    {
        StatsDatabase db;
        Player p1;
        Player p2;
        Player p3;

        [TestMethod]
        public void StatsDatabaseConstructorTest()
        {
            db = new StatsDatabase();
            Assert.IsTrue(db is StatsDatabase);
        }

        //[TestMethod]
        //public void LoadStatisticsTest()
        //{
        //    db = new StatsDatabase();
        //    db.LoadStatistics();
        //    Assert.IsNotNull(db.TheDataTable);
        //}

        [TestMethod]
        public void ValidatePlayerTest()
        {
            db = new StatsDatabase();
            p1 = new Player(1, 100000, 90000, 5, 0);
            db.RegisterPlayer(p1);
            Assert.AreEqual(p1.ID, db.ValidatePlayer(1).ID);

            p2 = new Player(2, 5435435, 8900, 2, 1);
            db.RegisterPlayer(p2);
            Assert.AreEqual(p2.ID, db.ValidatePlayer(2).ID);

            p3 = new Player(3, 88483945, 600, 3, 12);
            db.RegisterPlayer(p3);
            Assert.AreEqual(p3.ID, db.ValidatePlayer(3).ID);
        }


        [TestMethod]
        public void RegisterPlayerTest()
        {
            db = new StatsDatabase();
            p1 = new Player("Timmy", "Turner", "12/06/2011", "123 Dimmsdale St");
            Assert.AreEqual(4, db.RegisterPlayer(p1));
            p2 = new Player("Spongebob", "Squarepants", "12/06/1988", "321 Bikini Bottom Ave");
            Assert.AreEqual(5, db.RegisterPlayer(p2));
        }


        [TestMethod]
        public void UpdatePlayerTest()
        {
            db = new StatsDatabase();
            p1 = new Player(1, 100000, 90000, 5, 0);
            Assert.AreEqual(6, db.RegisterPlayer(p1));
            p1.GamesPlayed += 1;
            Assert.AreEqual(1, db.UpdatePlayer(p1));

            p2 = new Player(2, 5435435, 8900, 2, 1);
            p2.MillionsWon += 1;
            Assert.AreEqual(7, db.RegisterPlayer(p2));
            Assert.AreEqual(1, db.UpdatePlayer(p2));
        }


        //[TestMethod]
        //public void UpdateTest()
        //{
        //    db = new StatsDatabase();


        //}

    }
}
