﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proektna
{
    [Serializable]
    public class Player : Car
    {
        public Player(string imagePath, Point location, int speed, string name) : base(imagePath, location, speed, name)
        {
        }

        public void MoveLeft()
        {        
            Location = new Point(Location.X - Speed, Location.Y);
        }

        public void MoveRight()
        {
            Location = new Point(Location.X + Speed, Location.Y);
        }

        public void OvertakeLeft()
        {
            Location = new Point(Location.X - Speed, Location.Y - Speed-5);
        }
        public void OvertakeRight()
        {
            Location = new Point(Location.X + Speed, Location.Y - Speed-5);
        }

    }
}
