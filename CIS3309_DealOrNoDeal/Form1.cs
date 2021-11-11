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
    public partial class Form1 : Form
    {
        DealOrNoDealGame game = new DealOrNoDealGame(1);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(game.PlayerCaseValue.ToString());
        }
    }
}
