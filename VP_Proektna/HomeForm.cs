using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proektna
{
    public partial class HomeForm : Form
    {
        public static SoundPlayer Player { get; set; } = new SoundPlayer(@"../../Resources/RacingAudio.wav");
        public bool IsSoundOn { get; set; } = true;

        public HomeForm()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;

            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnSound.BackgroundImageLayout = ImageLayout.Stretch;
            Player.Load();
            ConfigureSound();
        }
       

        private void HomeForm_Load(object sender, EventArgs e)
        {           
           
        }

        private void ConfigureSound()
        {
            if (IsSoundOn)
            {
                Player.PlayLooping();
                btnSound.BackgroundImage = Image.FromFile("../../Resources/sound-on.jpg");
            }
            else
            {
                Player.Stop();
                btnSound.BackgroundImage = Image.FromFile("../../Resources/sound-off.png");
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            IsSoundOn = !IsSoundOn;
            ConfigureSound();
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarPickForm carPickForm = new CarPickForm();
            carPickForm.ShowDialog();
            this.Close();
        }

        private void btnContinueGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Continue your game!";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
                this.Hide();
                GameSceneForm continued = new GameSceneForm(formatter, fs);
                continued.ShowDialog();
                this.Close();
            }
        }

    }
}
