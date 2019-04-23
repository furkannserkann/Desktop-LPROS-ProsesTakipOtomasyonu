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
    public partial class Add_Departman : Form
    {
        public Add_Departman()
        {
            InitializeComponent();
        }

        public bool isUpdate = false;
        public String _SelectedIsim = "", _SelectedId = "";

        SqlConnector Sc = new SqlConnector();

        private void Add_Departman_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Departman Güncelle";
                button_kaydet.Text = "Departman Bilgilerini Güncelle";

                textbox_isim.Text = _SelectedIsim;
                button_kaydet.Click += button_guncelle_Click;
            }
            else
            {
                button_kaydet.Click += button_kaydet_Click;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DepartmanKaydet();
        }

        private void DepartmanKaydet()
        {
            String isim = textbox_isim.Text;

            if (isim != "")
            {
                String _QueryIsim = "select * from Departman Where isim=@parametre1";

                if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_isim.Focus();
                }
                else if (Sc.ADD_TABLE("Departman", new String[] { "isim", "durum" }, new String[] { isim, "1" }))
                {
                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbox_isim.Text = "";
                    textbox_isim.Focus();

                    Items.panelDepartman.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDepartman);
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

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            DepartmanGüncelle();
        }

        private void DepartmanGüncelle()
        {
            String isim = textbox_isim.Text;
            String _UpdateCode = "update Departman set isim=@parametre1 Where id=@parametre2";

            if (isim != "")
            {
                String _QueryIsim = "select * from Departman Where isim=@parametre1";

                if (_SelectedIsim == isim)
                {
                    MessageBox.Show("Değişiklik Yapmadınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { isim, _SelectedId }))
                {
                    MessageBox.Show("Departman Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelDepartman.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDepartman);
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox_kayit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DepartmanKaydet();
            }
        }
    }
}
