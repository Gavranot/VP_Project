using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proektna
{
    public class Car
    {
        public String ImagePath { get; set; }
        public Image Image { get; set; }
        public Point Location { get; set; }
        public int Speed { get; set; }

        public static int NUM_ROUNDS { get; set; } = 6;
        public int Round { get; set; } = 1;
        public bool IsFinished { get; set; } = false;
        public int FinishTime { get; set; } = 0;

        public Car(String imagePath, Point location, int speed)
        {
            ImagePath = imagePath;
            Image = new Bitmap(ImagePath);
            Location = location;
            Speed = speed;
        }

        public void Draw(Graphics g)
        {
            Rectangle rectangle = new Rectangle(Location.X, Location.Y - Image.Height, Image.Width, Image.Height);
            TextureBrush brush = new TextureBrush(Image);
            brush.TranslateTransform(Location.X, Location.Y - Image.Height);
 
            g.FillRectangle(brush, rectangle);
            brush.Dispose();
        }

        public void MoveUp()
        {
            if(Round == NUM_ROUNDS + 1)
            {
                IsFinished = true;
                Location = new Point(Location.X, Scene.Height - Image.Height - 10);
            }
            else
            {
                Location = new Point(Location.X, (Location.Y - 10) - Speed);
                if (Location.Y <= 0)
                {
                    Location = new Point(Location.X, Scene.Height);
                    Round++;
                }
            }          
        }

    }
}
