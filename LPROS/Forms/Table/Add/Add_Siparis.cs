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
    public partial class Add_Siparis : Form
    {
        public Add_Siparis()
        {
            InitializeComponent();
        }

        private void Add_Siparis_Load(object sender, EventArgs e)
        {
            textBox_fisno.Text = DateTime.Now.Year.ToString() + "-";
            dateTimePicker_siparistarihi.MaxDate = DateTime.Now;
            dateTimePicker_teslimattarihi.MinDate = DateTime.Now.AddDays(1);

            new FormTasima(panel_head, label_head, this, pictureBox_close);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İşlem Başarılı", "Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information)  == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_doktor.Enabled = true;
        }
    }

    class CDialog : CustomMessageDialog
    {
        public override void Onayla()
        {
            MessageBox.Show("Test");
        }
    }
}
