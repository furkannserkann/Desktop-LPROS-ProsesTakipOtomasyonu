namespace LPROS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.PANEL_TEXT_USERNAME = new System.Windows.Forms.Panel();
            this.TEXT_USERNAME = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.LABEL_NOT_LOGIN_INFO = new System.Windows.Forms.Label();
            this.PANEL_TEXT_PASSWORD = new System.Windows.Forms.Panel();
            this.TEXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.IMAGELIST_LOGIN = new System.Windows.Forms.ImageList(this.components);
            this.label_sifremiunttum = new System.Windows.Forms.Label();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.IMAGE_USERNAME = new System.Windows.Forms.PictureBox();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.IMAGE_PASSWORD = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_head.SuspendLayout();
            this.PANEL_TEXT_USERNAME.SuspendLayout();
            this.PANEL_TEXT_PASSWORD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_USERNAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_PASSWORD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_sifremiunttum);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.PANEL_TEXT_USERNAME);
            this.panel1.Controls.Add(this.pictureBox_icon);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.LABEL_NOT_LOGIN_INFO);
            this.panel1.Controls.Add(this.PANEL_TEXT_PASSWORD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 363);
            this.panel1.TabIndex = 0;
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
            this.panel_head.Size = new System.Drawing.Size(314, 30);
            this.panel_head.TabIndex = 26;
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Righteous", 12F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(127, 5);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(61, 21);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "LPROS";
            // 
            // PANEL_TEXT_USERNAME
            // 
            this.PANEL_TEXT_USERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.PANEL_TEXT_USERNAME.Controls.Add(this.IMAGE_USERNAME);
            this.PANEL_TEXT_USERNAME.Controls.Add(this.TEXT_USERNAME);
            this.PANEL_TEXT_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PANEL_TEXT_USERNAME.Location = new System.Drawing.Point(12, 140);
            this.PANEL_TEXT_USERNAME.Name = "PANEL_TEXT_USERNAME";
            this.PANEL_TEXT_USERNAME.Size = new System.Drawing.Size(290, 46);
            this.PANEL_TEXT_USERNAME.TabIndex = 27;
            this.PANEL_TEXT_USERNAME.Click += new System.EventHandler(this.PANEL_TEXT_USERNAME_Click);
            // 
            // TEXT_USERNAME
            // 
            this.TEXT_USERNAME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXT_USERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.TEXT_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_USERNAME.Font = new System.Drawing.Font("Righteous", 11F);
            this.TEXT_USERNAME.ForeColor = System.Drawing.Color.White;
            this.TEXT_USERNAME.Location = new System.Drawing.Point(34, 14);
            this.TEXT_USERNAME.Margin = new System.Windows.Forms.Padding(0);
            this.TEXT_USERNAME.Name = "TEXT_USERNAME";
            this.TEXT_USERNAME.Size = new System.Drawing.Size(244, 19);
            this.TEXT_USERNAME.TabIndex = 0;
            this.TEXT_USERNAME.Text = "Kullanıcı Adı";
            this.TEXT_USERNAME.Enter += new System.EventHandler(this.TEXT_USERNAME_Enter);
            this.TEXT_USERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Login_KeyDown);
            this.TEXT_USERNAME.Leave += new System.EventHandler(this.TEXT_USERNAME_Leave);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Righteous", 18F);
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.ImageKey = "add.png";
            this.button_login.Location = new System.Drawing.Point(0, 312);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(314, 51);
            this.button_login.TabIndex = 30;
            this.button_login.Text = "Giriş";
            this.button_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LABEL_NOT_LOGIN_INFO
            // 
            this.LABEL_NOT_LOGIN_INFO.AutoSize = true;
            this.LABEL_NOT_LOGIN_INFO.Font = new System.Drawing.Font("Righteous", 11F);
            this.LABEL_NOT_LOGIN_INFO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.LABEL_NOT_LOGIN_INFO.Location = new System.Drawing.Point(9, 241);
            this.LABEL_NOT_LOGIN_INFO.Name = "LABEL_NOT_LOGIN_INFO";
            this.LABEL_NOT_LOGIN_INFO.Size = new System.Drawing.Size(214, 19);
            this.LABEL_NOT_LOGIN_INFO.TabIndex = 29;
            this.LABEL_NOT_LOGIN_INFO.Text = "Kullanıcı Adı veya Şifre Yanlış";
            this.LABEL_NOT_LOGIN_INFO.Visible = false;
            // 
            // PANEL_TEXT_PASSWORD
            // 
            this.PANEL_TEXT_PASSWORD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.PANEL_TEXT_PASSWORD.Controls.Add(this.IMAGE_PASSWORD);
            this.PANEL_TEXT_PASSWORD.Controls.Add(this.TEXT_PASSWORD);
            this.PANEL_TEXT_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PANEL_TEXT_PASSWORD.Location = new System.Drawing.Point(12, 192);
            this.PANEL_TEXT_PASSWORD.Name = "PANEL_TEXT_PASSWORD";
            this.PANEL_TEXT_PASSWORD.Size = new System.Drawing.Size(290, 46);
            this.PANEL_TEXT_PASSWORD.TabIndex = 28;
            this.PANEL_TEXT_PASSWORD.Click += new System.EventHandler(this.PANEL_TEXT_PASSWORD_Click);
            // 
            // TEXT_PASSWORD
            // 
            this.TEXT_PASSWORD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXT_PASSWORD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.TEXT_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_PASSWORD.Font = new System.Drawing.Font("Righteous", 11F);
            this.TEXT_PASSWORD.ForeColor = System.Drawing.Color.White;
            this.TEXT_PASSWORD.Location = new System.Drawing.Point(34, 14);
            this.TEXT_PASSWORD.Margin = new System.Windows.Forms.Padding(0);
            this.TEXT_PASSWORD.Name = "TEXT_PASSWORD";
            this.TEXT_PASSWORD.Size = new System.Drawing.Size(211, 19);
            this.TEXT_PASSWORD.TabIndex = 2;
            this.TEXT_PASSWORD.Text = "Şifre";
            this.TEXT_PASSWORD.Enter += new System.EventHandler(this.TEXT_PASSWORD_Enter);
            this.TEXT_PASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Login_KeyDown);
            this.TEXT_PASSWORD.Leave += new System.EventHandler(this.TEXT_PASSWORD_Leave);
            // 
            // IMAGELIST_LOGIN
            // 
            this.IMAGELIST_LOGIN.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMAGELIST_LOGIN.ImageStream")));
            this.IMAGELIST_LOGIN.TransparentColor = System.Drawing.Color.Transparent;
            this.IMAGELIST_LOGIN.Images.SetKeyName(0, "loginhd.png");
            this.IMAGELIST_LOGIN.Images.SetKeyName(1, "passwordhd.png");
            // 
            // label_sifremiunttum
            // 
            this.label_sifremiunttum.AutoSize = true;
            this.label_sifremiunttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_sifremiunttum.Font = new System.Drawing.Font("Righteous", 11F);
            this.label_sifremiunttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_sifremiunttum.Location = new System.Drawing.Point(8, 285);
            this.label_sifremiunttum.Name = "label_sifremiunttum";
            this.label_sifremiunttum.Size = new System.Drawing.Size(120, 19);
            this.label_sifremiunttum.TabIndex = 32;
            this.label_sifremiunttum.Text = "Şifremi Unuttum";
            this.label_sifremiunttum.Click += new System.EventHandler(this.label_sifremiunttum_Click);
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimize.Image")));
            this.pictureBox_minimize.Location = new System.Drawing.Point(248, 0);
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
            this.pictureBox_close.Location = new System.Drawing.Point(284, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            // 
            // IMAGE_USERNAME
            // 
            this.IMAGE_USERNAME.Location = new System.Drawing.Point(7, 13);
            this.IMAGE_USERNAME.Name = "IMAGE_USERNAME";
            this.IMAGE_USERNAME.Size = new System.Drawing.Size(20, 20);
            this.IMAGE_USERNAME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMAGE_USERNAME.TabIndex = 2;
            this.IMAGE_USERNAME.TabStop = false;
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_icon.Image")));
            this.pictureBox_icon.Location = new System.Drawing.Point(125, 50);
            this.pictureBox_icon.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(65, 65);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_icon.TabIndex = 31;
            this.pictureBox_icon.TabStop = false;
            // 
            // IMAGE_PASSWORD
            // 
            this.IMAGE_PASSWORD.Location = new System.Drawing.Point(6, 13);
            this.IMAGE_PASSWORD.Name = "IMAGE_PASSWORD";
            this.IMAGE_PASSWORD.Size = new System.Drawing.Size(20, 20);
            this.IMAGE_PASSWORD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMAGE_PASSWORD.TabIndex = 22;
            this.IMAGE_PASSWORD.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(314, 363);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            this.PANEL_TEXT_USERNAME.ResumeLayout(false);
            this.PANEL_TEXT_USERNAME.PerformLayout();
            this.PANEL_TEXT_PASSWORD.ResumeLayout(false);
            this.PANEL_TEXT_PASSWORD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_USERNAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_PASSWORD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel PANEL_TEXT_USERNAME;
        private System.Windows.Forms.PictureBox IMAGE_USERNAME;
        private System.Windows.Forms.TextBox TEXT_USERNAME;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label LABEL_NOT_LOGIN_INFO;
        private System.Windows.Forms.Panel PANEL_TEXT_PASSWORD;
        private System.Windows.Forms.PictureBox IMAGE_PASSWORD;
        private System.Windows.Forms.TextBox TEXT_PASSWORD;
        private System.Windows.Forms.ImageList IMAGELIST_LOGIN;
        private System.Windows.Forms.Label label_sifremiunttum;
    }
}