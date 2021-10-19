using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDuoiHinhBatChu
{
    public partial class fDapAn : Form
    {
        public fDapAn()
        {
            InitializeComponent();
        }
        #region ENVENTS
        private void fDapAn_Load(object sender, EventArgs e)
        {
            label1.Text = temp;
        }

        public string temp;

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.tieptuc2;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.tieptuc1;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.tieptuc3;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.BackgroundImage = Properties.Resources.tieptuc1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
