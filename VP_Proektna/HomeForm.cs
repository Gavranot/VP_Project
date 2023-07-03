using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proektna
{
    public partial class HomeForm : Form
    {
        public SoundPlayer Player { get; set; } = new SoundPlayer(@"C:\Users\marija\Desktop\vp_proektna\VP_Project\VP_Proektna\Resources\onlymp3.to - GTA San Andreas Theme Song Full -W4VTq0sa9yg-192k-1688314322.wav");
        public bool IsSoundOn { get; set; } = true;

        public HomeForm()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = SetImageOpacity(this.BackgroundImage, 0.8f);

            Player.Load();
            ConfigureSound();
        }

        //funkcijata SetImageOpacity e prevzemena od https://www.codeproject.com/Tips/201129/Change-Opacity-of-Image-in-C
        private Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {           
           
        }

        private void ConfigureSound()
        {
            if (IsSoundOn)
            {
                Player.PlayLooping();
            }
            else
            {
                Player.Stop();
                btnSound.Image = Image.FromFile("")
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            IsSoundOn = !IsSoundOn;
            ConfigureSound();
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            
        }

        private void btnContinueGame_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
