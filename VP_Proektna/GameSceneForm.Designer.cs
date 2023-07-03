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
            this.btnPause = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbOpponent2 = new System.Windows.Forms.PictureBox();
            this.pbOpponent1 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack2 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack1 = new System.Windows.Forms.PictureBox();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(12, 539);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(160, 67);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause the game";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(206, 551);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(246, 31);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "Current time: 00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbCountDown);
            this.panel1.Controls.Add(this.pbPlayer);
            this.panel1.Controls.Add(this.pbOpponent2);
            this.panel1.Controls.Add(this.pbOpponent1);
            this.panel1.Controls.Add(this.pbRaceTrack2);
            this.panel1.Controls.Add(this.pbRaceTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 503);
            this.panel1.TabIndex = 3;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(249, 417);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 50);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 4;
            this.pbPlayer.TabStop = false;
            // 
            // pbOpponent2
            // 
            this.pbOpponent2.Location = new System.Drawing.Point(428, 417);
            this.pbOpponent2.Name = "pbOpponent2";
            this.pbOpponent2.Size = new System.Drawing.Size(100, 50);
            this.pbOpponent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOpponent2.TabIndex = 3;
            this.pbOpponent2.TabStop = false;
            // 
            // pbOpponent1
            // 
            this.pbOpponent1.Location = new System.Drawing.Point(60, 417);
            this.pbOpponent1.Name = "pbOpponent1";
            this.pbOpponent1.Size = new System.Drawing.Size(100, 50);
            this.pbOpponent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOpponent1.TabIndex = 2;
            this.pbOpponent1.TabStop = false;
            // 
            // pbRaceTrack2
            // 
            this.pbRaceTrack2.BackColor = System.Drawing.Color.Black;
            this.pbRaceTrack2.Image = global::VP_Proektna.Properties.Resources.raceTrack;
            this.pbRaceTrack2.Location = new System.Drawing.Point(0, 0);
            this.pbRaceTrack2.Name = "pbRaceTrack2";
            this.pbRaceTrack2.Size = new System.Drawing.Size(580, 503);
            this.pbRaceTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack2.TabIndex = 1;
            this.pbRaceTrack2.TabStop = false;
            // 
            // pbRaceTrack1
            // 
            this.pbRaceTrack1.BackColor = System.Drawing.Color.Black;
            this.pbRaceTrack1.Image = global::VP_Proektna.Properties.Resources.raceTrack;
            this.pbRaceTrack1.Location = new System.Drawing.Point(0, -503);
            this.pbRaceTrack1.Name = "pbRaceTrack1";
            this.pbRaceTrack1.Size = new System.Drawing.Size(580, 503);
            this.pbRaceTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack1.TabIndex = 0;
            this.pbRaceTrack1.TabStop = false;
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.ForeColor = System.Drawing.Color.Red;
            this.lbCountDown.Location = new System.Drawing.Point(151, 112);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(289, 63);
            this.lbCountDown.TabIndex = 5;
            this.lbCountDown.Text = "RACE IN 3";
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // GameSceneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnPause);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameSceneForm";
            this.Text = "GameSceneForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRaceTrack1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbOpponent2;
        private System.Windows.Forms.PictureBox pbOpponent1;
        private System.Windows.Forms.PictureBox pbRaceTrack2;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.Timer countDownTimer;
    }
}

