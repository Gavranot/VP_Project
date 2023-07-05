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
            this.lbTimer = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.lbCountDown = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbPauseGame = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbRaceTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(323, 497);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(306, 39);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "Current time: 00:00";
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
            this.lbCountDown.Location = new System.Drawing.Point(223, 351);
            this.lbCountDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(358, 76);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 767);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(822, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbPauseGame
            // 
            this.lbPauseGame.Name = "lbPauseGame";
            this.lbPauseGame.Size = new System.Drawing.Size(40, 20);
            this.lbPauseGame.Text = "Stop";
            this.lbPauseGame.Click += new System.EventHandler(this.lbPauseGame_Click);
            // 
            // tbRaceTime
            // 
            this.tbRaceTime.Name = "tbRaceTime";
            this.tbRaceTime.Size = new System.Drawing.Size(44, 20);
            this.tbRaceTime.Text = "00:00";
            // 
            // raceTimer
            // 
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // GameSceneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::VP_Proektna.Properties.Resources.raceTrack;
            this.ClientSize = new System.Drawing.Size(822, 793);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbCountDown);
            this.Controls.Add(this.lbTimer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameSceneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSceneForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameSceneForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameSceneForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbPauseGame;
        private System.Windows.Forms.ToolStripStatusLabel tbRaceTime;
        private System.Windows.Forms.Timer raceTimer;
    }
}

