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
    public partial class Add_Hastane : Form
    {
        public Add_Hastane()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();
        public bool isUpdate = false;
        public string _Select_ad, _Select_kod, _Select_adres, _Select_id;

        private void Add_HastaneDoktor_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Hastane Güncelle";
                button_kaydet.Text = "Hastane Bilgilerini Güncelle";
                textBox_kod.Text = _Select_kod;
                textBox_isim.Text = _Select_ad;
                textBox_adres.Text = _Select_adres;
                button_kaydet.Click += button_guncelle_Click;
            }
            else
            {
                button_kaydet.Click += button_kaydet_Click;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            HastaneKaydet();
        }
        private void button_guncelle_Click(object sender, EventArgs e)
        {
            HastaneGuncelle();
        }

        private void HastaneKaydet()
        {
            string ad = textBox_isim.Text;
            string kod = textBox_kod.Text;
            string adres = textBox_adres.Text;


            if (ad != "" && kod != "" && adres != "")
            {
                string _QueryIsim = "select * from Hastane Where ad=@parametre1";
                string _QueryKod = "select * from Hastane Where kod=@parametre1";

                if (Sc.GET_DATATABLE(_QueryIsim, new String[] { ad }).Rows.Count > 0 )
                {
                    MessageBox.Show("Girilen Hatane Adı Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_isim.Focus();
                }
                else if(Sc.GET_DATATABLE(_QueryKod, new String[] { kod }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Hatane Kodu Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_isim.Focus();
                }
                else if (Sc.ADD_TABLE("Hastane", new String[] { "kod", "ad", "adres" }, new String[] { kod,ad,adres }))
                {
                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBox_isim.Text = "";
                    textBox_kod .Text = "";
                    textBox_adres.Text = "";
                    textBox_isim.Focus();

                    Items.panelHastaneDoktor.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableHastane);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textBox_isim.Text == "")
                {
                    textBox_isim.Focus();
                }
                else if (textBox_kod.Text == "")
                {
                   textBox_kod.Focus();
                }
                else if (textBox_adres.Text == "")
                {
                    textBox_adres.Focus();
                }
            }
        }
        private void HastaneGuncelle()
        {
            string ad = textBox_isim.Text;
            string kod = textBox_kod.Text;
            string adres = textBox_adres.Text;


            if (ad != "" && kod != "" && adres != "")
            {
                string _QueryIsim = "select * from Hastane Where ad=@parametre1 and Id!=@parametre2";
                string _QueryKod = "select * from Hastane Where kod=@parametre1 and Id!=@parametre2";

            String _UpdateCode = "update Hastane set kod=@parametre1, ad=@parametre2, adres=@parametre3 Where Id=@parametre4";

                if (Sc.GET_DATATABLE(_QueryIsim, new String[] { ad,_Select_id }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Hatane Adı Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_isim.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod, _Select_id }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Hastane Kodu Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { kod, ad,adres, _Select_id }))
                {
                    MessageBox.Show("Hastane Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelHastaneDoktor.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableHastane);
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

                if (textBox_isim.Text == "")
                {
                    textBox_isim.Focus();
                }
                else if (textBox_kod.Text == "")
                {
                    textBox_kod.Focus();
                }
                else if (textBox_adres.Text == "")
                {
                    textBox_adres.Focus();
                }
            }
        }
    }
}
