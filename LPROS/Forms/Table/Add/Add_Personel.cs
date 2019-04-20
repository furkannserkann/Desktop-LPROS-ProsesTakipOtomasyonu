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
    public partial class Add_Personel : Form
    {
        public Add_Personel()
        {
            InitializeComponent();
        }
        public bool isUpdate = false;
        public String _SelectedTc="", _SelectedMaas="", _SelectedTelefon="", _SelectedIsim = "",_SelectedSoyisim = "", _SelectedId = "",_SelectedKullaniciAdi,_SelectedSifre, _SelectedEposta, _SelectedAdres,_SelectedSSKNo,_SelectedSSKBas,_SelectediseGiris,_SelectedCinsiyet,_SelectedDepartman,_SelectedYetki;

        private void Combo_yetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (Combo_yetki.ValueMember !="" && (int)Combo_yetki.SelectedValue == 4)
            {
                textBox_kullaniciadi.Enabled = false;
                textBox_sifre.Enabled = false;
                
            }
            else
            {
                textBox_kullaniciadi.Enabled = true;
                textBox_sifre.Enabled = true;
            }
        }

        SqlConnector Sc = new SqlConnector();

        private void createkullaniciadi(object sender, EventArgs e)
        {
            String isim = "", soyisim = "";
            if (textBox_isim.Text != "")
                isim = textBox_isim.Text;
            if (textBox_soyisim.Text != "")
                soyisim = textBox_soyisim.Text;

            if (textBox_isim.Text == "" && textBox_soyisim.Text == "")
                textBox_kullaniciadi.Text = null;
            else
            {
                textBox_kullaniciadi.Text = isim + (soyisim != "" ? textBox_soyisim.Text.Substring(0, 1) : "") +
                (DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString()) +
                (DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) +
                DateTime.Now.Year.ToString();
            }
        }

        private void Add_Personel_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);
            if (isUpdate)
            {
                label_head.Text = "Personel Güncelle";
                button_kaydet.Text = "Personel Bilgilerini Güncelle";

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
                Combo_cinsiyet.Text = _SelectedCinsiyet;
                Combo_departman.Text = _SelectedDepartman;
                Combo_yetki.Text = _SelectedYetki;
                textBox_maas.Text = _SelectedMaas;
                textBox_telefon.Text = _SelectedTelefon;

                button_kaydet.Click += button_guncelle_Click;
            }
            else
            {
                Combo_departman.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDepartman);
                Combo_departman.ValueMember = "id";
                Combo_departman.DisplayMember = "İsim";

                Combo_yetki.DataSource = Sc.GET_DATATABLE(SqlConnector.TableYetki);
                Combo_yetki.ValueMember = "id";
                Combo_yetki.DisplayMember = "Yetki Türü";

                Combo_cinsiyet.SelectedIndex = 0;


                button_kaydet.Click += button_kaydet_Click;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void button_kaydet_Click(object sender, EventArgs e)
        {
            PersonelKaydet();
        }
        private void PersonelKaydet()
        {
            String Tc = TextBox_Tc.Text;
            String isim = textBox_isim.Text;
            String Soyisim = textBox_soyisim.Text;
            String kullaniciadi = textBox_kullaniciadi.Enabled ? textBox_kullaniciadi.Text : "";
            String sifre = textBox_sifre.Enabled ? textBox_sifre.Text : "";
            String eposta = textBox_eposta.Text;
            String adres = textBox_adres.Text;
            String maas = textBox_maas.Text;
            String telefon = textBox_telefon.Text;
            string ssk_no = textBox_ssk_no.Text;
            string sskbas = DateTime_sskbas.Value.ToString("yyyy/MM/dd");
            string isegiris = DateTime_isegiris.Value.ToString("yyyy/MM/dd");
            string cinsiyet = Combo_cinsiyet.SelectedValue == "Erkek" ? "E" : "K";
            string departman = Combo_departman.SelectedValue.ToString();
            string yetki = Combo_yetki.SelectedValue.ToString();




            if (Tc != "" && isim != "" && Soyisim != "" && kullaniciadi != "" && sifre != "" && eposta != "" && ssk_no != "" && cinsiyet != "" && departman != "" && yetki != "" && maas != "" && telefon != "")
            {

                String _QueryTc = "select * from Personel Where tc=@parametre1";
                String _Querykullaniciadi = "select * from Personel Where kullanici_adi=@parametre1";
                String _Queryeposta = "select * from Personel Where e_posta=@parametre1";
                String _Queryessk_no = "select * from Personel Where ssk_no=@parametre1";
                String _Queryetelefon = "select * from Personel Where telefon=@parametre1";




                if (Sc.GET_DATATABLE(_QueryTc, new String[] { Tc }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Tc Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextBox_Tc.Focus();
                }
                else if (Sc.GET_DATATABLE(_Querykullaniciadi, new String[] { kullaniciadi }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kullanıcı Adı Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_kullaniciadi.Focus();
                }

                else if (Sc.GET_DATATABLE(_Queryeposta, new String[] { eposta }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen E-posta Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_eposta.Focus();
                }
                else if (Sc.GET_DATATABLE(_Queryessk_no, new String[] { ssk_no }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen SSK Numarası Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_ssk_no.Focus();
                }
                else if (Sc.GET_DATATABLE(_Queryetelefon, new String[] { telefon }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Telefon Numarası Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_telefon.Focus();
                }
                else if (Sc.ADD_TABLE("Personel", new String[] { "tc", "ad", "soyad","maas","telefon", "ssk_no", "ssk_bas_tarih", "ise_giris_tarih", "adres", "cinsiyet", "departman_no", "e_posta", "kullanici_adi", "sifre", "yetki_id" },
                    new String[] { Tc, isim, Soyisim, maas ,ssk_no,telefon, sskbas, isegiris, adres, cinsiyet, departman, eposta, kullaniciadi, sifre, yetki }))
                {
                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    TextBox_Tc.Text = "";
                    TextBox_Tc.Focus();
                    textBox_isim.Text = "";
                    textBox_soyisim.Text = "";
                    textBox_maas.Text = "";
                    textBox_telefon.Text = "";
                    textBox_ssk_no.Text = "";
                    DateTime_sskbas.Value = DateTime.Now;
                    DateTime_isegiris.Value = DateTime.Now;
                    textBox_adres.Text = "";
                    Combo_cinsiyet.SelectedIndex = 0;
                    Combo_departman.SelectedIndex = 0;
                    textBox_eposta.Text = "";
                    textBox_kullaniciadi.Text = "";
                    textBox_sifre.Text = "";
                    Combo_yetki.SelectedIndex = 0;





                    Items.panelPersonel.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonel);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void button_guncelle_Click(object sender, EventArgs e)
        {
            PersonelGüncelle();
        }
        private void PersonelGüncelle()
        {
            String Tc = TextBox_Tc.Text;
            String isim = textBox_isim.Text;
            String Soyisim = textBox_soyisim.Text;
            String kullaniciadi = textBox_kullaniciadi.Enabled ? textBox_kullaniciadi.Text : "";
            String sifre = textBox_sifre.Enabled ? textBox_sifre.Text : "";
            String eposta = textBox_eposta.Text;
            String adres = textBox_adres.Text;
            String maas = textBox_maas.Text;
            String telefon = textBox_telefon.Text;
            string ssk_no = textBox_ssk_no.Text;
            string sskbas = DateTime_sskbas.Value.ToString("yyyy/MM/dd");
            string isegiris = DateTime_isegiris.Value.ToString("yyyy/MM/dd");
            string cinsiyet = Combo_cinsiyet.SelectedValue == "Erkek" ? "E" : "K";
            string departman = Combo_departman.SelectedValue.ToString();
            string yetki = Combo_yetki.SelectedValue.ToString();

            String _UpdateCode = "update Personel set ad=@parametre1, soyad=@parametre2, tc=@parametre3, ssk_no=@parametre4, ssk_bas_tarih=@parametre5, ise_giris_tarih=@parametre6, adres=@parametre7, cinsiyet=@parametre8, maas=@parametre9, durumu=@parametre10, departman_no=@parametre11,e_posta=@parametre12, kullanici_adi=@parametre13,sifre=@parametre14,yetki_id=@parametre15,telefon=@parametre16 Where personel_no=@parametre17";

            if (Tc != "" && isim != "" && Soyisim != "" && kullaniciadi != "" && sifre != "" && eposta != "" && ssk_no != "" && cinsiyet != "" && departman != "" && yetki != "" && maas != "" && telefon != "")
            {
                String _QueryTc = "select * from Personel Where tc=@parametre1 and personel_no!=@parametre17";
                String _Querykullaniciadi = "select * from Personel Where kullanici_adi=@parametre2 and personel_no!=@parametre17";
                String _Queryeposta = "select * from Personel Where e_posta=@parametre2 and personel_no!=@parametre17";
                String _Queryessk_no = "select * from Personel Where ssk_no=@parametre2 and personel_no!=@parametre17";
                String _Queryetelefon = "select * from Personel Where telefon=@parametre2 and personel_no!=@parametre17";

                if (Sc.GET_DATATABLE(_QueryTc, new String[] { Tc }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Tc Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TextBox_Tc.Focus();
                }
                else if (Sc.GET_DATATABLE(_Querykullaniciadi, new String[] { kullaniciadi }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kullanıcı Adı Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_kullaniciadi.Focus();
                }

                else if (Sc.GET_DATATABLE(_Queryeposta, new String[] { eposta }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen E-posta Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_eposta.Focus();
                }
                else if (Sc.GET_DATATABLE(_Queryessk_no, new String[] { ssk_no }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen SSK Numarası Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_ssk_no.Focus();
                }
                else if (Sc.GET_DATATABLE(_Queryetelefon, new String[] { telefon }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Telefon Numarası Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_telefon.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { isim, kod, _SelectedId }))
                {
                    MessageBox.Show("Personel Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelPersonel.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonel);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_isim.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
