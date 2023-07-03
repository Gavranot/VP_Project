namespace VP_Proektna
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pbPickCar = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 196);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(315, 196);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pbPickCar
            // 
            this.pbPickCar.BackColor = System.Drawing.Color.Black;
            this.pbPickCar.Location = new System.Drawing.Point(154, 119);
            this.pbPickCar.Name = "pbPickCar";
            this.pbPickCar.Size = new System.Drawing.Size(100, 181);
            this.pbPickCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPickCar.TabIndex = 0;
            this.pbPickCar.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChoose.Location = new System.Drawing.Point(131, 327);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(142, 80);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Choose!";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // CarPickForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.pbPickCar);
            this.Name = "CarPickForm";
            this.Text = "CarPickForm";
            this.Load += new System.EventHandler(this.CarPickForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPickCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPickCar;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnChoose;
    }
}