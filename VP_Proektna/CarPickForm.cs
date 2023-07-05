using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proektna
{
    public partial class CarPickForm : Form
    {
        List<String> carImagePaths;
        int currIndex;
        public String selectedCar;

        public CarPickForm()
        {
            InitializeComponent();
            carImagePaths = new List<String>();
            carImagePaths.Add(@"../../Resources/carorange.png");
            String[] carNames = { "ambulance-png","cargreen-png","cargrey-png", "carpink-png", "carred-png", "truckblue-png", "truckwhite-png" };
            for(int i = 0; i< carNames.Length; i++)
            {
                carImagePaths.Add(@"../../Resources/" + carNames[i] + ".png");
            }
            currIndex = 0;
            
        }

        private void CarPickForm_Load(object sender, EventArgs e)
        {
            pbPickCar.ImageLocation = carImagePaths[0];
            
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(currIndex < carImagePaths.Count-1)
            {
                currIndex++;
                pbPickCar.ImageLocation = carImagePaths[currIndex];
                
            }
            else
            {
                currIndex = 0;
                pbPickCar.ImageLocation = carImagePaths[currIndex];
            }
            Console.WriteLine(currIndex);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currIndex > 0)
            {
                currIndex--;
                pbPickCar.ImageLocation = carImagePaths[currIndex];
                
            }
            else
            {
                currIndex = carImagePaths.Count-1;
                pbPickCar.ImageLocation = carImagePaths[currIndex];
            }
            Console.WriteLine(currIndex);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            selectedCar = carImagePaths[currIndex];
            this.Hide();
            GameSceneForm gameSceneForm = new GameSceneForm(selectedCar, carImagePaths);
            gameSceneForm.ShowDialog();
            this.Close();
        }
    }
}
