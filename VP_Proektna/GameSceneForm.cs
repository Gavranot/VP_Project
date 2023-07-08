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
        public String playerCar { get; set; }
        public List<String> carPaths { get; set; }
        Random aiCarSelector = new Random();
        Random speedSelector = new Random();
        int countDownCounter = 2; //se koristi i za dvata tamjeri bidejki se nezavisni  eden od drug       
        public static int MIN_SPEED { get; set; } = 1;
        public static int MAX_SPEED { get; set; } = 15;

        public bool isUpPressed { get; set; } = false;
        public bool isLeftPressed { get; set; } = false;
        public bool isRightPressed { get; set; } = false;

        public bool IsSoundOn { get; set; } = true;


        public GameSceneForm(String playerCar, List<String> carPaths, String playerName)
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
            Scene.PlayerPath = playerCar;
            Scene.carPaths = carPaths;

            Scene.CreatePlayer(playerCar, playerName);
            Scene.CreateLeftOpponenet(carPaths[aiCarSelector.Next(0, carPaths.Count)], "Opponent 1");
            Scene.CreateRightOpponenet(carPaths[aiCarSelector.Next(0, carPaths.Count)], "Opponent 2");

            countDownTimer.Start();
        }

        public GameSceneForm(IFormatter formatter, FileStream fs) {
            InitializeComponent();
            DoubleBuffered = true;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            Scene = (Scene)formatter.Deserialize(fs);
            raceTimer.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Invalidate();
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            lbCountDown.Text = $"RACE IN {countDownCounter}";
            if(countDownCounter == 2)
            {
                lbCountDown.ForeColor = Color.Orange;
                countDownCounter--;
            }
            else if(countDownCounter==1)
            {
                lbCountDown.ForeColor= Color.Yellow;
                countDownCounter--;
            }
            else if(countDownCounter==0)
            {
                lbCountDown.Text = "GO GO GO!";
                lbCountDown.ForeColor = Color.Green;              
                countDownCounter--;
            }
            else
            {
                lbCountDown.Hide();
                countDownTimer.Stop();
                raceTimer.Start();
            }
        }

        private void GameSceneForm_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
            Scene.timerCounter++;

            
            if(Scene.timerCounter%5 == 0)
            {
                
                int select = speedSelector.Next(0, 50);
               
                if (select >= 25)
                {
                    if(Scene.Left.Speed < MAX_SPEED)
                    {
                        Scene.UpdateLeftOpponentSpeed(Scene.Left.Speed + speedSelector.Next(1, 4));
                    }
                   
                }
                else
                {
                    if(Scene.Right.Speed < MAX_SPEED)
                    {
                        Scene.UpdateRightOpponentSpeed(Scene.Right.Speed + speedSelector.Next(1, 4));
                    }
                    
                }
                
            }

            int minutes = Scene.timerCounter / 60;          
            int seconds = Scene.timerCounter % 60;

            tbRaceTime.Text = $"{minutes:00}:{seconds:00}";

            if ((isUpPressed || isLeftPressed || isRightPressed) && Scene.Player.Speed < MAX_SPEED)
            {               
                int newSpeed = Scene.PlayerSpeed += 1;
                Scene.UpdatePlayerSpeed(newSpeed);
            }else if((!isUpPressed && !isLeftPressed && !isRightPressed) && Scene.Player.Speed > MIN_SPEED)
            {
                int newSpeed = Scene.PlayerSpeed -= 2;
                Scene.UpdatePlayerSpeed(newSpeed);
            }
            bool swerve = false;
            if (speedSelector.Next(0, 50) >= 38)
            {
                swerve = true;
            }

            Scene.PauseOrStart();
            Scene.MoveOpponenets(swerve, countDownCounter);
            Invalidate();

            String winnersStatus = Scene.FinishGame();
            if (!winnersStatus.Equals(""))
            {
                raceTimer.Stop();
                this.Hide();
                WinnerForm form = new WinnerForm(winnersStatus);
                form.ShowDialog();
                this.Close();
            }
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
            bool check = Scene.MovePlayer(e, Scene.timerCounter);
            if(check == true)
            {
                lbCountDown.Show();
                lbCountDown.Text = "Game over!";
                lbCountDown.BackColor = Color.Red;
                raceTimer.Stop();
                countDownTimer.Stop();
                Scene.PauseOrStart();

                DialogResult result = MessageBox.Show("Имаше судар со противникот :( \n Дали сакаш да почнеш од почеток?", 
                    "ИГРАТА ЗАВРШИ", 
                    MessageBoxButtons.YesNo);

               if(result == DialogResult.Yes)
                {
                    String playerCar = this.playerCar;
                    List<String> carPaths = this.carPaths;
                    String name = Scene.Player.Name;
                    this.Hide();
                    GameSceneForm form = new GameSceneForm(playerCar, carPaths, name); 
                    form.ShowDialog();
                    this.Close();
                }

                return;
            }

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
            
        }

        private void lbCountDown_Click(object sender, EventArgs e)
        {

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raceTimer.Stop();
            this.Hide();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save your game!";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, Scene);

            }
            this.Close();
        }

        private void startOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String playerCar = this.playerCar;
            List<String> carPaths = this.carPaths;
            this.Hide();
            GameSceneForm form = new GameSceneForm(playerCar, carPaths, Scene.Player.Name);
            form.ShowDialog();
            this.Close();
        }

        private void soundOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsSoundOn = !IsSoundOn;
            ConfigureSound();
        }

        private void ConfigureSound()
        {
            if (IsSoundOn)
            {
                HomeForm.Player.PlayLooping();
                soundOffToolStripMenuItem.Text = "Sound off";
            }
            else
            {
                HomeForm.Player.Stop();
                soundOffToolStripMenuItem.Text = "Sound on";
            }
        }
    }
}
