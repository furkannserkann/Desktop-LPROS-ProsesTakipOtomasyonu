using LPROS.Forms.Table.Add;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms_Panel_Control
{
    public partial class MalzemelerControl : Form
    {
        public MalzemelerControl()
        {
            InitializeComponent();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Add_Malzemeler addMalzeme = new Add_Malzemeler()
            {
                isUpdate = false
            };
            addMalzeme.ShowDialog();
        }

        private void button_malzeme_guncelle_Click(object sender, EventArgs e)
        {
            Add_Malzemeler addMalzeme = new Add_Malzemeler()
            {
                isUpdate = true
            };
            addMalzeme.ShowDialog();
        }
    }
}
