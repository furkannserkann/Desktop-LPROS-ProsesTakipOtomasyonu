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

        private void button_ara_Click(object sender, EventArgs e)
        {
            //string queryCustom = "";
            //string[] constArray = new string[] {};

            //if (checkbox_siparistarihibaslangic.Checked)
            //{
            //    if (checkbox_siparisarasinda.Checked)
            //    {
            //        queryCustom = " and convert(DATE, s.siparis_tarihi) between @parametre" + parametreSirasi + " and @parametre" + (parametreSirasi + 1) + " ";
            //        constArray = stringArrayBirlestir(constArray, new string[] { SSiparisTarihiBaslangic.ToString("yyyy/MM/dd"), SSiparisTarihiBitis.ToString("yyyy/MM/dd") });

            //        parametreSirasi += 2;
            //    }
            //    else
            //    {
            //        queryCustom = " and sconvert(DATE, s.siparis_tarihi)=@parametre" + parametreSirasi + " ";
            //        constArray = stringArrayBirlestir(constArray, new string[] { SSiparisTarihiBaslangic.ToString("yyyy/MM/dd") });

            //        parametreSirasi += 1;
            //    }
            //}
        }
    }
}
