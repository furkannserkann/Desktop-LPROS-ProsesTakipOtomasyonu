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
    public partial class Add_Malzemeler : Form
    {
        public Add_Malzemeler()
        {
            InitializeComponent();
        }

        public bool isUpdate = false;
        public String _Selectid, _Selectad, _Selectfiyat;
        SqlConnector Sc = new SqlConnector();

        private void Add_Malzemeler_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Malzeme Güncelle";
                button_kaydet.Text = "Malzeme Bilgilerini Güncelle";
                textbox_isim.Text = _Selectad;
                masktextbox_fiyat.Text = _Selectfiyat;
                button_kaydet.Click += button_guncelle_Click;               
            }
            else
            {
                button_kaydet.Click += button_kaydet_Click;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            MalzemeKaydet();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            MalzemeGuncelle();
        }

        private void MalzemeKaydet()
        {
            string isim = textbox_isim.Text;
            string fiyat = masktextbox_fiyat.Text.Replace(" ", "");

            if (isim != "" && fiyat != ",")
            {
                string _QueryIsim = "select * from Malzemeler Where adi=@parametre1";

                if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_isim.Focus();
                }
                else if (Sc.ADD_TABLE("Malzemeler", new String[] { "adi", "fiyat" }, new String[] { isim, double.Parse(fiyat.Replace(" ", "").Replace(".", ",")).ToString() }))
                {
                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbox_isim.Text = "";
                    masktextbox_fiyat.Text = "000";
                    textbox_isim.Focus();

                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textbox_isim.Text == "")
                {
                    textbox_isim.Focus();
                }
                else if (masktextbox_fiyat.Text == "")
                {
                    masktextbox_fiyat.Focus();
                }
            }
        }

        private void textbox_kayit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MalzemeKaydet();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MalzemeGuncelle()
        {
            String ad = textbox_isim.Text, fiyat = masktextbox_fiyat.Text.Replace(" ", "");
            String _UpdateCode = "update Malzemeler set adi=@parametre1, fiyat=@parametre2 Where Id=@parametre3";

            if (ad != "" && fiyat!= ",")
            {
                String _QueryKod = "select * from Malzemeler Where adi=@parametre1 and Id!=@parametre2";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { ad, _Selectid }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Ad Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { ad, fiyat, _Selectid }))
                {
                    MessageBox.Show("Malzeme Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler);
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
                if (ad == "")
                    textbox_isim.Focus();
                else if (fiyat == "")
                    masktextbox_fiyat.Focus();
            }
        }
    }
}
