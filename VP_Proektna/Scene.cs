using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VP_Proektna
{
    [Serializable]
    public class Scene
    {
        public Player Player { get; set; }
        public Opponent Left { get; set; }
        public Opponent Right { get; set; }

        public static int Width { get; set; }
        public static int Height { get; set; }

        public String PlayerPath { get; set; }
        public List<String> carPaths { get; set; }
        public int timerCounter { get; set; } = 0;
        public int opponentTimerCounter { get; set; } = 0;  

        public bool IsPaused { get; set; } = true;

        public int PlayerSpeed { get; set; }
        public int LeftSpeed { get; set; }
        public int RightSpeed { get; set; }

        public static int MAX_SPEED { get; set; } = 0;
        public static int DISTANCE_FROM_BOTTOM { get; set; } = 100;

        public Random moveAI {  get; set; } = new Random();

        public List<Car> FinishedCars { get; set; } = new List<Car>();
        public bool AllFinished { get; set; } = false;



        public Scene(int width, int height, int playerSpeed, int leftSpeed, int rightSpeed, int maxSpeed)
        {
            Width = width;
            Height = height;
            PlayerSpeed = playerSpeed;
            LeftSpeed = leftSpeed;  
            RightSpeed = rightSpeed;
            MAX_SPEED = maxSpeed;
            Console.WriteLine($"Height: {height}");
        }

       

        public void CreatePlayer(String playerImagePath, String name)
        {
            Player = new Player(playerImagePath, new Point(3 * Width/7, Height - DISTANCE_FROM_BOTTOM), PlayerSpeed, name);
        }

        public void CreateLeftOpponenet(String leftOpponentImagePath, String name)
        {
            Left = new Opponent(leftOpponentImagePath, new Point(Width/7, Height - DISTANCE_FROM_BOTTOM), LeftSpeed, name);
        }

        public void CreateRightOpponenet(String rightOpponentImagePath, String name)
        {
            Right = new Opponent(rightOpponentImagePath, new Point(5 * Width/7, Height - DISTANCE_FROM_BOTTOM), RightSpeed, name);
        }

        public void Draw(Graphics g)
        {
            Player.Draw(g);
            Left.Draw(g);
            Right.Draw(g);
        }

        public void PauseOrStart()
        {
            IsPaused = !IsPaused;

        }

        public bool MoveOpponenets(bool swerve, int timeCounter)
        {
            //Console.WriteLine($"Opponents speeds : {Left.Speed} and {Right.Speed}");
           
            if (!IsPaused)
            {
                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                {
                    // Console.WriteLine("Collision!");
                    return true;
                }

                if (swerve)
                {
                    int rand = moveAI.Next(0, 2);
                    if (!Left.IsFinished)
                    {
                        if (rand == 0)
                        {
                            for (int i = 0; i < 3 && Left.Location.X > Left.Image.Width-20; i++)
                            {
                                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                                {
                                    // Console.WriteLine("Collision!");
                                    return true;
                                }
                                Left.OvertakeLeft();
                            }

                        }
                        else
                        {
                            for (int i = 0; i < 3 && Left.Location.X < Width - Left.Image.Width-20; i++)
                            {
                                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                                {
                                    // Console.WriteLine("Collision!");
                                    return true;
                                }
                                Left.OvertakeRight();
                            }

                        }
                    }

                    if (!Right.IsFinished)
                    {
                        rand = moveAI.Next(0, 2);
                        if (rand == 0)
                        {
                            for (int i = 0; i < 3 && Right.Location.X > Right.Image.Width-20 * 2; i++)
                            {
                                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                                {
                                    // Console.WriteLine("Collision!");
                                    return true;
                                }
                                Right.OvertakeLeft();
                            }

                        }
                        else
                        {
                            for (int i = 0; i < 3 && Right.Location.X < Width - Right.Image.Width-20; i++)
                            {
                                if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
                                {
                                    // Console.WriteLine("Collision!");
                                    return true;
                                }
                                Right.OvertakeRight();
                            }

                        }
                    }
                    
                }
                else
                {
                    if (!Left.IsFinished)
                    {
                        Left.MoveUp(timeCounter);
                    }
                    if (!Right.IsFinished)
                    {
                        Right.MoveUp(timeCounter);
                    }
                   
                }

                if (Left.IsFinished && !FinishedCars.Contains(Left))
                {
                    FinishedCars.Add(Left);
                }

                if (Right.IsFinished && !FinishedCars.Contains(Right))
                {
                    FinishedCars.Add(Right);
                }

                if (Player.IsFinished && !FinishedCars.Contains(Player))
                {
                    FinishedCars.Add(Player);
                }

            }
           
            return false;

        }

        public void UpdatePlayerSpeed(int newSpeed)
        {
            PlayerSpeed = newSpeed;
            Player.Speed = newSpeed;
        }

        public void UpdateLeftOpponentSpeed(int newSpeed)
        {
            if(Left.Speed <= MAX_SPEED)
            {
                Left.Speed = newSpeed;
                LeftSpeed = newSpeed;
            }
            
        }

        public void UpdateRightOpponentSpeed(int newSpeed)
        {
            if(Right.Speed <= MAX_SPEED)
            {
                Right.Speed = newSpeed;
                RightSpeed = newSpeed;
            }
            
        }

        public bool MovePlayer(KeyEventArgs keyDown, int timeCounter)
        {
            Console.WriteLine($"Player location: {Player.Location}");

            if (!Player.IsFinished && (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox)))
            {
                // Console.WriteLine("Collision!");
                return true;
            }

            if (!IsPaused)
            {
              
                
                    if (keyDown.KeyCode == Keys.Up)
                    {
                        Player.MoveUp(timeCounter);
                    }
                    else if (keyDown.KeyCode == Keys.Left && Player.Location.X >= Player.Image.Width-20)
                    {
                        Player.OvertakeLeft();
                    }
                    else if (keyDown.KeyCode == Keys.Right && Player.Location.X <= Width - Player.Image.Width - 20)
                    {
                        Player.OvertakeRight();
                    }
              
            }
            return false;
            
        }

        private static int compareByFinish(Car car1, Car car2)
        {
            if(car1.FinishTime > car2.FinishTime)
            {
                return 1;
            }
            if(car1.FinishTime < car2.FinishTime)
            {
                return -1;
            }
            return 0;
        }

        public String FinishGame()
        {
            AllFinished = Player.IsFinished && Left.IsFinished && Right.IsFinished;

            StringBuilder sb = new StringBuilder();

            if (AllFinished)
            {
                FinishedCars.Sort(compareByFinish);
                for(int i = 0; i <FinishedCars.Count; i++)
                {
                    
                    int minutes = FinishedCars[i].FinishTime / 60;
                    int seconds = FinishedCars[i].FinishTime % 60;
                    sb.Append($"{i+1}. {FinishedCars[i].Name} {minutes:00}:{seconds:00}\n");
                }
            }

            return sb.ToString();
        }
    }
}
