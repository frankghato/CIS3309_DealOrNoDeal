
namespace CIS3309_DealOrNoDeal
{
    partial class PlayerStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerStats));
            this.dgvPlayerStats = new System.Windows.Forms.DataGridView();
            this.lblPlayerStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayerStats
            // 
            this.dgvPlayerStats.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayerStats.Location = new System.Drawing.Point(12, 62);
            this.dgvPlayerStats.Name = "dgvPlayerStats";
            this.dgvPlayerStats.Size = new System.Drawing.Size(902, 360);
            this.dgvPlayerStats.TabIndex = 1;
            // 
            // lblPlayerStats
            // 
            this.lblPlayerStats.AutoSize = true;
            this.lblPlayerStats.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerStats.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerStats.Location = new System.Drawing.Point(338, 25);
            this.lblPlayerStats.Name = "lblPlayerStats";
            this.lblPlayerStats.Size = new System.Drawing.Size(238, 34);
            this.lblPlayerStats.TabIndex = 20;
            this.lblPlayerStats.Text = "Player Statistics";
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.lblPlayerStats);
            this.Controls.Add(this.dgvPlayerStats);
            this.Name = "PlayerStats";
            this.Text = "PlayerStats";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayerStats;
        private System.Windows.Forms.Label lblPlayerStats;
    }
}