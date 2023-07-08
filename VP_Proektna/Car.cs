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
    [Serializable]
    public class Car
    {
        public String ImagePath { get; set; }
        public Image Image { get; set; }
        public String Name { get; set; }
        public Point Location { get; set; }
        public int Speed { get; set; }


        public Rectangle hitBox { get; set; }   


        public static int NUM_ROUNDS { get; set; } = 1;
        public int Round { get; set; } = 1;
        public bool IsFinished { get; set; } = false;
        public int FinishTime { get; set; } = 0;

        public Car(String imagePath, Point location, int speed, String name)
        {
            ImagePath = imagePath;
            Image = new Bitmap(ImagePath);
            Location = location;
            Speed = speed;
            Name = name;            
        }

        public void Draw(Graphics g)
        {
            Rectangle rectangle = new Rectangle(Location.X, Location.Y - Image.Height, Image.Width, Image.Height);
            hitBox = rectangle;
            TextureBrush brush = new TextureBrush(Image);
            brush.TranslateTransform(Location.X, Location.Y - Image.Height);
 
            g.FillRectangle(brush, rectangle);
            brush.Dispose();
        }

        public void MoveUp(int timeCounter)
        {
           
            if(Round == NUM_ROUNDS + 1)
            {
                if (!IsFinished)
                {
                    Console.WriteLine($"Car: {ImagePath}, Time : {timeCounter}");
                    IsFinished = true;
                    Location = new Point(Location.X, Scene.Height - Image.Height - 10);

                    FinishTime = timeCounter;
                   
                }              
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
