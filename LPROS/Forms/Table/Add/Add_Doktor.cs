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
    public partial class Add_Doktor : Form
    {
        public Add_Doktor()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();
        public string _Select_ad, _Select_soyad, _Select_hastane, _Select_id, _Select_hastane_id, _selected_durum;
        public bool isUpdate = false;

        private void Add_Doktor_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Sc.GET_DATATABLE(SqlConnector.TableHastane);
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Adı";
            comboBox1.SelectedValue = _Select_hastane_id;

            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Doktor Güncelle";
                button_kaydet.Text = "Doktor Bilgilerini Güncelle";
                textBox_isim.Text = _Select_ad;
                textBox_soyisim.Text = _Select_soyad;
                comboBox1.SelectedValue = _Select_hastane_id;
                comboBox2.SelectedItem = _selected_durum;
                button_kaydet.Click += button_guncelle_Click;
                comboBox2.Visible = true;
                label1.Visible = true;
            }
            else
            {
                button_kaydet.Click += button_kaydet_Click;
            }

        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DoktorKaydet();
        }
        private void button_guncelle_Click(object sender, EventArgs e)
        {
            DoktorGuncelle();
        }
        private void DoktorKaydet()
        {
            string ad = textBox_isim.Text;
            string soyad = textBox_soyisim.Text;
            string hastane = comboBox1.SelectedText;
            string hastane_id = comboBox1.SelectedValue.ToString();



            if (ad != "" && soyad != "")
            {
                string _QueryIsim = "select * from Doktorlar Where isim=@parametre1 AND soyisim=@parametre2 AND hastane_id=@parametre3";

                if (Sc.GET_DATATABLE(_QueryIsim, new String[] { ad, soyad, hastane }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Doktor Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_isim.Focus();
                }
                else if (Sc.ADD_TABLE("Doktorlar", new String[] { "isim", "soyisim", "hastane_id", "aktif" }, new String[] { ad, soyad, hastane_id,"true"  }))
                {
                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textBox_isim.Text = "";
                    textBox_soyisim.Text = "";
                    comboBox1.Text = "";
                    textBox_isim.Focus();
                    if (hastane_id == _Select_hastane_id)
                        Items.panelHastaneDoktor.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDoktorByHastaneid, new string[] { comboBox1.SelectedValue.ToString() });
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
                else if (textBox_soyisim.Text == "")
                {
                    textBox_soyisim.Focus();
                }
                else if (comboBox1.Text == "")
                {
                    comboBox1.Focus();
                }
            }
        }
        private void DoktorGuncelle()
        {
            string ad = textBox_isim.Text;
            string soyad = textBox_soyisim.Text;
            string hastane = comboBox1.SelectedText;
            string hastane_id = comboBox1.SelectedValue.ToString();
            string durum = comboBox2.SelectedItem == "Aktif" ? "1" : "0";



            if (ad != "" && soyad != "")
            {
                string _QueryIsim = "select * from Doktorlar Where isim=@parametre1 AND soyisim=@parametre2 AND hastane_id=@parametre3 AND Id!=@parametre4";
                string _UpdateCode = "update Doktorlar set isim=@parametre1, soyisim=@parametre2, hastane_id=@parametre3, aktif=@parametre4 Where Id=@parametre5";

                if (Sc.GET_DATATABLE(_QueryIsim, new String[] { ad, soyad, hastane, _Select_id }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Doktor Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { ad, soyad, hastane_id, durum, _Select_id }))
                {
                    MessageBox.Show("Doktor Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelHastaneDoktor.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDoktorByHastaneid, new string[] {_Select_hastane_id });
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
                else if (textBox_soyisim.Text == "")
                {
                    textBox_soyisim.Focus();
                }
                else if (comboBox1.Text == "")
                {
                    comboBox1.Focus();
                }
            }

        }
    }
}
