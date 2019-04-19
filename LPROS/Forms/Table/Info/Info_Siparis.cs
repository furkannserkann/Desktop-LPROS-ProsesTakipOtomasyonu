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

namespace LPROS.Forms.Table.Info
{
    public partial class Info_Siparis : Form
    {
        public Info_Siparis()
        {
            InitializeComponent();
        }

        private void Info_Siparis_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);
        }
    }
}
