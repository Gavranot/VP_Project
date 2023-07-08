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
        String playerName;

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

            this.BackgroundImageLayout = ImageLayout.Stretch;
            
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
            if (ValidateChildren())
            {
                this.Hide();
                GameSceneForm gameSceneForm = new GameSceneForm(selectedCar, carImagePaths, playerName);
                gameSceneForm.ShowDialog();
                this.Close();
            }
        }



        private void tbName_TextChanged(object sender, EventArgs e)
        {
            playerName = tbName.Text;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Equals(""))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }
    }
}
