namespace LPROS.Forms_Panel_Control
{
    partial class PersonelController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelController));
            this.button_arama = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_soyisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.button_düzenle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.Combo_durumu = new System.Windows.Forms.ComboBox();
            this.Combo_yetki = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_arama
            // 
            this.button_arama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_arama.BackColor = System.Drawing.Color.Brown;
            this.button_arama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_arama.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_arama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_arama.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_arama.ForeColor = System.Drawing.Color.White;
            this.button_arama.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_arama.ImageKey = "search.png";
            this.button_arama.ImageList = this.ımageList2;
            this.button_arama.Location = new System.Drawing.Point(95, 42);
            this.button_arama.Name = "button_arama";
            this.button_arama.Size = new System.Drawing.Size(145, 28);
            this.button_arama.TabIndex = 105;
            this.button_arama.Text = "  Detaylı Arama";
            this.button_arama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_arama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_arama.UseVisualStyleBackColor = false;
            this.button_arama.Click += new System.EventHandler(this.button_arama_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label4.Location = new System.Drawing.Point(849, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 115;
            this.label4.Text = "Yetki:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label5.Location = new System.Drawing.Point(655, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 113;
            this.label5.Text = "Durum:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Righteous", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.ImageKey = "clear.png";
            this.button3.ImageList = this.ımageList2;
            this.button3.Location = new System.Drawing.Point(1023, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 28);
            this.button3.TabIndex = 111;
            this.button3.Text = "  Temizle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Righteous", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.ImageKey = "search.png";
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(1023, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 110;
            this.button1.Text = "  Ara";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label2.Location = new System.Drawing.Point(461, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "Soyadı:";
            // 
            // textBox_soyisim
            // 
            this.textBox_soyisim.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.textBox_soyisim.ForeColor = System.Drawing.Color.Black;
            this.textBox_soyisim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_soyisim.Location = new System.Drawing.Point(464, 31);
            this.textBox_soyisim.Name = "textBox_soyisim";
            this.textBox_soyisim.Size = new System.Drawing.Size(131, 25);
            this.textBox_soyisim.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label1.Location = new System.Drawing.Point(267, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 107;
            this.label1.Text = "Adı:";
            // 
            // textBox_isim
            // 
            this.textBox_isim.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.textBox_isim.ForeColor = System.Drawing.Color.Black;
            this.textBox_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_isim.Location = new System.Drawing.Point(270, 31);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(131, 25);
            this.textBox_isim.TabIndex = 106;
            // 
            // button_düzenle
            // 
            this.button_düzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_düzenle.BackColor = System.Drawing.Color.Brown;
            this.button_düzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_düzenle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_düzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_düzenle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_düzenle.ForeColor = System.Drawing.Color.White;
            this.button_düzenle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_düzenle.ImageKey = "edit.png";
            this.button_düzenle.ImageList = this.ımageList2;
            this.button_düzenle.Location = new System.Drawing.Point(95, 8);
            this.button_düzenle.Name = "button_düzenle";
            this.button_düzenle.Size = new System.Drawing.Size(145, 28);
            this.button_düzenle.TabIndex = 104;
            this.button_düzenle.Text = "  Düzenle";
            this.button_düzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_düzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_düzenle.UseVisualStyleBackColor = false;
            this.button_düzenle.Click += new System.EventHandler(this.button_düzenle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sil.BackColor = System.Drawing.Color.Brown;
            this.button_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sil.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_sil.ForeColor = System.Drawing.Color.White;
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_sil.ImageKey = "delete.png";
            this.button_sil.ImageList = this.ımageList2;
            this.button_sil.Location = new System.Drawing.Point(12, 42);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(77, 28);
            this.button_sil.TabIndex = 103;
            this.button_sil.Text = " Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click_1);
            // 
            // button_ekle
            // 
            this.button_ekle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ekle.BackColor = System.Drawing.Color.Brown;
            this.button_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ekle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_ekle.ForeColor = System.Drawing.Color.White;
            this.button_ekle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ekle.ImageKey = "add.png";
            this.button_ekle.ImageList = this.ımageList2;
            this.button_ekle.Location = new System.Drawing.Point(12, 8);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(77, 28);
            this.button_ekle.TabIndex = 102;
            this.button_ekle.Text = " Ekle";
            this.button_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // Combo_durumu
            // 
            this.Combo_durumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_durumu.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.Combo_durumu.FormattingEnabled = true;
            this.Combo_durumu.Items.AddRange(new object[] {
            "",
            "Aktif",
            "Pasif"});
            this.Combo_durumu.Location = new System.Drawing.Point(658, 31);
            this.Combo_durumu.Name = "Combo_durumu";
            this.Combo_durumu.Size = new System.Drawing.Size(141, 28);
            this.Combo_durumu.TabIndex = 189;
            // 
            // Combo_yetki
            // 
            this.Combo_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_yetki.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.Combo_yetki.FormattingEnabled = true;
            this.Combo_yetki.Items.AddRange(new object[] {
            ""});
            this.Combo_yetki.Location = new System.Drawing.Point(852, 31);
            this.Combo_yetki.Name = "Combo_yetki";
            this.Combo_yetki.Size = new System.Drawing.Size(141, 28);
            this.Combo_yetki.TabIndex = 188;
            // 
            // PersonelController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 77);
            this.Controls.Add(this.Combo_durumu);
            this.Controls.Add(this.Combo_yetki);
            this.Controls.Add(this.button_arama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_soyisim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_isim);
            this.Controls.Add(this.button_düzenle);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelController";
            this.Load += new System.EventHandler(this.PersonelController_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_arama;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_soyisim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.Button button_düzenle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ComboBox Combo_durumu;
        private System.Windows.Forms.ComboBox Combo_yetki;
    }
}