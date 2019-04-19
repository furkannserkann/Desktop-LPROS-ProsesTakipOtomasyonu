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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            //new FormTasima(panel_head, label_head, this, pictureBox_close);
            PanelFormLoad(new Reports.RaporSiparis());
        }

        private void Raporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySetting.isOpenRapor = false;
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form LastOpenPanelForm;
        private void PanelFormLoad(Form form)
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
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void button_personel_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_personel);
            PanelFormLoad(new Reports.RaporPersonel());
        }

        private void button_siprais_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_siprais);
            PanelFormLoad(new Reports.RaporSiparis());
        }

        private void button_hastanevedoktorlar_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_hastanevedoktorlar);
            PanelFormLoad(new Reports.RaporHastaneDoktor());
        }

        private void button_protez_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_protez);
            PanelFormLoad(new Reports.RaporProtezTalimatProses());
        }

        private void button_departman_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_departman);
            PanelFormLoad(new Reports.RaporDepartman());
        }

        private void button_renkyetki_Click(object sender, EventArgs e)
        {
            SelectedFormPanel(button_renkyetki);
            PanelFormLoad(new Reports.RaporYetkiRenk());
        }

        private void SelectedFormPanel(Button button)
        {
            Panel SidePanel = panel_formselect;
            SidePanel.Location = new Point(SidePanel.Location.X, button.Location.Y);
        }
    }
}
