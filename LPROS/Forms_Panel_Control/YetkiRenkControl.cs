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
    public partial class YetkiRenkControl : Form
    {
        public YetkiRenkControl()
        {
            InitializeComponent();
        }

        private void YetkiRenkControl_Load(object sender, EventArgs e)
        {

        }

        private void button_eklerenk_Click(object sender, EventArgs e)
        {
            Add_Renk addRenk = new Add_Renk()
            {
                isUpdate = false
            };
            addRenk.ShowDialog();
        }

        private void button_renk_guncelle_Click(object sender, EventArgs e)
        {
            Add_Renk addRenk = new Add_Renk()
            {
                isUpdate = true
            };
            addRenk.ShowDialog();
        }
    }
}
