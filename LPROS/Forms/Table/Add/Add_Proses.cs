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
    public partial class Add_Proses : Form
    {
        public Add_Proses()
        {
            InitializeComponent();
        }

        public bool isUpdate = false;
        SqlConnector Sc = new SqlConnector();

        private void Add_Proses_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Proses Güncelle";
                button_proses_kaydet.Text = "Proses Bilgilerini Güncelle";
            }
        }

        private void ProsesKaydet()
        {
            String kod = textbox_proses_kod.Text, isim = textbox_proses_isim.Text;

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Proses Where kod=@parametre1";
                String _QueryIsim = "select * from Proses Where isim=@parametre1";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_proses_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_proses_isim.Focus();
                }
                else if (Sc.ADD_PROSES(textbox_proses_kod.Text, textbox_proses_isim.Text))
                {
                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbox_proses_kod.Text = "";
                    textbox_proses_isim.Text = "";
                    textbox_proses_kod.Focus();

                    Items.panelProtezTalimatProses.datagridProses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textbox_proses_kod.Text == "")
                {
                    textbox_proses_kod.Focus();
                }
                else if (textbox_proses_isim.Text == "")
                {
                    textbox_proses_isim.Focus();
                }
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            ProsesKaydet();
        }

        private void textBox_kayit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProsesKaydet();
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

        private void textBox_kod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
