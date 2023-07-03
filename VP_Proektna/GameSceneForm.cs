using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proektna
{
    public partial class GameSceneForm : Form
    {
        String playerCar { get; set; }
        List<String> carPaths;
        Random aiCarSelector = new Random();
        int count = 2;

        public GameSceneForm(String playerCar, List<String> carPaths)
        {
            InitializeComponent();
            this.playerCar = playerCar;
            this.carPaths = carPaths;
            countDownTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbPlayer.ImageLocation = playerCar;
            pbOpponent1.ImageLocation = carPaths[aiCarSelector.Next(0, carPaths.Count)];
            pbOpponent2.ImageLocation = carPaths[aiCarSelector.Next(0, carPaths.Count)];

        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            lbCountDown.Text = $"RACE IN {count}";
            if(count == 2)
            {
                lbCountDown.ForeColor = Color.Orange;
                count--;
            }
            else if(count==1)
            {
                lbCountDown.ForeColor= Color.Yellow;
                count--;
            }
            else
            {
                lbCountDown.Text = "GO GO GO!";
                lbCountDown.ForeColor = Color.Green;
                lbCountDown.Hide();
                countDownTimer.Stop();
            }
        }
    }
}
