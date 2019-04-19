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
    public partial class CustomMessageDialog : Form
    {
        public CustomMessageDialog()
        {
            InitializeComponent();
        }

        public String BaslikForm = "Dikkat";
        public String BaslikMesaj = "Hata";
        public String Mesaj = "Bir Sorun İle Karşılaşıldı";

        public String Button1_Text = "İptal Et";
        public String Button2_Text = "Onayla";

        private void MessageDialog_Load(object sender, EventArgs e)
        {
            label_head.Text = BaslikForm;
            label_baslık.Text = BaslikMesaj;
            label_mesaj.Text = Mesaj;

            button_iptal.Text = Button1_Text;
            button_onayla.Text = Button2_Text;


            // Formu Sürükleme
            panel_head.MouseDown += PICTURE_HEAD_BACKGROUND_MouseDown;
            panel_head.MouseUp += PICTURE_HEAD_BACKGROUND_MouseUp;
            panel_head.MouseMove += PICTURE_HEAD_BACKGROUND_MouseMove;

            label_head.MouseDown += PICTURE_HEAD_BACKGROUND_MouseDown;
            label_head.MouseUp += PICTURE_HEAD_BACKGROUND_MouseUp;
            label_head.MouseMove += PICTURE_HEAD_BACKGROUND_MouseMove;
        }

        private bool DRAGGİNG;
        private Point OFFSET;
        private void PICTURE_HEAD_BACKGROUND_MouseDown(object sender, MouseEventArgs e)
        {
            DRAGGİNG = true;
            OFFSET = e.Location;
        }

        private void PICTURE_HEAD_BACKGROUND_MouseUp(object sender, MouseEventArgs e)
        {
            DRAGGİNG = false;
        }

        private void PICTURE_HEAD_BACKGROUND_MouseMove(object sender, MouseEventArgs e)
        {
            if (DRAGGİNG)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - OFFSET.X, currentScreenPos.Y - OFFSET.Y);
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void İptalEt()
        {
            this.Close();
        }

        public virtual void Onayla()
        {
            MessageBox.Show("İşlem Reddedildi!");
        }

        private void button_onayla_Click(object sender, EventArgs e)
        {
            Onayla();
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            İptalEt();
        }
    }
}
