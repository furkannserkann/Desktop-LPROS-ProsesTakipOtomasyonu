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

namespace LPROS.Forms.Table.Search
{
    public partial class Search_Siparis : Form
    {
        public Search_Siparis()
        {
            InitializeComponent();
        }

        private void Search_Siparis_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);
        }

        private void checkBox_siparis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_siparis.Checked)
            {
                datetimepicker_siparisbitis.Enabled = true;
                checkbox_siparistarihibaslangic.Text = "Sipariş Tarihi Başlangıç";
                checkMinMaxDate();
            } else
            {
                datetimepicker_siparisbitis.Enabled = false;
                checkbox_siparistarihibaslangic.Text = "Sipariş Tarihi";
            }
        }

        private void checkBox_teslimat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_teslimat.Checked)
            {
                datetimepicker_teslimatbitis.Enabled = true;
                checkbox_teslimattarihibaslangic.Text = "Teslimat Tarihi Başlangıç";
                checkMinMaxDate();
            }
            else
            {
                datetimepicker_teslimatbitis.Enabled = false;
                checkbox_teslimattarihibaslangic.Text = "Teslimat Tarihi";
            }
        }

        private void datetimepicker_siparisbaslangic_ValueChanged(object sender, EventArgs e)
        {
            checkMinMaxDate();
        }

        private void datetimepicker_teslimatbaslangic_ValueChanged(object sender, EventArgs e)
        {
            checkMinMaxDate();
        }

        private void checkMinMaxDate()
        {
            if (checkBox_siparis.Checked)
            {
                datetimepicker_siparisbitis.MinDate = datetimepicker_siparisbaslangic.Value;
            }

            if (checkBox_teslimat.Checked)
            {
                datetimepicker_teslimatbitis.MinDate = datetimepicker_teslimatbaslangic.Value;
            }
        }

        private void checkbox_maliyet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_maliyet.Checked)
            {
                checkbox_maliyet_arasinda.Enabled = true;
            }
            else
            {
                checkbox_maliyet_arasinda.Enabled = false;
                checkbox_maliyet_arasinda.Checked = false;
            }
        }
    }
}
