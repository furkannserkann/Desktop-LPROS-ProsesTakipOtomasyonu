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
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.PANEL_TEXT_USERNAME = new System.Windows.Forms.Panel();
            this.IMAGE_USERNAME = new System.Windows.Forms.PictureBox();
            this.TEXT_USERNAME = new System.Windows.Forms.TextBox();
            this.IMAGE_PASSWORD = new System.Windows.Forms.PictureBox();
            this.TEXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.PANEL_TEXT_PASSWORD = new System.Windows.Forms.Panel();
            this.LABEL_NOT_LOGIN_INFO = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.IMAGELIST_LOGIN = new System.Windows.Forms.ImageList(this.components);
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.PANEL_TEXT_USERNAME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_USERNAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_PASSWORD)).BeginInit();
            this.PANEL_TEXT_PASSWORD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            this.SuspendLayout();
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
            this.panel_head.TabIndex = 0;
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Orator Std", 15F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(121, 1);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(72, 27);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "LPROS";
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
            // PANEL_TEXT_USERNAME
            // 
            this.PANEL_TEXT_USERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.PANEL_TEXT_USERNAME.Controls.Add(this.IMAGE_USERNAME);
            this.PANEL_TEXT_USERNAME.Controls.Add(this.TEXT_USERNAME);
            this.PANEL_TEXT_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PANEL_TEXT_USERNAME.Location = new System.Drawing.Point(12, 140);
            this.PANEL_TEXT_USERNAME.Name = "PANEL_TEXT_USERNAME";
            this.PANEL_TEXT_USERNAME.Size = new System.Drawing.Size(290, 46);
            this.PANEL_TEXT_USERNAME.TabIndex = 21;
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
            // TEXT_USERNAME
            // 
            this.TEXT_USERNAME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXT_USERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.TEXT_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.TEXT_USERNAME.ForeColor = System.Drawing.Color.White;
            this.TEXT_USERNAME.Location = new System.Drawing.Point(34, 14);
            this.TEXT_USERNAME.Margin = new System.Windows.Forms.Padding(0);
            this.TEXT_USERNAME.Name = "TEXT_USERNAME";
            this.TEXT_USERNAME.Size = new System.Drawing.Size(244, 17);
            this.TEXT_USERNAME.TabIndex = 0;
            this.TEXT_USERNAME.Text = "Kullanıcı Adı";
            this.TEXT_USERNAME.Enter += new System.EventHandler(this.TEXT_USERNAME_Enter);
            this.TEXT_USERNAME.Leave += new System.EventHandler(this.TEXT_USERNAME_Leave);
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
            // TEXT_PASSWORD
            // 
            this.TEXT_PASSWORD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXT_PASSWORD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.TEXT_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.TEXT_PASSWORD.ForeColor = System.Drawing.Color.White;
            this.TEXT_PASSWORD.Location = new System.Drawing.Point(34, 14);
            this.TEXT_PASSWORD.Margin = new System.Windows.Forms.Padding(0);
            this.TEXT_PASSWORD.Name = "TEXT_PASSWORD";
            this.TEXT_PASSWORD.Size = new System.Drawing.Size(211, 17);
            this.TEXT_PASSWORD.TabIndex = 2;
            this.TEXT_PASSWORD.Text = "Şifre";
            this.TEXT_PASSWORD.Enter += new System.EventHandler(this.TEXT_PASSWORD_Enter);
            this.TEXT_PASSWORD.Leave += new System.EventHandler(this.TEXT_PASSWORD_Leave);
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
            this.PANEL_TEXT_PASSWORD.TabIndex = 22;
            // 
            // LABEL_NOT_LOGIN_INFO
            // 
            this.LABEL_NOT_LOGIN_INFO.AutoSize = true;
            this.LABEL_NOT_LOGIN_INFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LABEL_NOT_LOGIN_INFO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.LABEL_NOT_LOGIN_INFO.Location = new System.Drawing.Point(9, 241);
            this.LABEL_NOT_LOGIN_INFO.Name = "LABEL_NOT_LOGIN_INFO";
            this.LABEL_NOT_LOGIN_INFO.Size = new System.Drawing.Size(197, 18);
            this.LABEL_NOT_LOGIN_INFO.TabIndex = 23;
            this.LABEL_NOT_LOGIN_INFO.Text = "Kullanıcı Adı veya Şifre Yanlış";
            this.LABEL_NOT_LOGIN_INFO.Visible = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.ImageKey = "add.png";
            this.button_login.Location = new System.Drawing.Point(0, 285);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(314, 51);
            this.button_login.TabIndex = 24;
            this.button_login.Text = "Giriş";
            this.button_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_icon.Image")));
            this.pictureBox_icon.Location = new System.Drawing.Point(120, 50);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_icon.TabIndex = 25;
            this.pictureBox_icon.TabStop = false;
            // 
            // IMAGELIST_LOGIN
            // 
            this.IMAGELIST_LOGIN.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IMAGELIST_LOGIN.ImageStream")));
            this.IMAGELIST_LOGIN.TransparentColor = System.Drawing.Color.Transparent;
            this.IMAGELIST_LOGIN.Images.SetKeyName(0, "loginhd.png");
            this.IMAGELIST_LOGIN.Images.SetKeyName(1, "passwordhd.png");
            // 
            // Login
            // 
            this.AcceptButton = this.button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(314, 336);
            this.Controls.Add(this.pictureBox_icon);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.LABEL_NOT_LOGIN_INFO);
            this.Controls.Add(this.PANEL_TEXT_USERNAME);
            this.Controls.Add(this.panel_head);
            this.Controls.Add(this.PANEL_TEXT_PASSWORD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.PANEL_TEXT_USERNAME.ResumeLayout(false);
            this.PANEL_TEXT_USERNAME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_USERNAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_PASSWORD)).EndInit();
            this.PANEL_TEXT_PASSWORD.ResumeLayout(false);
            this.PANEL_TEXT_PASSWORD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel PANEL_TEXT_USERNAME;
        private System.Windows.Forms.PictureBox IMAGE_USERNAME;
        private System.Windows.Forms.TextBox TEXT_USERNAME;
        private System.Windows.Forms.PictureBox IMAGE_PASSWORD;
        private System.Windows.Forms.TextBox TEXT_PASSWORD;
        private System.Windows.Forms.Panel PANEL_TEXT_PASSWORD;
        private System.Windows.Forms.Label LABEL_NOT_LOGIN_INFO;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBox_icon;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.ImageList IMAGELIST_LOGIN;
    }
}