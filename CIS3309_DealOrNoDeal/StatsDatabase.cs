using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

namespace CIS3309_DealOrNoDeal
{
    class StatsDatabase
    {
        OleDbConnection theConnection;
        OleDbDataAdapter theDataAdapter;
        DataSet theDataSet;
        DataTable theDataTable;
        DataRow record;
        string strSQL;
        PlayerStats ps;

        public void GetStatistics()
        {
            theConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=PlayerStats.accdb;");
            theDataAdapter = new OleDbDataAdapter(strSQL, theConnection);
        }

        public int Add()
        {
            return Update();
        }

        public int Update()
        {
            OleDbCommandBuilder theBuilder = new OleDbCommandBuilder(theDataAdapter);
            return theDataAdapter.Update(theDataSet);
        }


    }
}
