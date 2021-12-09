using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3309_DealOrNoDeal
{
    public partial class PlayerStats : Form
    {
        public PlayerStats()
        {
            InitializeComponent();
            StatsDatabase db = new StatsDatabase();
            db.LoadStatistics();
            dgvPlayerStats.DataSource = db.TheDataTable;
        }
    }
}
