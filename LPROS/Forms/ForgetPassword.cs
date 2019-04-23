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

namespace LPROS.Forms
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();
        DataTable kullanici;

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close, pictureBox_minimize);
        }

        private void kullaniciadisorgu()
        {
            kullanici = Sc.GET_DATATABLE("select * from Personel where kullanici_adi=@parametre1", new string[] { textbox_kullaniciadi.Text });

            if (kullanici.Rows.Count > 0)
            {
                label_head1.Visible = true;
                label_guvenliksorusu.Visible = true;
                label_head2.Visible = true;
                panel_cevap.Visible = true;

                label_head3.Visible = false;
                panel_sifre.Visible = false;

                string guvenliksorucu = kullanici.Rows[0]["guvenlik_soru"].ToString();
                string newguvensoru = "";
                if (guvenliksorucu.Length > 40)
                {
                    for (int i = 0; i < (guvenliksorucu.Length / 40) + 1; i++)
                    {
                        //int max = ((i * 40) + 40) <= guvenliksorucu.Length ? 40 : ((i * 40) + 40) - guvenliksorucu.Length;
                        if (i == 0)
                        {
                            newguvensoru += guvenliksorucu.Substring(0, guvenliksorucu.IndexOf(" ", ((i + 1) * 40))) + "\n";
                        }
                        else if ((i * 40) + 40 <= guvenliksorucu.Length)
                        {
                            newguvensoru += guvenliksorucu.Substring(guvenliksorucu.IndexOf(" ", (i * 40)) + 1, (guvenliksorucu.IndexOf(" ", ((i + 1) * 40)) - (i * 40)) - 1) + "\n";
                        }
                        else
                        {
                            newguvensoru += guvenliksorucu.Substring(guvenliksorucu.IndexOf(" ", (i * 40)) + 1) + "\n";
                        }
                    }
                }
                else
                {
                    newguvensoru = guvenliksorucu;
                }
                label_guvenliksorusu.Text = newguvensoru;
            }
            else
            {
                label_head1.Visible = false;
                label_guvenliksorusu.Visible = false;
                label_head2.Visible = false;
                panel_cevap.Visible = false;

                label_head3.Visible = false;
                panel_sifre.Visible = false;

                label_guvenliksorusu.Text = "";

                MessageBox.Show("Kullanıcı Bulunamadı!", "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void sifrebul()
        {
            bool sifregoster = false;
            if (kullanici != null)
            {
                if (kullanici.Rows.Count > 0)
                {
                    if (textbox_guvenlikcevap.Text == kullanici.Rows[0]["guvenlik_soru_cevap"].ToString())
                    {
                        textbox_sifre.Text = kullanici.Rows[0]["sifre"].ToString();

                        sifregoster = true;
                    }
                    else
                    {
                        MessageBox.Show("Girilen Bilgiler Hatalı!", "Geçersiz Cevap", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı!", "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!", "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (!sifregoster)
                textbox_sifre.Text = "";

            label_head3.Visible = sifregoster;
            panel_sifre.Visible = sifregoster;
        }

        private void button_kullaniciadi_ara_Click(object sender, EventArgs e)
        {
            kullaniciadisorgu();
        }

        private void button_sifrebul_Click(object sender, EventArgs e)
        {
            sifrebul();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sifrebul();
            }
        }

        private void textbox_kullaniciadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kullaniciadisorgu();
            }
        }

        private void PANEL_TEXT_USERNAME_Click(object sender, EventArgs e)
        {
            textbox_kullaniciadi.Focus();
        }

        private void panel_cevap_Click(object sender, EventArgs e)
        {
            textbox_guvenlikcevap.Focus();
        }

        private void textbox_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
