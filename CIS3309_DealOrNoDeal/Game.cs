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
        bool isPlayerCaseChosen = false;
        DealOrNoDealGame game;
        double offer;
        public Game()
        {
            InitializeComponent();
            lblInstructions.Text = "Click on a case to choose your case.";
            foreach(Button btn in this.Controls.OfType<Button>())
            {
                btn.Click += Case_Click;
            }
            lblOffer.Visible = false;
            lblOfferText.Visible = false;
            lblOfferPrompt.Visible = false;
            btnAcceptOffer.Visible = false;
            btnDeclineOffer.Visible = false;
            btnAcceptOffer.Click -= Case_Click;
            btnDeclineOffer.Click -= Case_Click;
        }

        private void Case_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(!isPlayerCaseChosen)
            {
                game = new DealOrNoDealGame(int.Parse(btn.Text), new Player());
                //MessageBox.Show("case chosen");
                isPlayerCaseChosen = true;
                lblInstructions.Text = "Click on a case to reveal the value inside.";
            }
            else
            {
                double caseValue = game.OpenCase(int.Parse(btn.Text));
                //MessageBox.Show(caseValue.ToString());
                foreach(Label lbl in this.Controls.OfType<Label>())
                {
                    double parsedLabel;
                    double.TryParse(lbl.Text, out parsedLabel);
                    if (parsedLabel == caseValue)
                    {
                        lbl.ForeColor = Color.Red;
                    }
                }
            }
            this.Controls.Remove(btn);
            offer = game.PresentOffer();
            if(offer != -1)
            {
                OfferWasPresented();
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
        }

        private void OfferWasPresented()
        {
            lblOffer.Visible = true;
            lblOffer.Text = "$" + Math.Round(offer, 2).ToString();
            lblOfferText.Visible = true;
            lblOfferPrompt.Visible = true;
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Visible = false;
            }
            btnAcceptOffer.Visible = true;
            btnDeclineOffer.Visible = true;
        }

        private void btnDeclineOffer_Click(object sender, EventArgs e)
        {
            lblOffer.Visible = false;
            lblOfferText.Visible = false;
            lblOfferPrompt.Visible = false;
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Visible = true;
            }
            btnAcceptOffer.Visible = false;
            btnDeclineOffer.Visible = false;
        }
    }
}
