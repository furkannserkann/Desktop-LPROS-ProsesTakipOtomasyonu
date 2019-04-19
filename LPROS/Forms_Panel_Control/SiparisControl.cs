using LPROS.Forms;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Search;
using LPROS.Forms.Table.Update;
using System;
using System.Windows.Forms;

namespace LPROS.ControlPanelForms
{
    public partial class SiparisControl : Form
    {
        public SiparisControl()
        {
            InitializeComponent();
        }

        private void SiparisControl_Load(object sender, EventArgs e)
        {
            datetimepicker_teslimtarihi.Value = DateTime.Now.AddDays(1);
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            (new Add_Siparis()).ShowDialog();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            new CDialog()
            {
                BaslikForm = "Dikkat",
                BaslikMesaj = "Sipariş Siliniyor!",
                Mesaj = "Siparişi Silme İşlemini Onaylıyor musunuz?",
                Button1_Text = "Hayır",
                Button2_Text = "Evet",
            }.ShowDialog();
        }

        private void button_arama_Click(object sender, EventArgs e)
        {
            (new Search_Siparis()).ShowDialog();
        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            (new Update_Siparis()).ShowDialog();
        }
    }

    class CDialog : CustomMessageDialog
    {
        public override void Onayla()
        {
            MessageBox.Show("Test");
        }
    }
}
