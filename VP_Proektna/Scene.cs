using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proektna
{
    public class Scene
    {
        public Player Player { get; set; }
        public Opponent Left { get; set; }
        public Opponent Right { get; set; }

        public static int Width { get; set; }
        public static int Height { get; set; }



        public bool IsPaused { get; set; } = true;

        public int PlayerSpeed { get; set; }
        public int LeftSpeed { get; set; }
        public int RightSpeed { get; set; }
        public static int DISTANCE_FROM_BOTTOM { get; set; } = 100;

        public Scene(int width, int height, int playerSpeed, int leftSpeed, int rightSpeed)
        {
            Width = width;
            Height = height;
            PlayerSpeed = playerSpeed;
            LeftSpeed = leftSpeed;  
            RightSpeed = rightSpeed;
        }

        public void CreatePlayer(String playerImagePath)
        {
            Player = new Player(playerImagePath, new Point(3 * Width/7, Height - DISTANCE_FROM_BOTTOM), PlayerSpeed);
        }

        public void CreateLeftOpponenet(String leftOpponentImagePath)
        {
            Left = new Opponent(leftOpponentImagePath, new Point(Width/7, Height - DISTANCE_FROM_BOTTOM), LeftSpeed);
        }

        public void CreateRightOpponenet(String rightOpponentImagePath)
        {
            Right = new Opponent(rightOpponentImagePath, new Point(5 * Width/7, Height - DISTANCE_FROM_BOTTOM), RightSpeed);
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

        public void MoveOpponenets()
        {

            if (!IsPaused)
            {
                Left.MoveUp();
                Right.MoveUp();
            }
        }

        public void MovePlayer(int direction)
        {
            if(!IsPaused)
            {
                switch (direction)
                {
                    case 0: Player.MoveUp(); break;
                    case 1: Player.MoveLeft(); break;
                    case 2: Player.MoveRight(); break;
                }
            }
            
        }
    }
}
