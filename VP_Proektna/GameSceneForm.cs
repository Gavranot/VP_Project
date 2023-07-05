using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VP_Proektna
{
    public partial class GameSceneForm : Form
    {
        public Scene Scene { get; set; }
        String playerCar { get; set; }
        List<String> carPaths;
        Random aiCarSelector = new Random();
        Random speedSelector = new Random();
        int timerCounter = 2; //se koristi i za dvata tamjeri bidejki se nezavisni  eden od drug       
        public static int MIN_SPEED { get; set; } = 10;
        public static int MAX_SPEED { get; set; } = 20;


        public GameSceneForm(String playerCar, List<String> carPaths)
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            Scene = new Scene(this.Width, this.Height, 
                speedSelector.Next(MIN_SPEED, MAX_SPEED),
                speedSelector.Next(MIN_SPEED, MAX_SPEED),
                speedSelector.Next(MIN_SPEED, MAX_SPEED)
                );

            this.playerCar = playerCar;
            this.carPaths = carPaths;

            countDownTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Scene.CreatePlayer(playerCar);
            Scene.CreateLeftOpponenet(carPaths[aiCarSelector.Next(0, carPaths.Count)]);
            Scene.CreateRightOpponenet(carPaths[aiCarSelector.Next(0, carPaths.Count)]);
            Invalidate();

 //           pbPlayer.ImageLocation = playerCar;
 //           pbOpponent1.ImageLocation = carPaths[aiCarSelector.Next(0, carPaths.Count)];
 //           pbOpponent2.ImageLocation = carPaths[aiCarSelector.Next(0, carPaths.Count)];

        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            lbCountDown.Text = $"RACE IN {timerCounter}";
            if(timerCounter == 2)
            {
                lbCountDown.ForeColor = Color.Orange;
                timerCounter--;
            }
            else if(timerCounter==1)
            {
                lbCountDown.ForeColor= Color.Yellow;
                timerCounter--;
            }
            else if(timerCounter==0)
            {
                lbCountDown.Text = "GO GO GO!";
                lbCountDown.ForeColor = Color.Green;              
                timerCounter--;
            }
            else
            {
                lbCountDown.Hide();
                countDownTimer.Stop();
                raceTimer.Start();
                timerCounter = 0;
            }
        }

        private void GameSceneForm_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            int minutes = timerCounter / 60;          
            int seconds = timerCounter % 60;

            tbRaceTime.Text = $"{minutes}:{seconds}";

            Scene.PauseOrStart();
            Scene.MoveOpponenets();
            Invalidate();
        }

        private void lbPauseGame_Click(object sender, EventArgs e)
        {
            Scene.PauseOrStart();
            if(Scene.IsPaused)
            {
                lbPauseGame.Text = "Start";
                raceTimer.Stop();
            }
            else
            {
                lbPauseGame.Text = "Stop";
                raceTimer.Start();
            }
        }

        private void GameSceneForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                Scene.MovePlayer(0);
            }else if(e.KeyCode == Keys.Left) 
            {
                Scene.MovePlayer(1);
            }else if(e.KeyCode== Keys.Right)
            {
                Scene.MovePlayer(2);
            }

            Invalidate();
        }
    }
}
