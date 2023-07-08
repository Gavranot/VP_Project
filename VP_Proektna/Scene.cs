using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public bool IsPaused { get; set; } = true;

        public int PlayerSpeed { get; set; }
        public int LeftSpeed { get; set; }
        public int RightSpeed { get; set; }
        public static int DISTANCE_FROM_BOTTOM { get; set; } = 100;

        public Random moveAI {  get; set; } = new Random();

        public Stack<Car> FinishedCars { get; set; } = new Stack<Car>();
        public bool AllFinished { get; set; } = false;



        public Scene(int width, int height, int playerSpeed, int leftSpeed, int rightSpeed)
        {
            Width = width;
            Height = height;
            PlayerSpeed = playerSpeed;
            LeftSpeed = leftSpeed;  
            RightSpeed = rightSpeed;
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

                if (Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox) && !Player.IsFinished)
                {
                    // Console.WriteLine("Collision!");
                    return true;
                }
                if (swerve)
                {
                    int rand = moveAI.Next(0, 2);
                    if(rand == 0)
                    {
                        for(int i = 0; i<5 && Left.Location.X > Left.Speed*2; i++)
                        {
                            Left.OvertakeLeft();
                        }
                        
                    }
                    else
                    {
                        for(int i = 0; i<5 && Left.Location.X < Width+Left.Speed*2; i++)
                        {
                            Left.OvertakeRight();
                        }
                       
                    }
                    rand = moveAI.Next(0, 2);
                    if(rand == 0)
                    {
                        for(int i = 0; i<5 && Right.Location.X > Right.Speed*2; i++)
                        {
                            Right.OvertakeLeft();
                        }
                       
                    }
                    else
                    {
                        for(int i = 0; i<5 && Right.Location.X < Width + Right.Speed*2; i++)
                        {
                            Right.OvertakeRight();
                        }
                        
                    }
                }
                else
                {
                    Left.MoveUp(timeCounter);
                    Right.MoveUp(timeCounter);
                }

                if (Left.IsFinished)
                {
                    FinishedCars.Push(Left);
                }

                if (Right.IsFinished)
                {
                    FinishedCars.Push(Right);
                }

                if (Player.IsFinished)
                {
                    FinishedCars.Push(Player);
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
            Left.Speed = newSpeed;
            LeftSpeed = newSpeed;
        }

        public void UpdateRightOpponentSpeed(int newSpeed)
        {
            Right.Speed = newSpeed;
            RightSpeed = newSpeed;
        }

        public bool MovePlayer(KeyEventArgs keyDown, int timeCounter)
        {
            //Console.WriteLine($"Player speed: {PlayerSpeed}");

            if(Player.hitBox.IntersectsWith(Left.hitBox) || Player.hitBox.IntersectsWith(Right.hitBox) && !Player.IsFinished)
            {
               // Console.WriteLine("Collision!");
                return true;
            }

            if(!IsPaused)
            {
              
                
                    if (keyDown.KeyCode == Keys.Up)
                    {
                        Player.MoveUp(timeCounter);
                    }
                    else if (keyDown.KeyCode == Keys.Left)
                    {
                        Player.OvertakeLeft();
                    }
                    else if (keyDown.KeyCode == Keys.Right)
                    {
                        Player.OvertakeRight();
                    }
              
            }
            return false;
            
        }

        public String FinishGame()
        {
            AllFinished = Player.IsFinished && Left.IsFinished && Right.IsFinished;

            StringBuilder sb = new StringBuilder();

            if (AllFinished)
            {               
                for(int i = 1; i <=3; i++)
                {
                    Car car = FinishedCars.Pop();
                    int minutes = car.FinishTime / 60;
                    int seconds = car.FinishTime % 60;
                    sb.Append($"{i}. {car.Name} {minutes:00}:{seconds:00}\n");
                }
            }

            return sb.ToString();
        }
    }
}
