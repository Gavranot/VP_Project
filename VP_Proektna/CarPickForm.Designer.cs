﻿namespace VP_Proektna
{
    partial class CarPickForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPickForm));
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pbPickCar = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPickCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLeft.Location = new System.Drawing.Point(131, 293);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRight.Location = new System.Drawing.Point(398, 293);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pbPickCar
            // 
            this.pbPickCar.BackColor = System.Drawing.Color.Black;
            this.pbPickCar.Location = new System.Drawing.Point(254, 214);
            this.pbPickCar.Name = "pbPickCar";
            this.pbPickCar.Size = new System.Drawing.Size(100, 181);
            this.pbPickCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPickCar.TabIndex = 0;
            this.pbPickCar.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChoose.Location = new System.Drawing.Point(231, 436);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(142, 32);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Choose!";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Thistle;
            this.tbName.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbName.Location = new System.Drawing.Point(178, 103);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(250, 28);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "";
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(200, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Внесете го вашето име";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CarPickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VP_Proektna.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(616, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pbPickCar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CarPickForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your car!";
            this.Load += new System.EventHandler(this.CarPickForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPickCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPickCar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.RichTextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}