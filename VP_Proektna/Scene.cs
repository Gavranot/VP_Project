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

        public int Width { get; set; }
        public int Height { get; set; }



        public bool IsPaused { get; set; } = true;

        Random random = new Random();

        public static int MIN_SPEED { get; set; } = 10;
        public static int MAX_SPEED { get; set; } = 20;
        public static int DISTANCE_FROM_BOTTOM { get; set; } = 100;

        public Scene(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void CreatePlayer(String playerImagePath)
        {
            Player = new Player(playerImagePath, new Point(3 * Width/7, Height - DISTANCE_FROM_BOTTOM), random.Next(MIN_SPEED, MAX_SPEED));
        }

        public void CreateLeftOpponenet(String leftOpponentImagePath)
        {
            Left = new Opponent(leftOpponentImagePath, new Point(Width/7, Height - DISTANCE_FROM_BOTTOM), random.Next(MIN_SPEED, MAX_SPEED));
        }

        public void CreateRightOpponenet(String rightOpponentImagePath)
        {
            Right = new Opponent(rightOpponentImagePath, new Point(5 * Width/7, Height - DISTANCE_FROM_BOTTOM), random.Next(MIN_SPEED, MAX_SPEED));
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
