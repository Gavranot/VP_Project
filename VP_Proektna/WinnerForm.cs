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
    public partial class WinnerForm : Form
    {
        String Status;
        public WinnerForm(String status)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Status = status;
        }

        private void OpponentWinnerForm_Load(object sender, EventArgs e)
        {
            lbWinners.Text = Status;
        }
    }
}
