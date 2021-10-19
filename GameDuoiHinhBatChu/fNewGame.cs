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
    public partial class fNewGame : Form
    {
        public fNewGame()
        {
            InitializeComponent();
        }
        #region EVENTS
        private void ptrNewGame_MouseHover(object sender, EventArgs e)
        {
            ptrNewGame.BackgroundImage = Properties.Resources.newgame2;
        }

        private void ptrNewGame_MouseLeave(object sender, EventArgs e)
        {
            ptrNewGame.BackgroundImage = Properties.Resources.newgame1;
        }

        private void ptrNewGame_MouseDown(object sender, MouseEventArgs e)
        {
            ptrNewGame.BackgroundImage = Properties.Resources.newgame3;
        }

        private void ptrNewGame_MouseUp(object sender, MouseEventArgs e)
        {
            ptrNewGame.BackgroundImage = Properties.Resources.newgame1;
        }

        private void ptrExit_MouseHover(object sender, EventArgs e)
        {
            ptrExit.BackgroundImage = Properties.Resources.exit2;
        }

        private void ptrExit_MouseLeave(object sender, EventArgs e)
        {
            ptrExit.BackgroundImage = Properties.Resources.exit1;
        }

        private void ptrExit_MouseDown(object sender, MouseEventArgs e)
        {
            ptrExit.BackgroundImage = Properties.Resources.exit3;
        }

        private void ptrExit_MouseUp(object sender, MouseEventArgs e)
        {
            ptrExit.BackgroundImage = Properties.Resources.exit1;
        }

        private void ptrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptrNewGame_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
        private void fNewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát game không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
