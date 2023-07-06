namespace VP_Proektna
{
    partial class GameSceneForm
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
            this.components = new System.ComponentModel.Container();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.lbCountDown = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbPauseGame = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbRaceTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            this.lbSave = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.ForeColor = System.Drawing.Color.Red;
            this.lbCountDown.Location = new System.Drawing.Point(167, 285);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(289, 63);
            this.lbCountDown.TabIndex = 5;
            this.lbCountDown.Text = "RACE IN 3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbPauseGame,
            this.tbRaceTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbPauseGame
            // 
            this.lbPauseGame.Name = "lbPauseGame";
            this.lbPauseGame.Size = new System.Drawing.Size(31, 17);
            this.lbPauseGame.Text = "Stop";
            this.lbPauseGame.Click += new System.EventHandler(this.lbPauseGame_Click);
            // 
            // tbRaceTime
            // 
            this.tbRaceTime.Name = "tbRaceTime";
            this.tbRaceTime.Size = new System.Drawing.Size(34, 17);
            this.tbRaceTime.Text = "00:00";
            // 
            // raceTimer
            // 
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSave.Location = new System.Drawing.Point(23, 631);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(87, 13);
            this.lbSave.TabIndex = 7;
            this.lbSave.Text = "Save your game!";
            this.lbSave.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameSceneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::VP_Proektna.Properties.Resources.raceTrack;
            this.ClientSize = new System.Drawing.Size(616, 644);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbCountDown);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameSceneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSceneForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameSceneForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameSceneForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameSceneForm_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbPauseGame;
        private System.Windows.Forms.ToolStripStatusLabel tbRaceTime;
        private System.Windows.Forms.Timer raceTimer;
        private System.Windows.Forms.Label lbSave;
    }
}

