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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarMove = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.ForeColor = System.Drawing.Color.Transparent;
            this.lbCountDown.Location = new System.Drawing.Point(167, 289);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(289, 63);
            this.lbCountDown.TabIndex = 5;
            this.lbCountDown.Text = "RACE IN 3";
            this.lbCountDown.Click += new System.EventHandler(this.lbCountDown_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbPauseGame,
            this.tbRaceTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(616, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbPauseGame
            // 
            this.lbPauseGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseGame.Name = "lbPauseGame";
            this.lbPauseGame.Size = new System.Drawing.Size(47, 20);
            this.lbPauseGame.Text = "Stop";
            this.lbPauseGame.Click += new System.EventHandler(this.lbPauseGame_Click);
            // 
            // tbRaceTime
            // 
            this.tbRaceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRaceTime.Name = "tbRaceTime";
            this.tbRaceTime.Size = new System.Drawing.Size(54, 20);
            this.tbRaceTime.Text = "00:00";
            // 
            // raceTimer
            // 
            this.raceTimer.Interval = 1000;
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameToolStripMenuItem,
            this.startOverToolStripMenuItem,
            this.soundOffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(616, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveGameToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.saveGameToolStripMenuItem.Text = "Save";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // startOverToolStripMenuItem
            // 
            this.startOverToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOverToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startOverToolStripMenuItem.Name = "startOverToolStripMenuItem";
            this.startOverToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.startOverToolStripMenuItem.Text = "Start Over";
            this.startOverToolStripMenuItem.Click += new System.EventHandler(this.startOverToolStripMenuItem_Click);
            // 
            // soundOffToolStripMenuItem
            // 
            this.soundOffToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.soundOffToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundOffToolStripMenuItem.Name = "soundOffToolStripMenuItem";
            this.soundOffToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.soundOffToolStripMenuItem.Text = "Sound off";
            this.soundOffToolStripMenuItem.Click += new System.EventHandler(this.soundOffToolStripMenuItem_Click);
            // 
            // CarMove
            // 
            this.CarMove.Interval = 25;
            this.CarMove.Tick += new System.EventHandler(this.OpponentTImer_Tick);
            // 
            // GameSceneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::VP_Proektna.Properties.Resources.raceTrack;
            this.ClientSize = new System.Drawing.Size(616, 644);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbCountDown);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GameSceneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get to racing!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameSceneForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameSceneForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameSceneForm_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startOverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundOffToolStripMenuItem;
        private System.Windows.Forms.Timer CarMove;
    }
}

