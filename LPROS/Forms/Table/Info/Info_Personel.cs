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
    public partial class Info_Personel : Form
    {
        public Info_Personel()
        {
            InitializeComponent();
        }
        public bool gor = false;
        public String _SelectedGuvenlikcvp = "", _SelectedGuvenlik = "", _SelectedDurumu = "", _SelectedTc = "", _SelectedMaas = "", _SelectedTelefon = "", _SelectedIsim = "", _SelectedSoyisim = "", _SelectedId = "", _SelectedKullaniciAdi, _SelectedSifre, _SelectedEposta, _SelectedAdres, _SelectedSSKNo, _SelectedSSKBas, _SelectediseGiris, _SelectedCinsiyet, _SelectedDepartman, _SelectedYetki;

        SqlConnector Sc = new SqlConnector();

        private void Info_Personel_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            Combo_departman.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDepartman);
            Combo_departman.ValueMember = "id";
            Combo_departman.DisplayMember = "İsim";

            Combo_yetki.DataSource = Sc.GET_DATATABLE(SqlConnector.TableYetki);
            Combo_yetki.ValueMember = "id";
            Combo_yetki.DisplayMember = "Yetki Türü";





            TextBox_Tc.Text = _SelectedTc;
            textBox_isim.Text = _SelectedIsim;
            textBox_soyisim.Text = _SelectedSoyisim;
            textBox_kullaniciadi.Text = _SelectedKullaniciAdi;
            textBox_sifre.Text = _SelectedSifre;
            textBox_eposta.Text = _SelectedEposta;
            textBox_adres.Text = _SelectedAdres;
            textBox_ssk_no.Text = _SelectedSSKNo;
            DateTime_sskbas.Text = _SelectedSSKBas;
            DateTime_isegiris.Text = _SelectediseGiris;
            Combo_cinsiyet.Text = _SelectedCinsiyet == "E" ? "Erkek" : "Kadın";
            Combo_departman.Text = _SelectedDepartman;
            Combo_yetki.Text = _SelectedYetki;
            textBox_maas.Text = _SelectedMaas;
            textBox_telefon.Text = _SelectedTelefon;
            Combo_durumu.Text = _SelectedDurumu;
            combo_güvenlik.SelectedItem = _SelectedGuvenlik;
            textBox_güvenlik.Text = _SelectedGuvenlikcvp;
            Combo_durumu.Visible = true;

        }
    }
}
