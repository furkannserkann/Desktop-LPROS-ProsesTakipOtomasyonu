﻿namespace LPROS.Forms_Panel_Control
{
    partial class Proses_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proses_Control));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_proses_guncelle = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button_proses_sil = new System.Windows.Forms.Button();
            this.button_proses_ekle = new System.Windows.Forms.Button();
            this.button_temizle_isim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_ara_kod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_ara_isim = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-plus-math-90.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-delete-90.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-pencil-96.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-search-more-90.png");
            this.ımageList1.Images.SetKeyName(4, "icons8-search-208.png");
            this.ımageList1.Images.SetKeyName(5, "icons8-broom-96.png");
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.button_proses_guncelle);
            this.groupBox3.Controls.Add(this.button_proses_sil);
            this.groupBox3.Controls.Add(this.button_proses_ekle);
            this.groupBox3.Controls.Add(this.button_temizle_isim);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textbox_ara_kod);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textbox_ara_isim);
            this.groupBox3.Font = new System.Drawing.Font("Righteous", 8F);
            this.groupBox3.Location = new System.Drawing.Point(3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 77);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Prosesler";
            // 
            // button_proses_guncelle
            // 
            this.button_proses_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_proses_guncelle.BackColor = System.Drawing.Color.Brown;
            this.button_proses_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_proses_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_proses_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_proses_guncelle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_proses_guncelle.ForeColor = System.Drawing.Color.White;
            this.button_proses_guncelle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_proses_guncelle.ImageKey = "edit.png";
            this.button_proses_guncelle.ImageList = this.ımageList2;
            this.button_proses_guncelle.Location = new System.Drawing.Point(4, 46);
            this.button_proses_guncelle.Name = "button_proses_guncelle";
            this.button_proses_guncelle.Size = new System.Drawing.Size(160, 28);
            this.button_proses_guncelle.TabIndex = 103;
            this.button_proses_guncelle.Text = "   Güncelle";
            this.button_proses_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_proses_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_proses_guncelle.UseVisualStyleBackColor = false;
            this.button_proses_guncelle.Click += new System.EventHandler(this.button_proses_guncelle_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "add.png");
            this.ımageList2.Images.SetKeyName(1, "edit.png");
            this.ımageList2.Images.SetKeyName(2, "clear.png");
            this.ımageList2.Images.SetKeyName(3, "delete.png");
            this.ımageList2.Images.SetKeyName(4, "search.png");
            this.ımageList2.Images.SetKeyName(5, "icons8-broom-96.png");
            this.ımageList2.Images.SetKeyName(6, "icons8-search-208.png");
            this.ımageList2.Images.SetKeyName(7, "icons8-plus-math-90.png");
            this.ımageList2.Images.SetKeyName(8, "icons8-search-more-90.png");
            this.ımageList2.Images.SetKeyName(9, "icons8-delete-90.png");
            this.ımageList2.Images.SetKeyName(10, "icons8-pencil-96.png");
            // 
            // button_proses_sil
            // 
            this.button_proses_sil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_proses_sil.BackColor = System.Drawing.Color.Brown;
            this.button_proses_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_proses_sil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_proses_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_proses_sil.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_proses_sil.ForeColor = System.Drawing.Color.White;
            this.button_proses_sil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_proses_sil.ImageKey = "delete.png";
            this.button_proses_sil.ImageList = this.ımageList2;
            this.button_proses_sil.Location = new System.Drawing.Point(87, 15);
            this.button_proses_sil.Name = "button_proses_sil";
            this.button_proses_sil.Size = new System.Drawing.Size(77, 28);
            this.button_proses_sil.TabIndex = 102;
            this.button_proses_sil.Text = "   Sil";
            this.button_proses_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_proses_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_proses_sil.UseVisualStyleBackColor = false;
            this.button_proses_sil.Click += new System.EventHandler(this.button_proses_sil_Click);
            // 
            // button_proses_ekle
            // 
            this.button_proses_ekle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_proses_ekle.BackColor = System.Drawing.Color.Brown;
            this.button_proses_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_proses_ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_proses_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_proses_ekle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_proses_ekle.ForeColor = System.Drawing.Color.White;
            this.button_proses_ekle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_proses_ekle.ImageKey = "add.png";
            this.button_proses_ekle.ImageList = this.ımageList2;
            this.button_proses_ekle.Location = new System.Drawing.Point(4, 15);
            this.button_proses_ekle.Name = "button_proses_ekle";
            this.button_proses_ekle.Size = new System.Drawing.Size(77, 28);
            this.button_proses_ekle.TabIndex = 101;
            this.button_proses_ekle.Text = "   Ekle";
            this.button_proses_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_proses_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_proses_ekle.UseVisualStyleBackColor = false;
            this.button_proses_ekle.Click += new System.EventHandler(this.button_proses_ekle_Click);
            // 
            // button_temizle_isim
            // 
            this.button_temizle_isim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_temizle_isim.BackColor = System.Drawing.Color.Brown;
            this.button_temizle_isim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_temizle_isim.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_temizle_isim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_temizle_isim.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.button_temizle_isim.ForeColor = System.Drawing.Color.White;
            this.button_temizle_isim.ImageKey = "clear.png";
            this.button_temizle_isim.ImageList = this.ımageList2;
            this.button_temizle_isim.Location = new System.Drawing.Point(474, 39);
            this.button_temizle_isim.Name = "button_temizle_isim";
            this.button_temizle_isim.Size = new System.Drawing.Size(30, 25);
            this.button_temizle_isim.TabIndex = 90;
            this.button_temizle_isim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_temizle_isim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_temizle_isim.UseVisualStyleBackColor = false;
            this.button_temizle_isim.Click += new System.EventHandler(this.button_temizle_isim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label3.Location = new System.Drawing.Point(215, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 89;
            this.label3.Text = "Kod";
            // 
            // textbox_ara_kod
            // 
            this.textbox_ara_kod.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.textbox_ara_kod.ForeColor = System.Drawing.Color.Black;
            this.textbox_ara_kod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_ara_kod.Location = new System.Drawing.Point(218, 39);
            this.textbox_ara_kod.Name = "textbox_ara_kod";
            this.textbox_ara_kod.Size = new System.Drawing.Size(73, 25);
            this.textbox_ara_kod.TabIndex = 88;
            this.textbox_ara_kod.TextChanged += new System.EventHandler(this.textbox_ara_kod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label2.Location = new System.Drawing.Point(334, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "İsim";
            // 
            // textbox_ara_isim
            // 
            this.textbox_ara_isim.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.textbox_ara_isim.ForeColor = System.Drawing.Color.Black;
            this.textbox_ara_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_ara_isim.Location = new System.Drawing.Point(337, 39);
            this.textbox_ara_isim.Name = "textbox_ara_isim";
            this.textbox_ara_isim.Size = new System.Drawing.Size(131, 25);
            this.textbox_ara_isim.TabIndex = 85;
            this.textbox_ara_isim.TextChanged += new System.EventHandler(this.textbox_ara_kod_TextChanged);
            // 
            // Proses_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 77);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proses_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proses_Control";
            this.Load += new System.EventHandler(this.Proses_Control_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_temizle_isim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_ara_kod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_ara_isim;
        private System.Windows.Forms.Button button_proses_guncelle;
        private System.Windows.Forms.Button button_proses_sil;
        private System.Windows.Forms.Button button_proses_ekle;
        private System.Windows.Forms.ImageList ımageList2;
    }
}