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

namespace LPROS.Forms.Table.Add
{
    public partial class Add_Renk : Form
    {
        public Add_Renk()
        {
            InitializeComponent();
        }

        public bool isUpdate = false;

        private void Add_Renk_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Renk Güncelle";
                button_kaydet.Text = "Renk Bilgilerini Güncelle";
            }
        }
    }
}
