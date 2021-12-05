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
    public partial class Game : Form
    {
        EventHandler ChooseCaseDelegate;
        DealOrNoDealGame game = new DealOrNoDealGame(1);
        public Game()
        {
            InitializeComponent();
            ChooseCaseDelegate = new EventHandler(ChooseCase);
            //lblInstructions.Text = game.Instructions;
            //probably a better way to do this
            btnCase1.Click += ChooseCaseDelegate;
            btnCase2.Click += ChooseCaseDelegate;
            btnCase3.Click += ChooseCaseDelegate;
            btnCase4.Click += ChooseCaseDelegate;
            btnCase5.Click += ChooseCaseDelegate;
            btnCase6.Click += ChooseCaseDelegate;
            btnCase7.Click += ChooseCaseDelegate;
            btnCase8.Click += ChooseCaseDelegate;
            btnCase9.Click += ChooseCaseDelegate;
            btnCase10.Click += ChooseCaseDelegate;
            btnCase11.Click += ChooseCaseDelegate;
            btnCase12.Click += ChooseCaseDelegate;
            btnCase13.Click += ChooseCaseDelegate;
            btnCase14.Click += ChooseCaseDelegate;
            btnCase15.Click += ChooseCaseDelegate;
            btnCase16.Click += ChooseCaseDelegate;
            btnCase17.Click += ChooseCaseDelegate;
            btnCase18.Click += ChooseCaseDelegate;
            btnCase19.Click += ChooseCaseDelegate;
            btnCase20.Click += ChooseCaseDelegate;
            btnCase21.Click += ChooseCaseDelegate;
            btnCase22.Click += ChooseCaseDelegate;
            btnCase23.Click += ChooseCaseDelegate;
            btnCase24.Click += ChooseCaseDelegate;
            btnCase25.Click += ChooseCaseDelegate;
            btnCase26.Click += ChooseCaseDelegate;
        }

        public void ChooseCase(object sender, EventArgs e)
        {
            Button theCase = (Button)sender;
            //game.SelectCase(int.Parse(theCase.Text));
            theCase.Hide();
        }

        public void DealOrNoDeal()
        {

        }
    }
}
