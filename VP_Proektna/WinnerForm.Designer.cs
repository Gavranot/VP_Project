namespace VP_Proektna
{
    partial class WinnerForm
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
            this.lbWinners = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWinners
            // 
            this.lbWinners.AutoSize = true;
            this.lbWinners.BackColor = System.Drawing.Color.Transparent;
            this.lbWinners.Font = new System.Drawing.Font("Snap ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinners.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbWinners.Location = new System.Drawing.Point(525, 192);
            this.lbWinners.Name = "lbWinners";
            this.lbWinners.Size = new System.Drawing.Size(153, 51);
            this.lbWinners.TabIndex = 0;
            this.lbWinners.Text = "label1";
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::VP_Proektna.Properties.Resources.winner1;
            this.ClientSize = new System.Drawing.Size(822, 793);
            this.Controls.Add(this.lbWinners);
            this.MaximizeBox = false;
            this.Name = "WinnerForm";
            this.Text = "OpponentWinnerForm";
            this.Load += new System.EventHandler(this.OpponentWinnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWinners;
    }
}