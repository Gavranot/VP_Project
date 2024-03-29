﻿namespace VP_Proektna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnContinueGame = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNewGame.Location = new System.Drawing.Point(238, 397);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(150, 32);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Нова игра";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnContinueGame
            // 
            this.btnContinueGame.BackColor = System.Drawing.Color.PowderBlue;
            this.btnContinueGame.Location = new System.Drawing.Point(238, 444);
            this.btnContinueGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinueGame.Name = "btnContinueGame";
            this.btnContinueGame.Size = new System.Drawing.Size(150, 32);
            this.btnContinueGame.TabIndex = 1;
            this.btnContinueGame.Text = "Продолжи";
            this.btnContinueGame.UseVisualStyleBackColor = false;
            this.btnContinueGame.Click += new System.EventHandler(this.btnContinueGame_Click);
            // 
            // btnSound
            // 
            this.btnSound.AutoSize = true;
            this.btnSound.BackColor = System.Drawing.Color.Thistle;
            this.btnSound.BackgroundImage = global::VP_Proektna.Properties.Resources.sound_on;
            this.btnSound.Location = new System.Drawing.Point(555, 10);
            this.btnSound.Margin = new System.Windows.Forms.Padding(2);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(52, 49);
            this.btnSound.TabIndex = 3;
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(93, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visual Racing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Proektna.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(616, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnContinueGame);
            this.Controls.Add(this.btnNewGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Visual Racing";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnContinueGame;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label label1;
    }
}