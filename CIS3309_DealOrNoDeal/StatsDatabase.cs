using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

namespace CIS3309_DealOrNoDeal
{
    public class StatsDatabase
    {
        OleDbConnection theConnection;
        OleDbDataAdapter theDataAdapter;
        DataSet theDataSet;
        DataTable theDataTable;
        DataRow record;
        Player player;

        public StatsDatabase()
        {

        }

        public DataTable TheDataTable
        {
            get
            {
                return theDataTable;
            }
        }

        public void LoadStatistics()
        {
            theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=PlayerStats.accdb;");
            theDataAdapter = new OleDbDataAdapter("SELECT * FROM PlayerStats", theConnection);
            theDataSet = new DataSet();
            theDataAdapter.Fill(theDataSet);
            theDataTable = theDataSet.Tables[0];
        }

        public Player ValidatePlayer(int id)
        {
            LoadStatistics();
            foreach (DataRow row in theDataTable.Rows)
            {
                if (row["PlayerID"].ToString() == id.ToString())
                {
                    player = new Player(int.Parse(row["PlayerID"].ToString()), Decimal.Parse(row["HighestEarnings"].ToString()),
                        Decimal.Parse(row["LowestEarnings"].ToString()), int.Parse(row["GamesPlayed"].ToString()), int.Parse(row["MillionsWon"].ToString()));
                    return player;
                }
            }
            return player;
        }

        public int RegisterPlayer(Player player)
        {
            LoadStatistics();
            record = theDataTable.NewRow();
            record["FirstName"] = player.FirstName;
            record["LastName"] = player.LastName;
            record["DateOfBirth"] = player.DateOfBirth;
            record["Address"] = player.Address;
            record["HighestEarnings"] = player.HighestWinnings;
            record["LowestEarnings"] = player.LowestWinnings;
            record["GamesPlayed"] = player.GamesPlayed;
            record["MillionsWon"] = player.MillionsWon;
            theDataTable.Rows.Add(record);
            Update();
            return theDataTable.Rows.Count;
        }

        public int UpdatePlayer(Player player)
        {
            LoadStatistics();
            foreach (DataRow row in theDataTable.Rows)
            {
                if (row["PlayerID"].ToString() == player.ID.ToString())
                {
                    record = row;
                }
            }
            record["HighestEarnings"] = player.HighestWinnings;
            record["LowestEarnings"] = player.LowestWinnings;
            record["GamesPlayed"] = player.GamesPlayed;
            record["MillionsWon"] = player.MillionsWon;
            return Update();
        }

        public int Update()
        {
            OleDbCommandBuilder theBuilder = new OleDbCommandBuilder(theDataAdapter);
            return theDataAdapter.Update(theDataSet);
        }
    }
}
