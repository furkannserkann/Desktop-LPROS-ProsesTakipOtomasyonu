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

namespace LPROS.Forms.Table.Update
{
    public partial class Update_Proses : Form
    {
        public Update_Proses()
        {
            InitializeComponent();
        }

        private SqlConnector Sc = new SqlConnector();

        public String _SelectedId = "";
        public String _SelectedKod = "";
        public String _SelectedIsim = "";

        private void Update_Proses_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            textBox_isim.Text = _SelectedIsim;
            textBox_kod.Text = _SelectedKod;
            textBox_isim.Focus();
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

        private void ProsesGüncelle()
        {
            String kod = textBox_kod.Text, isim = textBox_isim.Text;
            String _UpdateCode = "update Proses set kod=@parametre1, isim=@parametre2 Where Id=@parametre3";

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Proses Where kod=@parametre1 and Id!=@parametre2";
                String _QueryIsim = "select * from Proses Where isim=@parametre1 and Id!=@parametre2";

                if (kod == _SelectedKod && isim == _SelectedIsim)
                {
                    MessageBox.Show("Değişiklik Yapmadınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { kod, isim, _SelectedId }))
                {
                    MessageBox.Show("Proses Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelProtezTalimatProses.datagridProses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
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

                if (textBox_kod.Text == "")
                {
                    textBox_kod.Focus();
                }
                else if (textBox_isim.Text == "")
                {
                    textBox_isim.Focus();
                }
            }
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            ProsesGüncelle();
        }

        private void update_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProsesGüncelle();
            }
        }
    }
}