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
    public partial class frmMain : Form
    {
        StatsDatabase database = new StatsDatabase();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int playerID = Decimal.ToInt32(updPlayerID.Value);
            Player player = database.ValidatePlayer(playerID);
            if (player != null)
            {
                MessageBox.Show("Welcome!");
                Game form = new Game(playerID);
                form.Show();
            } else
            {
                MessageBox.Show("This player does not exist");
            }
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            NewPlayer form = new NewPlayer();
            form.Show();
        }

        private void btnPlayerStats_Click(object sender, EventArgs e)
        {
            PlayerStats form = new PlayerStats();
            form.Show();
        }
    }
}
