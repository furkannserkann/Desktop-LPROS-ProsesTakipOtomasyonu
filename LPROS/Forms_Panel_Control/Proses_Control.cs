﻿using LPROS.Forms.Table.Add;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms_Panel_Control
{
    public partial class Proses_Control : Form
    {
        public Proses_Control()
        {
            InitializeComponent();
        }

        private void Proses_Control_Load(object sender, EventArgs e)
        {
            groupBox1.Paint += PaintBorderlessGroupBox1;
            groupBox3.Paint += PaintBorderlessGroupBox1;
        }

        private void PaintBorderlessGroupBox1(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 80, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void button_proses_ekle_Click(object sender, EventArgs e)
        {
            Add_Proses addProses = new Add_Proses()
            {
                isUpdate = false
            };
            addProses.ShowDialog();
        }

        private void button_proses_guncelle_Click(object sender, EventArgs e)
        {
            Add_Proses addProses = new Add_Proses()
            {
                isUpdate = true
            };
            addProses.ShowDialog();
        }
    }
}
