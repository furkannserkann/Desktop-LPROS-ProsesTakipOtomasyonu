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
    public partial class Barkod : Form
    {
        public Barkod()
        {
            InitializeComponent();
        }

        private void Barkod_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);
        }

        private void Barkod_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySetting.isOpenBarkod = false;
        }
    }
}
