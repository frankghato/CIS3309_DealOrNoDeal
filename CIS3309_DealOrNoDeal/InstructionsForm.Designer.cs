
namespace CIS3309_DealOrNoDeal
{
    partial class InstructionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHowToPlayTitle = new System.Windows.Forms.Label();
            this.lblHowToPlayLine1 = new System.Windows.Forms.Label();
            this.lblHowToPlayLine2 = new System.Windows.Forms.Label();
            this.lblHowToPlayLine3 = new System.Windows.Forms.Label();
            this.lblHowToPlayLine4 = new System.Windows.Forms.Label();
            this.lblHowToPlayLine5 = new System.Windows.Forms.Label();
            this.lblHowToPlayLine6 = new System.Windows.Forms.Label();
            this.lblHowToPlayLine7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHowToPlayTitle
            // 
            this.lblHowToPlayTitle.AutoSize = true;
            this.lblHowToPlayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlayTitle.Location = new System.Drawing.Point(292, 9);
            this.lblHowToPlayTitle.Name = "lblHowToPlayTitle";
            this.lblHowToPlayTitle.Size = new System.Drawing.Size(164, 31);
            this.lblHowToPlayTitle.TabIndex = 0;
            this.lblHowToPlayTitle.Text = "How to play:";
            // 
            // lblHowToPlayLine1
            // 
            this.lblHowToPlayLine1.AutoSize = true;
            this.lblHowToPlayLine1.Location = new System.Drawing.Point(12, 50);
            this.lblHowToPlayLine1.Name = "lblHowToPlayLine1";
            this.lblHowToPlayLine1.Size = new System.Drawing.Size(584, 13);
            this.lblHowToPlayLine1.TabIndex = 1;
            this.lblHowToPlayLine1.Text = "Each briefcase holds a dollar amount inside. At the beginning of the game the pla" +
    "yer chooses a briefcase to claim as theirs.";
            // 
            // lblHowToPlayLine2
            // 
            this.lblHowToPlayLine2.AutoSize = true;
            this.lblHowToPlayLine2.Location = new System.Drawing.Point(12, 75);
            this.lblHowToPlayLine2.Name = "lblHowToPlayLine2";
            this.lblHowToPlayLine2.Size = new System.Drawing.Size(532, 13);
            this.lblHowToPlayLine2.TabIndex = 2;
            this.lblHowToPlayLine2.Text = "Each round the player will choose a number a number of briefcases to open and rev" +
    "eal the dollar amount inside.";
            // 
            // lblHowToPlayLine3
            // 
            this.lblHowToPlayLine3.AutoSize = true;
            this.lblHowToPlayLine3.Location = new System.Drawing.Point(12, 97);
            this.lblHowToPlayLine3.Name = "lblHowToPlayLine3";
            this.lblHowToPlayLine3.Size = new System.Drawing.Size(570, 13);
            this.lblHowToPlayLine3.TabIndex = 3;
            this.lblHowToPlayLine3.Text = "At the end of each round the player will receive an offer for the case that they " +
    "own based on the remaining case values.";
            // 
            // lblHowToPlayLine4
            // 
            this.lblHowToPlayLine4.AutoSize = true;
            this.lblHowToPlayLine4.Location = new System.Drawing.Point(12, 121);
            this.lblHowToPlayLine4.Name = "lblHowToPlayLine4";
            this.lblHowToPlayLine4.Size = new System.Drawing.Size(429, 13);
            this.lblHowToPlayLine4.TabIndex = 4;
            this.lblHowToPlayLine4.Text = "The player can accept the offer and end the game, or choose to continue opening c" +
    "ases.";
            // 
            // lblHowToPlayLine5
            // 
            this.lblHowToPlayLine5.AutoSize = true;
            this.lblHowToPlayLine5.Location = new System.Drawing.Point(12, 145);
            this.lblHowToPlayLine5.Name = "lblHowToPlayLine5";
            this.lblHowToPlayLine5.Size = new System.Drawing.Size(296, 13);
            this.lblHowToPlayLine5.TabIndex = 5;
            this.lblHowToPlayLine5.Text = "As rounds progress, the player will open less cases per round.";
            // 
            // lblHowToPlayLine6
            // 
            this.lblHowToPlayLine6.AutoSize = true;
            this.lblHowToPlayLine6.Location = new System.Drawing.Point(12, 167);
            this.lblHowToPlayLine6.Name = "lblHowToPlayLine6";
            this.lblHowToPlayLine6.Size = new System.Drawing.Size(557, 13);
            this.lblHowToPlayLine6.TabIndex = 6;
            this.lblHowToPlayLine6.Text = "The game ends when one case remains. The player is given the option to keep their" +
    " case or swap with the last case.";
            // 
            // lblHowToPlayLine7
            // 
            this.lblHowToPlayLine7.AutoSize = true;
            this.lblHowToPlayLine7.Location = new System.Drawing.Point(12, 192);
            this.lblHowToPlayLine7.Name = "lblHowToPlayLine7";
            this.lblHowToPlayLine7.Size = new System.Drawing.Size(488, 13);
            this.lblHowToPlayLine7.TabIndex = 7;
            this.lblHowToPlayLine7.Text = "The player wins whatever amount of money is inside of the case that they own at t" +
    "he end of the game.";
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHowToPlayLine7);
            this.Controls.Add(this.lblHowToPlayLine6);
            this.Controls.Add(this.lblHowToPlayLine5);
            this.Controls.Add(this.lblHowToPlayLine4);
            this.Controls.Add(this.lblHowToPlayLine3);
            this.Controls.Add(this.lblHowToPlayLine2);
            this.Controls.Add(this.lblHowToPlayLine1);
            this.Controls.Add(this.lblHowToPlayTitle);
            this.Name = "InstructionsForm";
            this.Text = "How to Play";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHowToPlayTitle;
        private System.Windows.Forms.Label lblHowToPlayLine1;
        private System.Windows.Forms.Label lblHowToPlayLine2;
        private System.Windows.Forms.Label lblHowToPlayLine3;
        private System.Windows.Forms.Label lblHowToPlayLine4;
        private System.Windows.Forms.Label lblHowToPlayLine5;
        private System.Windows.Forms.Label lblHowToPlayLine6;
        private System.Windows.Forms.Label lblHowToPlayLine7;
    }
}