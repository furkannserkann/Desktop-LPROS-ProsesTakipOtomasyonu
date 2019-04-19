namespace LPROS.Forms_Panel_Control
{
    partial class Protez_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Protez_Control));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_protez_guncelle = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button_protez_sil = new System.Windows.Forms.Button();
            this.button_protez_ekle = new System.Windows.Forms.Button();
            this.button_temizle_isim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_ara_kod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_ara_isim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupBox3.Controls.Add(this.button_protez_guncelle);
            this.groupBox3.Controls.Add(this.button_protez_sil);
            this.groupBox3.Controls.Add(this.button_protez_ekle);
            this.groupBox3.Controls.Add(this.button_temizle_isim);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textbox_ara_kod);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textbox_ara_isim);
            this.groupBox3.Font = new System.Drawing.Font("Righteous", 8F);
            this.groupBox3.Location = new System.Drawing.Point(3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 77);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Protezler";
            // 
            // button_protez_guncelle
            // 
            this.button_protez_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_protez_guncelle.BackColor = System.Drawing.Color.Brown;
            this.button_protez_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_protez_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_protez_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_protez_guncelle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_protez_guncelle.ForeColor = System.Drawing.Color.White;
            this.button_protez_guncelle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_protez_guncelle.ImageKey = "edit.png";
            this.button_protez_guncelle.ImageList = this.ımageList2;
            this.button_protez_guncelle.Location = new System.Drawing.Point(4, 46);
            this.button_protez_guncelle.Name = "button_protez_guncelle";
            this.button_protez_guncelle.Size = new System.Drawing.Size(160, 28);
            this.button_protez_guncelle.TabIndex = 103;
            this.button_protez_guncelle.Text = "   Güncelle";
            this.button_protez_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_protez_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_protez_guncelle.UseVisualStyleBackColor = false;
            this.button_protez_guncelle.Click += new System.EventHandler(this.button_protez_guncelle_Click);
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
            // button_protez_sil
            // 
            this.button_protez_sil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_protez_sil.BackColor = System.Drawing.Color.Brown;
            this.button_protez_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_protez_sil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_protez_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_protez_sil.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_protez_sil.ForeColor = System.Drawing.Color.White;
            this.button_protez_sil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_protez_sil.ImageKey = "delete.png";
            this.button_protez_sil.ImageList = this.ımageList2;
            this.button_protez_sil.Location = new System.Drawing.Point(87, 15);
            this.button_protez_sil.Name = "button_protez_sil";
            this.button_protez_sil.Size = new System.Drawing.Size(77, 28);
            this.button_protez_sil.TabIndex = 102;
            this.button_protez_sil.Text = "   Sil";
            this.button_protez_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_protez_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_protez_sil.UseVisualStyleBackColor = false;
            // 
            // button_protez_ekle
            // 
            this.button_protez_ekle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_protez_ekle.BackColor = System.Drawing.Color.Brown;
            this.button_protez_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_protez_ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_protez_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_protez_ekle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_protez_ekle.ForeColor = System.Drawing.Color.White;
            this.button_protez_ekle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_protez_ekle.ImageKey = "add.png";
            this.button_protez_ekle.ImageList = this.ımageList2;
            this.button_protez_ekle.Location = new System.Drawing.Point(4, 15);
            this.button_protez_ekle.Name = "button_protez_ekle";
            this.button_protez_ekle.Size = new System.Drawing.Size(77, 28);
            this.button_protez_ekle.TabIndex = 101;
            this.button_protez_ekle.Text = "   Ekle";
            this.button_protez_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_protez_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_protez_ekle.UseVisualStyleBackColor = false;
            this.button_protez_ekle.Click += new System.EventHandler(this.button_protez_ekle_Click);
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
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("Righteous", 8F);
            this.groupBox1.Location = new System.Drawing.Point(657, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Talimatlar";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "edit.png";
            this.button2.ImageList = this.ımageList2;
            this.button2.Location = new System.Drawing.Point(198, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 41);
            this.button2.TabIndex = 84;
            this.button2.Text = "   Güncelle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageKey = "delete.png";
            this.button3.ImageList = this.ımageList2;
            this.button3.Location = new System.Drawing.Point(416, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 41);
            this.button3.TabIndex = 78;
            this.button3.Text = "   Sil";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageKey = "add.png";
            this.button4.ImageList = this.ımageList2;
            this.button4.Location = new System.Drawing.Point(6, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 41);
            this.button4.TabIndex = 77;
            this.button4.Text = "   Ekle";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Protez_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 77);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Protez_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protez_Control";
            this.Load += new System.EventHandler(this.Protez_Control_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_protez_guncelle;
        private System.Windows.Forms.Button button_protez_sil;
        private System.Windows.Forms.Button button_protez_ekle;
        private System.Windows.Forms.Button button_temizle_isim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_ara_kod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_ara_isim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList ımageList2;
    }
}