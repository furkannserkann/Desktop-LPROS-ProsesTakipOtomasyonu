using LPROS.Custom;
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
            Add_Personel adPer = new Add_Personel()
            {
                isUpdate = false

            };
            adPer.ShowDialog();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {

        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            DataGridView dtg = Items.panelPersonel.dataGridview;
            Add_Personel adPer = new Add_Personel()
            {
                isUpdate = true,
                _SelectedTc = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["TC Kimlik Numarası"].Value.ToString(),
                _SelectedIsim = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Adı"].Value.ToString(),
                _SelectedSoyisim = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Soyadı"].Value.ToString(),
                _SelectedKullaniciAdi = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Kullanıcı Adı"].Value.ToString(),
                _SelectedSifre = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["sifre"].Value.ToString(),
                _SelectedEposta = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["E_Posta"].Value.ToString(),
                _SelectedAdres = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Adres"].Value.ToString(),
                _SelectedSSKNo = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["SSK Numarası"].Value.ToString(),
                _SelectedSSKBas = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["SSK Başlangıç Tarihi"].Value.ToString(),
                _SelectediseGiris = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["İşe Giriş Tarihi"].Value.ToString(),
                _SelectedCinsiyet = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Cinsiyet"].Value.ToString(),
                _SelectedDepartman = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Departman"].Value.ToString(),
                _SelectedYetki = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Yetki"].Value.ToString(),
                _SelectedMaas = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Maaş"].Value.ToString(),
                _SelectedDurumu = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Durumu"].Value.ToString(),
                _SelectedTelefon = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Telefon Numarası"].Value.ToString(),
                _SelectedId = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["personel_no"].Value.ToString(),

            };
            adPer.ShowDialog();
        }

        private void button_arama_Click(object sender, EventArgs e)
        {
            (new Search_Personel()).ShowDialog();
        }
    }
}
