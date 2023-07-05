using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proektna
{
    public class Car
    {
        public String ImagePath { get; set; }
        public Image Image { get; set; }
        public Point Location { get; set; }
        public int Speed { get; set; }

        public Car(String imagePath, Point location, int speed)
        {
            ImagePath = imagePath;
            Image = new Bitmap(ImagePath);
            Location = location;
            Speed = speed;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new TextureBrush(Image);
            g.FillRectangle(brush, new Rectangle(Location.X, Location.Y - Image.Height, Image.Width, Image.Height));
            brush.Dispose();
        }

        public void MoveUp()
        {
            Location = new Point(Location.X, (Location.Y - 10) - Speed);
        }

    }
}
