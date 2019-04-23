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
    public partial class Add_Renk : Form
    {
        public Add_Renk()
        {
            InitializeComponent();
            // asd
        }

        public bool isUpdate = false;
        public string _SelectedId= "", _SelectedKod = "", _SelectedIsim = "";

        SqlConnector Sc = new SqlConnector();

        private void Add_Renk_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Renk Güncelle";
                button_kaydet.Text = "Renk Bilgilerini Güncelle";

                textbox_kod.Text = _SelectedKod;
                textbox_isim.Text = _SelectedIsim;

                button_kaydet.Click += button_guncelle_Click;
            }
            else
            {
                button_kaydet.Click += button_kaydet_Click;
            }
        }

        private void RenkKaydet()
        {
            String kod = textbox_kod.Text, isim = textbox_isim.Text;

            if (kod != "" && isim != "")
            {
                String _QueryKod = "select * from Renk Where kod=@parametre1";
                String _QueryIsim = "select * from Renk Where isim=@parametre1";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_isim.Focus();
                }
                else if (Sc.ADD_TABLE("Renk", new String[] { "kod", "isim", "durum" }, new String[] { kod, isim, "1" }))
                {
                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbox_kod.Text = "";
                    textbox_isim.Text = "";
                    textbox_kod.Focus();

                    Items.panelYetkiRenk.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableRenk);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (kod == "")
                    textbox_kod.Focus();
                else if (isim == "")
                    textbox_isim.Focus();
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            RenkKaydet();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            RenkGüncelle();
        }

        private void RenkGüncelle()
        {
            String isim = textbox_isim.Text, kod = textbox_kod.Text;
            String _UpdateCode = "update Renk set isim=@parametre1, kod=@parametre2 Where id=@parametre3";

            if (isim != "")
            {
                String _QueryKod = "select * from Renk Where kod=@parametre1 and Id!=@parametre2";
                String _QueryIsim = "select * from Renk Where isim=@parametre1 and Id!=@parametre2";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { isim, kod, _SelectedId }))
                {
                    MessageBox.Show("Renk Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelYetkiRenk.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableRenk);
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
                if (kod == "")
                    textbox_kod.Focus();
                else if (isim == "")
                    textbox_isim.Focus();
            }
        }
    }
}
