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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinnerForm));
            this.lbWinners = new System.Windows.Forms.Label();
            this.lbStartNew = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWinners
            // 
            this.lbWinners.AutoSize = true;
            this.lbWinners.BackColor = System.Drawing.Color.Transparent;
            this.lbWinners.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinners.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbWinners.Location = new System.Drawing.Point(394, 156);
            this.lbWinners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWinners.Name = "lbWinners";
            this.lbWinners.Size = new System.Drawing.Size(106, 37);
            this.lbWinners.TabIndex = 0;
            this.lbWinners.Text = "label1";
            // 
            // lbStartNew
            // 
            this.lbStartNew.AutoSize = true;
            this.lbStartNew.BackColor = System.Drawing.Color.Transparent;
            this.lbStartNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartNew.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbStartNew.Location = new System.Drawing.Point(12, 526);
            this.lbStartNew.Name = "lbStartNew";
            this.lbStartNew.Size = new System.Drawing.Size(315, 39);
            this.lbStartNew.TabIndex = 1;
            this.lbStartNew.Text = "Започни нова игра";
            this.lbStartNew.Click += new System.EventHandler(this.lbStartNew_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbExit.Location = new System.Drawing.Point(12, 580);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(141, 39);
            this.lbExit.TabIndex = 2;
            this.lbExit.Text = "Заврши";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::VP_Proektna.Properties.Resources.winner1;
            this.ClientSize = new System.Drawing.Size(616, 644);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.lbStartNew);
            this.Controls.Add(this.lbWinners);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "WinnerForm";
            this.Text = "Race over!";
            this.Load += new System.EventHandler(this.OpponentWinnerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWinners;
        private System.Windows.Forms.Label lbStartNew;
        private System.Windows.Forms.Label lbExit;
    }
}