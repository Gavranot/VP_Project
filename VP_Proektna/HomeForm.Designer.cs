namespace VP_Proektna
{
    partial class HomeForm
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnContinueGame = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNewGame.Location = new System.Drawing.Point(143, 479);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(200, 40);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Нова игра";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnContinueGame
            // 
            this.btnContinueGame.BackColor = System.Drawing.Color.PowderBlue;
            this.btnContinueGame.Location = new System.Drawing.Point(143, 524);
            this.btnContinueGame.Name = "btnContinueGame";
            this.btnContinueGame.Size = new System.Drawing.Size(200, 40);
            this.btnContinueGame.TabIndex = 1;
            this.btnContinueGame.Text = "Продолжи";
            this.btnContinueGame.UseVisualStyleBackColor = false;
            this.btnContinueGame.Click += new System.EventHandler(this.btnContinueGame_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHelp.Location = new System.Drawing.Point(143, 570);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(200, 40);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Помош";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Crimson;
            this.btnSound.BackgroundImage = global::VP_Proektna.Properties.Resources.sound_icon_resized;
            this.btnSound.Location = new System.Drawing.Point(410, 12);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(70, 60);
            this.btnSound.TabIndex = 3;
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 49.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(68, 185);
            this.label1.MaximumSize = new System.Drawing.Size(400, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 204);
            this.label1.TabIndex = 4;
            this.label1.Text = "CAR RACING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Proektna.Properties.Resources.racing_car;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnContinueGame);
            this.Controls.Add(this.btnNewGame);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnContinueGame;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label label1;
    }
}