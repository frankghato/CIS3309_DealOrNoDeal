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
        bool isPlayerCaseChosen = false;
        DealOrNoDealGame game;
        int playerID;
        double offer;
        double winnings = 0;
        public Game(int playerID)
        {
            InitializeComponent();
            this.playerID = playerID;
            lblInstructions.Text = "Click on a case to choose your case.";
            foreach(Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Name != "btnHowToPlay")
                {
                    btn.Click += Case_Click;
                }
            }
            lblOffer.Visible = false;
            lblOfferText.Visible = false;
            lblOfferPrompt.Visible = false;
            btnAcceptOffer.Visible = false;
            btnDeclineOffer.Visible = false;
            btnAcceptOffer.Click -= Case_Click;
            btnDeclineOffer.Click -= Case_Click;
            btnYourCase.Visible = false;
            btnYourCase.Click -= Case_Click;
            lblSwapOffer.Visible = false;
            btnAcceptSwap.Visible = false;
            btnDeclineSwap.Visible = false;
            btnAcceptSwap.Click -= Case_Click;
            btnDeclineSwap.Click -= Case_Click;
        }

        private void Case_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(!isPlayerCaseChosen)
            {
                game = new DealOrNoDealGame(int.Parse(btn.Text), playerID);
                //MessageBox.Show("case chosen");
                isPlayerCaseChosen = true;
                lblInstructions.Text = "Click on a case to reveal the value inside.";
                btnYourCase.Visible = true;
                btnYourCase.Text = btn.Text;
            }
            else
            {
                double caseValue = game.OpenCase(int.Parse(btn.Text));
                MessageBox.Show(caseValue.ToString());
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
            btnYourCase.Visible = true;
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
            btnAcceptSwap.Visible = false;
            btnDeclineSwap.Visible = false;

            if(game.Round == 10)
            {
                WhenTwoCasesRemain();
            }
        }

        private void GameOver()
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Visible = false;
            }
            lblSwapOffer.Visible = false;
            lblYourCase.Visible = false;
            MessageBox.Show("Congratulations, you won: $" + Math.Round(winnings, 2).ToString() + "!" + "\n" +
            game.EndGame(winnings) + " player record updated.");
            this.Close();
        }

        private void btnAcceptOffer_Click(object sender, EventArgs e)
        {
            winnings = offer;
            GameOver();
        }

        private void WhenTwoCasesRemain()
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.Visible = false;
            }
            lblSwapOffer.Visible = true;
            btnAcceptSwap.Visible = true;
            btnDeclineSwap.Visible = true;
        }

        private void btnDeclineSwap_Click(object sender, EventArgs e)
        {
            winnings = game.ValueOfPlayerCase;
            GameOver();
        }

        private void btnAcceptSwap_Click(object sender, EventArgs e)
        {
            winnings = game.GetValueOfLastCase();
            GameOver();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            InstructionsForm form = new InstructionsForm();
            form.Show();
        }
    }
}
