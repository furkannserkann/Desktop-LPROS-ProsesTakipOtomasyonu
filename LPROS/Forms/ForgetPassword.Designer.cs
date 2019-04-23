namespace LPROS.Forms
{
    partial class ForgetPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.PANEL_TEXT_USERNAME = new System.Windows.Forms.Panel();
            this.textbox_kullaniciadi = new System.Windows.Forms.TextBox();
            this.button_sifrebul = new System.Windows.Forms.Button();
            this.panel_cevap = new System.Windows.Forms.Panel();
            this.IMAGELIST_LOGIN = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_head2 = new System.Windows.Forms.Label();
            this.textbox_guvenlikcevap = new System.Windows.Forms.TextBox();
            this.button_kullaniciadi_ara = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label_head1 = new System.Windows.Forms.Label();
            this.label_guvenliksorusu = new System.Windows.Forms.Label();
            this.label_head3 = new System.Windows.Forms.Label();
            this.panel_sifre = new System.Windows.Forms.Panel();
            this.textbox_sifre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel_head.SuspendLayout();
            this.PANEL_TEXT_USERNAME.SuspendLayout();
            this.panel_cevap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel_sifre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_head3);
            this.panel1.Controls.Add(this.panel_sifre);
            this.panel1.Controls.Add(this.label_guvenliksorusu);
            this.panel1.Controls.Add(this.label_head1);
            this.panel1.Controls.Add(this.button_kullaniciadi_ara);
            this.panel1.Controls.Add(this.label_head2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.PANEL_TEXT_USERNAME);
            this.panel1.Controls.Add(this.button_sifrebul);
            this.panel1.Controls.Add(this.panel_cevap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 491);
            this.panel1.TabIndex = 1;
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_minimize);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(369, 30);
            this.panel_head.TabIndex = 26;
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Righteous", 12F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(120, 5);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(129, 21);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Şifremi Unuttum";
            // 
            // PANEL_TEXT_USERNAME
            // 
            this.PANEL_TEXT_USERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.PANEL_TEXT_USERNAME.Controls.Add(this.textbox_kullaniciadi);
            this.PANEL_TEXT_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PANEL_TEXT_USERNAME.Location = new System.Drawing.Point(12, 75);
            this.PANEL_TEXT_USERNAME.Name = "PANEL_TEXT_USERNAME";
            this.PANEL_TEXT_USERNAME.Size = new System.Drawing.Size(290, 46);
            this.PANEL_TEXT_USERNAME.TabIndex = 27;
            this.PANEL_TEXT_USERNAME.Click += new System.EventHandler(this.PANEL_TEXT_USERNAME_Click);
            // 
            // textbox_kullaniciadi
            // 
            this.textbox_kullaniciadi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_kullaniciadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.textbox_kullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_kullaniciadi.Font = new System.Drawing.Font("Righteous", 11F);
            this.textbox_kullaniciadi.ForeColor = System.Drawing.Color.White;
            this.textbox_kullaniciadi.Location = new System.Drawing.Point(10, 14);
            this.textbox_kullaniciadi.Margin = new System.Windows.Forms.Padding(0);
            this.textbox_kullaniciadi.Name = "textbox_kullaniciadi";
            this.textbox_kullaniciadi.Size = new System.Drawing.Size(270, 19);
            this.textbox_kullaniciadi.TabIndex = 0;
            this.textbox_kullaniciadi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_kullaniciadi_KeyDown);
            // 
            // button_sifrebul
            // 
            this.button_sifrebul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_sifrebul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sifrebul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_sifrebul.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_sifrebul.FlatAppearance.BorderSize = 0;
            this.button_sifrebul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sifrebul.Font = new System.Drawing.Font("Righteous", 18F);
            this.button_sifrebul.ForeColor = System.Drawing.Color.White;
            this.button_sifrebul.ImageKey = "add.png";
            this.button_sifrebul.Location = new System.Drawing.Point(0, 440);
            this.button_sifrebul.Name = "button_sifrebul";
            this.button_sifrebul.Size = new System.Drawing.Size(369, 51);
            this.button_sifrebul.TabIndex = 30;
            this.button_sifrebul.Text = "Şifremi Bul";
            this.button_sifrebul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_sifrebul.UseVisualStyleBackColor = false;
            this.button_sifrebul.Click += new System.EventHandler(this.button_sifrebul_Click);
            // 
            // panel_cevap
            // 
            this.panel_cevap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.panel_cevap.Controls.Add(this.textbox_guvenlikcevap);
            this.panel_cevap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel_cevap.Location = new System.Drawing.Point(13, 276);
            this.panel_cevap.Name = "panel_cevap";
            this.panel_cevap.Size = new System.Drawing.Size(339, 46);
            this.panel_cevap.TabIndex = 28;
            this.panel_cevap.Visible = false;
            this.panel_cevap.Click += new System.EventHandler(this.panel_cevap_Click);
            // 
            // IMAGELIST_LOGIN
            // 
            this.IMAGELIST_LOGIN.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMAGELIST_LOGIN.ImageStream")));
            this.IMAGELIST_LOGIN.TransparentColor = System.Drawing.Color.Transparent;
            this.IMAGELIST_LOGIN.Images.SetKeyName(0, "loginhd.png");
            this.IMAGELIST_LOGIN.Images.SetKeyName(1, "passwordhd.png");
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimize.Image")));
            this.pictureBox_minimize.Location = new System.Drawing.Point(303, 0);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_minimize.TabIndex = 1;
            this.pictureBox_minimize.TabStop = false;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(339, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Righteous", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label_head2
            // 
            this.label_head2.AutoSize = true;
            this.label_head2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_head2.Font = new System.Drawing.Font("Righteous", 11F);
            this.label_head2.ForeColor = System.Drawing.Color.White;
            this.label_head2.Location = new System.Drawing.Point(9, 254);
            this.label_head2.Name = "label_head2";
            this.label_head2.Size = new System.Drawing.Size(195, 19);
            this.label_head2.TabIndex = 34;
            this.label_head2.Text = "Güvenlik Sorusunun Cevabı";
            this.label_head2.Visible = false;
            // 
            // textbox_guvenlikcevap
            // 
            this.textbox_guvenlikcevap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_guvenlikcevap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.textbox_guvenlikcevap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_guvenlikcevap.Font = new System.Drawing.Font("Righteous", 11F);
            this.textbox_guvenlikcevap.ForeColor = System.Drawing.Color.White;
            this.textbox_guvenlikcevap.Location = new System.Drawing.Point(10, 14);
            this.textbox_guvenlikcevap.Margin = new System.Windows.Forms.Padding(0);
            this.textbox_guvenlikcevap.Name = "textbox_guvenlikcevap";
            this.textbox_guvenlikcevap.Size = new System.Drawing.Size(319, 19);
            this.textbox_guvenlikcevap.TabIndex = 35;
            this.textbox_guvenlikcevap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button_kullaniciadi_ara
            // 
            this.button_kullaniciadi_ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_kullaniciadi_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kullaniciadi_ara.FlatAppearance.BorderSize = 0;
            this.button_kullaniciadi_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kullaniciadi_ara.Font = new System.Drawing.Font("Righteous", 12F);
            this.button_kullaniciadi_ara.ForeColor = System.Drawing.Color.White;
            this.button_kullaniciadi_ara.ImageKey = "arrow2.png";
            this.button_kullaniciadi_ara.ImageList = this.ımageList1;
            this.button_kullaniciadi_ara.Location = new System.Drawing.Point(308, 75);
            this.button_kullaniciadi_ara.Name = "button_kullaniciadi_ara";
            this.button_kullaniciadi_ara.Size = new System.Drawing.Size(44, 46);
            this.button_kullaniciadi_ara.TabIndex = 106;
            this.button_kullaniciadi_ara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_kullaniciadi_ara.UseVisualStyleBackColor = false;
            this.button_kullaniciadi_ara.Click += new System.EventHandler(this.button_kullaniciadi_ara_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arrow1.png");
            this.ımageList1.Images.SetKeyName(1, "arrow2.png");
            this.ımageList1.Images.SetKeyName(2, "arrow3.png");
            // 
            // label_head1
            // 
            this.label_head1.AutoSize = true;
            this.label_head1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_head1.Font = new System.Drawing.Font("Righteous", 11F);
            this.label_head1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.label_head1.Location = new System.Drawing.Point(12, 139);
            this.label_head1.Name = "label_head1";
            this.label_head1.Size = new System.Drawing.Size(119, 19);
            this.label_head1.TabIndex = 107;
            this.label_head1.Text = "Güvenlik Sorusu";
            this.label_head1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_head1.Visible = false;
            // 
            // label_guvenliksorusu
            // 
            this.label_guvenliksorusu.AutoSize = true;
            this.label_guvenliksorusu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_guvenliksorusu.Font = new System.Drawing.Font("Righteous", 11F);
            this.label_guvenliksorusu.ForeColor = System.Drawing.Color.White;
            this.label_guvenliksorusu.Location = new System.Drawing.Point(12, 161);
            this.label_guvenliksorusu.Name = "label_guvenliksorusu";
            this.label_guvenliksorusu.Size = new System.Drawing.Size(21, 19);
            this.label_guvenliksorusu.TabIndex = 108;
            this.label_guvenliksorusu.Text = "...";
            this.label_guvenliksorusu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_guvenliksorusu.Visible = false;
            // 
            // label_head3
            // 
            this.label_head3.AutoSize = true;
            this.label_head3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_head3.Font = new System.Drawing.Font("Righteous", 11F);
            this.label_head3.ForeColor = System.Drawing.Color.White;
            this.label_head3.Location = new System.Drawing.Point(9, 346);
            this.label_head3.Name = "label_head3";
            this.label_head3.Size = new System.Drawing.Size(61, 19);
            this.label_head3.TabIndex = 110;
            this.label_head3.Text = "Şifreniz";
            this.label_head3.Visible = false;
            // 
            // panel_sifre
            // 
            this.panel_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.panel_sifre.Controls.Add(this.textbox_sifre);
            this.panel_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel_sifre.Location = new System.Drawing.Point(13, 368);
            this.panel_sifre.Name = "panel_sifre";
            this.panel_sifre.Size = new System.Drawing.Size(339, 46);
            this.panel_sifre.TabIndex = 109;
            this.panel_sifre.Visible = false;
            // 
            // textbox_sifre
            // 
            this.textbox_sifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.textbox_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_sifre.Font = new System.Drawing.Font("Righteous", 11F);
            this.textbox_sifre.ForeColor = System.Drawing.Color.White;
            this.textbox_sifre.Location = new System.Drawing.Point(10, 14);
            this.textbox_sifre.Margin = new System.Windows.Forms.Padding(0);
            this.textbox_sifre.Name = "textbox_sifre";
            this.textbox_sifre.Size = new System.Drawing.Size(319, 19);
            this.textbox_sifre.TabIndex = 35;
            this.textbox_sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_sifre_KeyDown);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(369, 491);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.PANEL_TEXT_USERNAME.ResumeLayout(false);
            this.PANEL_TEXT_USERNAME.PerformLayout();
            this.panel_cevap.ResumeLayout(false);
            this.panel_cevap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel_sifre.ResumeLayout(false);
            this.panel_sifre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel PANEL_TEXT_USERNAME;
        private System.Windows.Forms.TextBox textbox_kullaniciadi;
        private System.Windows.Forms.Button button_sifrebul;
        private System.Windows.Forms.Panel panel_cevap;
        private System.Windows.Forms.ImageList IMAGELIST_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_head2;
        private System.Windows.Forms.TextBox textbox_guvenlikcevap;
        private System.Windows.Forms.Button button_kullaniciadi_ara;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label_head1;
        private System.Windows.Forms.Label label_guvenliksorusu;
        private System.Windows.Forms.Label label_head3;
        private System.Windows.Forms.Panel panel_sifre;
        private System.Windows.Forms.TextBox textbox_sifre;
    }
}