using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Custom
{
    class FormTasima
    {

        Form form;
        Panel panel_head;
        Label label_head;
        PictureBox Exit, Minimize;

        public FormTasima(Panel panel_head, Label label_head, Form form)
        {
            this.form = form;
            this.panel_head = panel_head;
            this.label_head = label_head;

            load();
        }

        public FormTasima(Panel panel_head, Label label_head, Form form, PictureBox Exit)
        {
            this.form = form;
            this.panel_head = panel_head;
            this.label_head = label_head;

            this.Exit = Exit;
            this.Exit.MouseDown += EXIT_CLICK;

            load();
        }


        public FormTasima(Panel panel_head, Label label_head, Form form, PictureBox Exit, PictureBox Minimize)
        {
            this.form = form;
            this.panel_head = panel_head;
            this.label_head = label_head;

            this.Exit = Exit;
            this.Exit.MouseDown += EXIT_CLICK;
            this.Minimize = Minimize;
            this.Minimize.MouseDown += MINIMIZE_CLICK;

            load();
        }

        private void load()
        {
            panel_head.MouseDown += PICTURE_HEAD_BACKGROUND_MouseDown;
            panel_head.MouseUp += PICTURE_HEAD_BACKGROUND_MouseUp;
            panel_head.MouseMove += PICTURE_HEAD_BACKGROUND_MouseMove;

            label_head.MouseDown += PICTURE_HEAD_BACKGROUND_MouseDown;
            label_head.MouseUp += PICTURE_HEAD_BACKGROUND_MouseUp;
            label_head.MouseMove += PICTURE_HEAD_BACKGROUND_MouseMove;
        }

        private bool DRAGGİNG;
        private System.Drawing.Point OFFSET;
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
                Point currentScreenPos = form.PointToScreen(e.Location);
                form.Location = new System.Drawing.Point(currentScreenPos.X - OFFSET.X, currentScreenPos.Y - OFFSET.Y);
            }
        }

        private void EXIT_CLICK(object sender, MouseEventArgs e)
        {
            form.Close();
        }

        private void MINIMIZE_CLICK(object sender, MouseEventArgs e)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
