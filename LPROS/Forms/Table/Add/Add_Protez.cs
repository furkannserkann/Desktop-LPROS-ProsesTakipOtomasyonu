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
    public partial class Add_Protez : Form
    {
        public Add_Protez()
        {
            InitializeComponent();
        }

        public bool isUpdate = false;

        private void Add_Protez_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Protez Güncelle";
                button_protez_kaydet.Text = "Protez Bilgilerini Güncelle";
            }
        }
    }
}
