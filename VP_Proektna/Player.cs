using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proektna
{
    public class Player : Car
    {
        public Player(string imagePath, Point location, int speed) : base(imagePath, location, speed)
        {
        }

        public void MoveLeft()
        {
            Location = new Point(Location.X - 5, Location.Y);
        }

        public void MoveRight()
        {
            Location = new Point(Location.X + 5, Location.Y);
        }

    }
}
