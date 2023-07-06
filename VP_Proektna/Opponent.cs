using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VP_Proektna
{
    [Serializable]
    public class Opponent : Car
    {
        public Opponent(string imagePath, Point location, int speed) : base(imagePath, location, speed)
        {
        }

        public void OvertakeLeft()
        {
            Location = new Point(Location.X - Speed, Location.Y - Speed);
        }
        public void OvertakeRight()
        {
            Location = new Point(Location.X + Speed, Location.Y - Speed);
        }
    }
}
