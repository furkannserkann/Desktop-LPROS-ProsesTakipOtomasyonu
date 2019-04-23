namespace LPROS.ControlPanelForms
{
    partial class SiparisControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisControl));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_temizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_ara = new System.Windows.Forms.Button();
            this.datepicker_teslimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_arahasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_arama = new System.Windows.Forms.Button();
            this.button_düzenle = new System.Windows.Forms.Button();
            this.textbox_arafisno = new System.Windows.Forms.TextBox();
            this.datepicker_siparistarihi = new System.Windows.Forms.DateTimePicker();
            this.button_ekle = new System.Windows.Forms.Button();
            this.checkbox_siparistarihi = new System.Windows.Forms.CheckBox();
            this.checkbox_teslimattarihi = new System.Windows.Forms.CheckBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.combobox_proteztipi = new System.Windows.Forms.ComboBox();
            this.combobox_renk = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 9F);
            this.label4.Location = new System.Drawing.Point(762, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 141;
            this.label4.Text = "Renk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 9F);
            this.label5.Location = new System.Drawing.Point(762, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 139;
            this.label5.Text = "Protez Tipi:";
            // 
            // button_temizle
            // 
            this.button_temizle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_temizle.BackColor = System.Drawing.Color.Brown;
            this.button_temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_temizle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_temizle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_temizle.ForeColor = System.Drawing.Color.White;
            this.button_temizle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_temizle.ImageKey = "clear.png";
            this.button_temizle.ImageList = this.ımageList1;
            this.button_temizle.Location = new System.Drawing.Point(1045, 40);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(93, 28);
            this.button_temizle.TabIndex = 137;
            this.button_temizle.Text = "  Temizle";
            this.button_temizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_temizle.UseVisualStyleBackColor = false;
            this.button_temizle.Click += new System.EventHandler(this.button_temizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "edit.png");
            this.ımageList1.Images.SetKeyName(2, "clear.png");
            this.ımageList1.Images.SetKeyName(3, "delete.png");
            this.ımageList1.Images.SetKeyName(4, "search.png");
            this.ımageList1.Images.SetKeyName(5, "icons8-broom-96.png");
            this.ımageList1.Images.SetKeyName(6, "icons8-search-208.png");
            this.ımageList1.Images.SetKeyName(7, "icons8-plus-math-90.png");
            this.ımageList1.Images.SetKeyName(8, "icons8-search-more-90.png");
            this.ımageList1.Images.SetKeyName(9, "icons8-delete-90.png");
            this.ımageList1.Images.SetKeyName(10, "icons8-pencil-96.png");
            // 
            // button_ara
            // 
            this.button_ara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ara.BackColor = System.Drawing.Color.Brown;
            this.button_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ara.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ara.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_ara.ForeColor = System.Drawing.Color.White;
            this.button_ara.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ara.ImageKey = "search.png";
            this.button_ara.ImageList = this.ımageList1;
            this.button_ara.Location = new System.Drawing.Point(1045, 7);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(93, 28);
            this.button_ara.TabIndex = 136;
            this.button_ara.Text = "  Ara";
            this.button_ara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ara.UseVisualStyleBackColor = false;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // datepicker_teslimtarihi
            // 
            this.datepicker_teslimtarihi.CalendarFont = new System.Drawing.Font("Fredoka One", 10F);
            this.datepicker_teslimtarihi.Font = new System.Drawing.Font("Fredoka One", 9F);
            this.datepicker_teslimtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_teslimtarihi.Location = new System.Drawing.Point(600, 43);
            this.datepicker_teslimtarihi.Name = "datepicker_teslimtarihi";
            this.datepicker_teslimtarihi.Size = new System.Drawing.Size(142, 22);
            this.datepicker_teslimtarihi.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 9F);
            this.label2.Location = new System.Drawing.Point(246, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 133;
            this.label2.Text = "Hasta İsmi:";
            // 
            // textbox_arahasta
            // 
            this.textbox_arahasta.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.textbox_arahasta.ForeColor = System.Drawing.Color.Black;
            this.textbox_arahasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_arahasta.Location = new System.Drawing.Point(320, 42);
            this.textbox_arahasta.Name = "textbox_arahasta";
            this.textbox_arahasta.Size = new System.Drawing.Size(131, 25);
            this.textbox_arahasta.TabIndex = 132;
            this.textbox_arahasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_arahasta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 9F);
            this.label1.Location = new System.Drawing.Point(246, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 131;
            this.label1.Text = "Fiş No:";
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
            this.button_arama.ImageList = this.ımageList1;
            this.button_arama.Location = new System.Drawing.Point(95, 42);
            this.button_arama.Name = "button_arama";
            this.button_arama.Size = new System.Drawing.Size(145, 28);
            this.button_arama.TabIndex = 127;
            this.button_arama.Text = " Detaylı Arama";
            this.button_arama.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_arama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_arama.UseVisualStyleBackColor = false;
            this.button_arama.Click += new System.EventHandler(this.button_arama_Click);
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
            this.button_düzenle.ImageList = this.ımageList1;
            this.button_düzenle.Location = new System.Drawing.Point(95, 8);
            this.button_düzenle.Name = "button_düzenle";
            this.button_düzenle.Size = new System.Drawing.Size(145, 28);
            this.button_düzenle.TabIndex = 126;
            this.button_düzenle.Text = " Düzenle";
            this.button_düzenle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_düzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_düzenle.UseVisualStyleBackColor = false;
            this.button_düzenle.Click += new System.EventHandler(this.button_düzenle_Click);
            // 
            // textbox_arafisno
            // 
            this.textbox_arafisno.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.textbox_arafisno.ForeColor = System.Drawing.Color.Black;
            this.textbox_arafisno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_arafisno.Location = new System.Drawing.Point(320, 10);
            this.textbox_arafisno.Name = "textbox_arafisno";
            this.textbox_arafisno.Size = new System.Drawing.Size(131, 25);
            this.textbox_arafisno.TabIndex = 130;
            // 
            // datepicker_siparistarihi
            // 
            this.datepicker_siparistarihi.CalendarFont = new System.Drawing.Font("Fredoka One", 10F);
            this.datepicker_siparistarihi.Font = new System.Drawing.Font("Fredoka One", 9F);
            this.datepicker_siparistarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_siparistarihi.Location = new System.Drawing.Point(600, 11);
            this.datepicker_siparistarihi.Name = "datepicker_siparistarihi";
            this.datepicker_siparistarihi.Size = new System.Drawing.Size(142, 22);
            this.datepicker_siparistarihi.TabIndex = 128;
            this.datepicker_siparistarihi.ValueChanged += new System.EventHandler(this.datepicker_siparistarihi_ValueChanged);
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
            this.button_ekle.ImageList = this.ımageList1;
            this.button_ekle.Location = new System.Drawing.Point(12, 8);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(77, 28);
            this.button_ekle.TabIndex = 124;
            this.button_ekle.Text = "  Ekle";
            this.button_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // checkbox_siparistarihi
            // 
            this.checkbox_siparistarihi.AutoSize = true;
            this.checkbox_siparistarihi.Checked = true;
            this.checkbox_siparistarihi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_siparistarihi.Font = new System.Drawing.Font("Righteous", 9F);
            this.checkbox_siparistarihi.Location = new System.Drawing.Point(491, 13);
            this.checkbox_siparistarihi.Name = "checkbox_siparistarihi";
            this.checkbox_siparistarihi.Size = new System.Drawing.Size(103, 20);
            this.checkbox_siparistarihi.TabIndex = 142;
            this.checkbox_siparistarihi.Text = "Sipariş Tarihi:";
            this.checkbox_siparistarihi.UseVisualStyleBackColor = true;
            // 
            // checkbox_teslimattarihi
            // 
            this.checkbox_teslimattarihi.AutoSize = true;
            this.checkbox_teslimattarihi.Font = new System.Drawing.Font("Righteous", 9F);
            this.checkbox_teslimattarihi.Location = new System.Drawing.Point(491, 46);
            this.checkbox_teslimattarihi.Name = "checkbox_teslimattarihi";
            this.checkbox_teslimattarihi.Size = new System.Drawing.Size(99, 20);
            this.checkbox_teslimattarihi.TabIndex = 143;
            this.checkbox_teslimattarihi.Text = "Teslim Tarihi:";
            this.checkbox_teslimattarihi.UseVisualStyleBackColor = true;
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
            this.button_sil.ImageList = this.ımageList1;
            this.button_sil.Location = new System.Drawing.Point(12, 42);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(77, 28);
            this.button_sil.TabIndex = 144;
            this.button_sil.Text = "  Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click_1);
            // 
            // combobox_proteztipi
            // 
            this.combobox_proteztipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_proteztipi.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.combobox_proteztipi.FormattingEnabled = true;
            this.combobox_proteztipi.Items.AddRange(new object[] {
            "a",
            "b",
            "1",
            "2",
            "3",
            "asd",
            "asd",
            "asd",
            "as",
            "da",
            "sd"});
            this.combobox_proteztipi.Location = new System.Drawing.Point(839, 6);
            this.combobox_proteztipi.Name = "combobox_proteztipi";
            this.combobox_proteztipi.Size = new System.Drawing.Size(175, 29);
            this.combobox_proteztipi.TabIndex = 145;
            // 
            // combobox_renk
            // 
            this.combobox_renk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_renk.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.combobox_renk.FormattingEnabled = true;
            this.combobox_renk.Items.AddRange(new object[] {
            "a",
            "b",
            "1",
            "2",
            "3",
            "asd",
            "asd",
            "asd",
            "as",
            "da",
            "sd"});
            this.combobox_renk.Location = new System.Drawing.Point(839, 39);
            this.combobox_renk.Name = "combobox_renk";
            this.combobox_renk.Size = new System.Drawing.Size(175, 29);
            this.combobox_renk.TabIndex = 146;
            // 
            // SiparisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 77);
            this.Controls.Add(this.combobox_renk);
            this.Controls.Add(this.combobox_proteztipi);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.checkbox_teslimattarihi);
            this.Controls.Add(this.checkbox_siparistarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_temizle);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.datepicker_teslimtarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_arahasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_arama);
            this.Controls.Add(this.button_düzenle);
            this.Controls.Add(this.textbox_arafisno);
            this.Controls.Add(this.datepicker_siparistarihi);
            this.Controls.Add(this.button_ekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparisControl";
            this.Load += new System.EventHandler(this.SiparisControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.DateTimePicker datepicker_teslimtarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_arahasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_arama;
        private System.Windows.Forms.Button button_düzenle;
        private System.Windows.Forms.TextBox textbox_arafisno;
        private System.Windows.Forms.DateTimePicker datepicker_siparistarihi;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.CheckBox checkbox_siparistarihi;
        private System.Windows.Forms.CheckBox checkbox_teslimattarihi;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.ComboBox combobox_proteztipi;
        private System.Windows.Forms.ComboBox combobox_renk;
    }
}