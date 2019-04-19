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
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlem Başarılı", "Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
