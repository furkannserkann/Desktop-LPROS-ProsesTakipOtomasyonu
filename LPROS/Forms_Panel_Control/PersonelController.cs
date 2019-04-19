using LPROS.Forms;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Search;
using LPROS.Forms.Table.Update;
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
    public partial class PersonelController : Form
    {
        public PersonelController()
        {
            InitializeComponent();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            (new Add_Personel()).ShowDialog();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            new CDialog()
            {
                BaslikForm = "Dikkat",
                BaslikMesaj = "Personel Siliniyor!",
                Mesaj = "Personeli Silme İşlemini Onaylıyor musunuz?",
                Button1_Text = "Hayır",
                Button2_Text = "Evet",
            }.ShowDialog();
        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            (new Update_Personel()).ShowDialog();
        }

        private void button_arama_Click(object sender, EventArgs e)
        {
            (new Search_Personel()).ShowDialog();
        }
    }

    class CDialog : CustomMessageDialog
    {
        public override void Onayla()
        {
            MessageBox.Show("Onaylandı!");
        }
    }
}
