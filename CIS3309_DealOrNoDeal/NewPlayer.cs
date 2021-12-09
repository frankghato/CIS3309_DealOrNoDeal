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
    public partial class NewPlayer : Form
    {
        StatsDatabase database = new StatsDatabase();
        public NewPlayer()
        {
            InitializeComponent();
            dtpBirthdate.CustomFormat = "M/d/yyyy";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string date = dtpBirthdate.Value.ToString();
            date = date.Substring(0, date.IndexOf(' '));
            Player player = new Player(txtFirstName.Text, txtLastName.Text, date, txtAddress.Text);
            MessageBox.Show("Your registration was successful. Your PlayerID is " + database.RegisterPlayer(player));
            this.Close();
        }
    }
}
