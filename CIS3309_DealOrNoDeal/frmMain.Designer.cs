
namespace CIS3309_DealOrNoDeal
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.updPlayerID = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.btnPlayerStats = new System.Windows.Forms.Button();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updPlayerID)).BeginInit();
            this.SuspendLayout();
            // 
            // updPlayerID
            // 
            this.updPlayerID.Location = new System.Drawing.Point(170, 309);
            this.updPlayerID.Name = "updPlayerID";
            this.updPlayerID.Size = new System.Drawing.Size(120, 20);
            this.updPlayerID.TabIndex = 13;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(170, 331);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.BackColor = System.Drawing.Color.Black;
            this.lblEnterID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterID.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblEnterID.Location = new System.Drawing.Point(126, 282);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(216, 24);
            this.lblEnterID.TabIndex = 11;
            this.lblEnterID.Text = "Enter your Player ID:";
            // 
            // btnPlayerStats
            // 
            this.btnPlayerStats.BackColor = System.Drawing.Color.Peru;
            this.btnPlayerStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayerStats.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerStats.Location = new System.Drawing.Point(240, 401);
            this.btnPlayerStats.Name = "btnPlayerStats";
            this.btnPlayerStats.Size = new System.Drawing.Size(120, 23);
            this.btnPlayerStats.TabIndex = 10;
            this.btnPlayerStats.Text = "Player Stats";
            this.btnPlayerStats.UseVisualStyleBackColor = false;
            this.btnPlayerStats.Click += new System.EventHandler(this.btnPlayerStats_Click);
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.BackColor = System.Drawing.Color.Peru;
            this.btnNewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPlayer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.Location = new System.Drawing.Point(101, 401);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(120, 23);
            this.btnNewPlayer.TabIndex = 9;
            this.btnNewPlayer.Text = "New Player";
            this.btnNewPlayer.UseVisualStyleBackColor = false;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.updPlayerID);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEnterID);
            this.Controls.Add(this.btnPlayerStats);
            this.Controls.Add(this.btnNewPlayer);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.updPlayerID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown updPlayerID;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.Button btnPlayerStats;
        private System.Windows.Forms.Button btnNewPlayer;
    }
}