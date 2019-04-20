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

namespace LPROS.Forms.Table.Search
{
    public partial class Search_Personel : Form
    {
        public Search_Personel()
        {
            InitializeComponent();
        }

        private void Search_Personel_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
