namespace LPROS.Forms
{
    partial class Raporlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_forms = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_renkyetki = new System.Windows.Forms.Button();
            this.button_departman = new System.Windows.Forms.Button();
            this.button_siprais = new System.Windows.Forms.Button();
            this.panel_formselect = new System.Windows.Forms.Panel();
            this.button_protez = new System.Windows.Forms.Button();
            this.button_hastanevedoktorlar = new System.Windows.Forms.Button();
            this.button_personel = new System.Windows.Forms.Button();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel_head.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.pictureBox_minimize);
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1364, 30);
            this.panel_head.TabIndex = 56;
            // 
            // label_head
            // 
            this.label_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_head.Font = new System.Drawing.Font("Orator Std", 15F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(12, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(1280, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Raporlar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel_forms);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 728);
            this.panel1.TabIndex = 58;
            // 
            // panel_forms
            // 
            this.panel_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_forms.Location = new System.Drawing.Point(209, 30);
            this.panel_forms.Name = "panel_forms";
            this.panel_forms.Size = new System.Drawing.Size(1155, 696);
            this.panel_forms.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.button_renkyetki);
            this.panel2.Controls.Add(this.button_departman);
            this.panel2.Controls.Add(this.button_siprais);
            this.panel2.Controls.Add(this.panel_formselect);
            this.panel2.Controls.Add(this.button_protez);
            this.panel2.Controls.Add(this.button_hastanevedoktorlar);
            this.panel2.Controls.Add(this.button_personel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 696);
            this.panel2.TabIndex = 57;
            // 
            // button_renkyetki
            // 
            this.button_renkyetki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_renkyetki.FlatAppearance.BorderSize = 0;
            this.button_renkyetki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_renkyetki.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.button_renkyetki.ForeColor = System.Drawing.Color.White;
            this.button_renkyetki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_renkyetki.ImageIndex = 5;
            this.button_renkyetki.Location = new System.Drawing.Point(9, 276);
            this.button_renkyetki.Name = "button_renkyetki";
            this.button_renkyetki.Size = new System.Drawing.Size(197, 54);
            this.button_renkyetki.TabIndex = 17;
            this.button_renkyetki.Text = "       Yetkiler ve Renkler";
            this.button_renkyetki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_renkyetki.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_renkyetki.UseVisualStyleBackColor = true;
            this.button_renkyetki.Click += new System.EventHandler(this.button_renkyetki_Click);
            // 
            // button_departman
            // 
            this.button_departman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_departman.FlatAppearance.BorderSize = 0;
            this.button_departman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_departman.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.button_departman.ForeColor = System.Drawing.Color.White;
            this.button_departman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_departman.ImageIndex = 4;
            this.button_departman.Location = new System.Drawing.Point(9, 222);
            this.button_departman.Name = "button_departman";
            this.button_departman.Size = new System.Drawing.Size(197, 54);
            this.button_departman.TabIndex = 16;
            this.button_departman.Text = "       Departmanlar";
            this.button_departman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_departman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_departman.UseVisualStyleBackColor = true;
            this.button_departman.Click += new System.EventHandler(this.button_departman_Click);
            // 
            // button_siprais
            // 
            this.button_siprais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_siprais.FlatAppearance.BorderSize = 0;
            this.button_siprais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_siprais.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.button_siprais.ForeColor = System.Drawing.Color.White;
            this.button_siprais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_siprais.ImageIndex = 0;
            this.button_siprais.Location = new System.Drawing.Point(9, 6);
            this.button_siprais.Name = "button_siprais";
            this.button_siprais.Size = new System.Drawing.Size(197, 54);
            this.button_siprais.TabIndex = 11;
            this.button_siprais.Text = "       Siparişler";
            this.button_siprais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_siprais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_siprais.UseVisualStyleBackColor = true;
            this.button_siprais.Click += new System.EventHandler(this.button_siprais_Click);
            // 
            // panel_formselect
            // 
            this.panel_formselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_formselect.Location = new System.Drawing.Point(0, 6);
            this.panel_formselect.Name = "panel_formselect";
            this.panel_formselect.Size = new System.Drawing.Size(9, 54);
            this.panel_formselect.TabIndex = 9;
            // 
            // button_protez
            // 
            this.button_protez.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_protez.FlatAppearance.BorderSize = 0;
            this.button_protez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_protez.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.button_protez.ForeColor = System.Drawing.Color.White;
            this.button_protez.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_protez.ImageIndex = 3;
            this.button_protez.Location = new System.Drawing.Point(9, 168);
            this.button_protez.Name = "button_protez";
            this.button_protez.Size = new System.Drawing.Size(197, 54);
            this.button_protez.TabIndex = 8;
            this.button_protez.Text = "       Protezler - Talimatlar\r\n       Prosesler";
            this.button_protez.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_protez.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_protez.UseVisualStyleBackColor = true;
            this.button_protez.Click += new System.EventHandler(this.button_protez_Click);
            // 
            // button_hastanevedoktorlar
            // 
            this.button_hastanevedoktorlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hastanevedoktorlar.FlatAppearance.BorderSize = 0;
            this.button_hastanevedoktorlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hastanevedoktorlar.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.button_hastanevedoktorlar.ForeColor = System.Drawing.Color.White;
            this.button_hastanevedoktorlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hastanevedoktorlar.ImageIndex = 2;
            this.button_hastanevedoktorlar.Location = new System.Drawing.Point(9, 114);
            this.button_hastanevedoktorlar.Name = "button_hastanevedoktorlar";
            this.button_hastanevedoktorlar.Size = new System.Drawing.Size(197, 54);
            this.button_hastanevedoktorlar.TabIndex = 9;
            this.button_hastanevedoktorlar.Text = "       Hastaneler ve     \r\n       Doktorlar";
            this.button_hastanevedoktorlar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hastanevedoktorlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_hastanevedoktorlar.UseVisualStyleBackColor = true;
            this.button_hastanevedoktorlar.Click += new System.EventHandler(this.button_hastanevedoktorlar_Click);
            // 
            // button_personel
            // 
            this.button_personel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_personel.FlatAppearance.BorderSize = 0;
            this.button_personel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_personel.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.button_personel.ForeColor = System.Drawing.Color.White;
            this.button_personel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_personel.ImageIndex = 1;
            this.button_personel.Location = new System.Drawing.Point(9, 60);
            this.button_personel.Name = "button_personel";
            this.button_personel.Size = new System.Drawing.Size(197, 54);
            this.button_personel.TabIndex = 10;
            this.button_personel.Text = "       Personeller";
            this.button_personel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_personel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_personel.UseVisualStyleBackColor = true;
            this.button_personel.Click += new System.EventHandler(this.button_personel_Click);
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimize.Image")));
            this.pictureBox_minimize.Location = new System.Drawing.Point(1298, 0);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Padding = new System.Windows.Forms.Padding(7, 10, 7, 0);
            this.pictureBox_minimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_minimize.TabIndex = 17;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(1334, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Raporlar_FormClosed);
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.panel_head.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_renkyetki;
        private System.Windows.Forms.Button button_departman;
        private System.Windows.Forms.Button button_siprais;
        private System.Windows.Forms.Panel panel_formselect;
        private System.Windows.Forms.Button button_protez;
        private System.Windows.Forms.Button button_hastanevedoktorlar;
        private System.Windows.Forms.Button button_personel;
        private System.Windows.Forms.Panel panel_forms;
    }
}