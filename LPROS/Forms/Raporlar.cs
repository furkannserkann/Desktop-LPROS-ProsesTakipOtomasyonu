using LPROS.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }

        private void Raporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySetting.isOpenRapor = false;
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
