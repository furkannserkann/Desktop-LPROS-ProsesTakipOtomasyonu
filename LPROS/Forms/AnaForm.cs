using LPROS.ControlPanelForms;
using LPROS.Custom;
using LPROS.Forms;
using LPROS.Forms_Panel;
using LPROS.Forms_Panel_Control;
using LPROS.Panel_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_kullanici_adsoyad.Text = User.ad + " " + User.soyad;
            label_kullanici_yetkitipi.Text = User.yetki_tipi;

            if (User.yetki_id == "1")
            {
                button_siprais.Visible = true;
                button_hastanevedoktorlar.Visible = true;
                button_protez.Visible = true;
                button_talimatlar.Visible = true;
                button_prosesler.Visible = true;
                button_malzemeler.Visible = true;
                button_renk.Visible = true;
                button_personel.Visible = true;
                button_departman.Visible = true;
                button_barkod.Visible = true;
                button_raporlar.Visible = true;

                button_barkod.Location = new Point(9, 622);
            }
            else if (User.yetki_id == "2")
            {
                button_siprais.Visible = true;
                button_hastanevedoktorlar.Visible = false;
                button_protez.Visible = false;
                button_talimatlar.Visible = false;
                button_prosesler.Visible = false;
                button_malzemeler.Visible = false;
                button_renk.Visible = false;
                button_personel.Visible = false;
                button_departman.Visible = false;
                button_barkod.Visible = false;
                button_raporlar.Visible = false;

                button_barkod.Location = new Point(9, 622);
            }
            else if (User.yetki_id == "3")
            {
                button_siprais.Visible = false;
                button_hastanevedoktorlar.Visible = false;
                button_protez.Visible = false;
                button_talimatlar.Visible = false;
                button_prosesler.Visible = false;
                button_malzemeler.Visible = false;
                button_renk.Visible = false;
                button_personel.Visible = false;
                button_departman.Visible = false;
                button_barkod.Visible = true;
                button_raporlar.Visible = false;

                button_barkod.Location = new Point(9, 136);
            }

            if (User.yetki_id == "1" || User.yetki_id == "2")
            {
                PanelFormLoad(new Siparis(), new SiparisControl());
            }
            else if (User.yetki_id == "3")
            {
                MySetting.FormBarkod = new Barkod();
                MySetting.FormBarkod.Show();
                MySetting.isOpenBarkod = true;
            }
        }


        #region EVENTS

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.Yes)
            {
                if (MySetting.isOpenBarkod)
                    MySetting.FormBarkod.Close();

                this.Close();
            }
        }

        private void button_siprais_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_siprais);
            PanelFormLoad(new Siparis(), new SiparisControl());
        }

        private void button_personel_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_personel);
            PanelFormLoad(new Personel(), new PersonelController());
        }

        #endregion

        Form LastOpenPanelForm;
        private void PanelFormLoad(Form form, Form ControlForm)
        {
            try
            {
                if (LastOpenPanelForm == null)
                {
                    LastOpenPanelForm = form;

                    
                    panel_forms.Controls.Clear();
                    form.TopLevel = false;
                    panel_forms.Controls.Add(form);

                    form.Dock = DockStyle.Fill;
                    form.BringToFront();
                    form.Show();

                    PanelControlLoad(ControlForm);

                }
                else if (!LastOpenPanelForm.Name.Equals(form.Name))
                {
                    LastOpenPanelForm = form;

                    
                    panel_forms.Controls.Clear();
                    form.TopLevel = false;
                    panel_forms.Controls.Add(form);

                    form.Dock = DockStyle.Fill;
                    form.BringToFront();
                    form.Show();

                    PanelControlLoad(ControlForm);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void PanelControlLoad(Form form)
        {
            panel_controls.Controls.Clear();
            form.TopLevel = false;

            panel_controls.Controls.Add(form);

            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }

        private void SelectedFormPanel(Button button)
        {
            Panel SidePanel = panel_formselect;
            SidePanel.Location = new Point(SidePanel.Location.X, button.Location.Y);
        }

        private void button_hastanevedoktorlar_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_hastanevedoktorlar);
            PanelFormLoad(new HastanelerDoktorlar(), new HastanelerDoktorlarControl());
        }

        private void button_protez_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_protez);
            PanelFormLoad(new Protezler(), new Protez_Control());
        }

        private void button_talimat_Click(object sender, EventArgs e)
        {
            //SelectedFormPanel(button_raporlar);
        }

        private void button_proses_Click(object sender, EventArgs e)
        {
            //SelectedFormPanel(button_proses);
        }

        private void button_raporlar_Click(object sender, EventArgs e)
        {
            //SelectedFormPanel(button_raporlar);
        }

        private void button_departman_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_departman);
            PanelFormLoad(new Departman(), new DepartmanControl());
        }

        private void button_raporlar_Click_1(object sender, EventArgs e)
        {
            if (!MySetting.isOpenRapor)
            {
                MySetting.FormRapor = new Raporlar();
                MySetting.FormRapor.Show();
                MySetting.isOpenRapor = true;
            } else
            {
                MySetting.FormRapor.WindowState = FormWindowState.Minimized;
                MySetting.FormRapor.WindowState = FormWindowState.Minimized;
                MySetting.FormRapor.WindowState = FormWindowState.Normal;
            }
        }

        private void button_renkyetki_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_renk);
            PanelFormLoad(new YetkiRenk(), new YetkiRenkControl());
        }

        private void button_barkod_Click(object sender, EventArgs e)
        {
            if (!MySetting.isOpenBarkod)
            {
                MySetting.FormBarkod = new Barkod();
                MySetting.FormBarkod.Show();
                MySetting.isOpenBarkod = true;
            } else
            {
                MySetting.FormBarkod.WindowState = FormWindowState.Minimized;
                MySetting.FormBarkod.WindowState = FormWindowState.Minimized;
                MySetting.FormBarkod.WindowState = FormWindowState.Normal;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_malzemeler);
            PanelFormLoad(new Malzemeler(), new MalzemelerControl());
        }

        private void button_prosesler_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_prosesler);
            PanelFormLoad(new Prosesler(), new Proses_Control());
        }

        private void button_talimatlar_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_talimatlar);
            PanelFormLoad(new Talimatlar(), new Talimat_Control());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Oturumu Kapatmak İstediğinize Emin misiniz?", "Oturum Kapatılıyor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.Yes)
            {
                (new Login()).Show();

                if (MySetting.isOpenBarkod)
                    MySetting.FormBarkod.Close();

                this.Close();
            }
        }
        
         private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
