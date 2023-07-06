using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VP_Proektna
{
    [Serializable]
    public partial class GameSceneForm : Form
    {
        public Scene Scene { get; set; }
        String playerCar { get; set; }
        List<String> carPaths;
        Random aiCarSelector = new Random();
        Random speedSelector = new Random();
        int timerCounter = 2; //se koristi i za dvata tamjeri bidejki se nezavisni  eden od drug       
        public static int MIN_SPEED { get; set; } = 1;
        public static int MAX_SPEED { get; set; } = 15;

        public bool isUpPressed { get; set; } = false;
        public bool isLeftPressed { get; set; } = false;
        public bool isRightPressed { get; set; } = false;


        public GameSceneForm(String playerCar, List<String> carPaths)
        {
            InitializeComponent();
            DoubleBuffered = true;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            Scene = new Scene(this.Width, this.Height, 
                1,
                speedSelector.Next(MIN_SPEED, MAX_SPEED),
                speedSelector.Next(MIN_SPEED, MAX_SPEED)
                );

            this.playerCar = playerCar;
            this.carPaths = carPaths;

            countDownTimer.Start();
        }

        public GameSceneForm(FileStream fs) {
            IFormatter formatter = new BinaryFormatter();
            Scene = (Scene)formatter.Deserialize(fs);
            Invalidate();
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

            
            if(timerCounter%5 == 0)
            {
                
                int select = speedSelector.Next(0, 50);
               
                if (select >= 25)
                {
                    if(Scene.Left.Speed < MAX_SPEED)
                    {
                        Scene.UpdateLeftOpponentSpeed(Scene.LeftSpeed + speedSelector.Next(1, 5));
                    }
                   
                }
                else
                {
                    if(Scene.Right.Speed < MAX_SPEED)
                    {
                        Scene.UpdateRightOpponentSpeed(Scene.RightSpeed + speedSelector.Next(1, 5));
                    }
                    
                }
            }

            int minutes = timerCounter / 60;          
            int seconds = timerCounter % 60;

            tbRaceTime.Text = $"{minutes}:{seconds}";

            if ((isUpPressed || isLeftPressed || isRightPressed) && Scene.Player.Speed < MAX_SPEED)
            {               
                int newSpeed = Scene.PlayerSpeed += 1;
                Scene.UpdatePlayerSpeed(newSpeed);
            }else if((!isUpPressed && !isLeftPressed && !isRightPressed) && Scene.Player.Speed > MIN_SPEED)
            {
                int newSpeed = Scene.PlayerSpeed -= 2;
                Scene.UpdatePlayerSpeed(newSpeed);
            }

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
            if(e.KeyCode == Keys.Up) {
                isUpPressed = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                isLeftPressed = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                isRightPressed = true;
            }
            Scene.MovePlayer(e);

            Invalidate();
        }

        private void GameSceneForm_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up) {
                isUpPressed = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                isLeftPressed = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                isRightPressed = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            raceTimer.Stop();
            countDownTimer.Stop();
            Scene.PauseOrStart();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Continue your previous game!";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName,FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Scene);
                raceTimer.Start();
                countDownTimer.Start();
                Scene.PauseOrStart();
            }
        }
    }
}
