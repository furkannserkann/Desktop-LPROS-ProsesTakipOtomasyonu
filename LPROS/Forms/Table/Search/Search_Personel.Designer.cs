namespace LPROS.Forms.Table.Search
{
    partial class Search_Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Personel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_durum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sskno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_departman = new System.Windows.Forms.ComboBox();
            this.textBox_soyisim = new System.Windows.Forms.TextBox();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkbox_maas_arasinda = new System.Windows.Forms.CheckBox();
            this.textbox_maxmaas = new System.Windows.Forms.TextBox();
            this.checkbox_maas = new System.Windows.Forms.CheckBox();
            this.textbox_minmaas = new System.Windows.Forms.TextBox();
            this.checkbox_sskbas = new System.Windows.Forms.CheckBox();
            this.checkbox_isegiris = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.datepicker_isebasmax = new System.Windows.Forms.DateTimePicker();
            this.checkbox_arasında = new System.Windows.Forms.CheckBox();
            this.datepicker_isebaslangic = new System.Windows.Forms.DateTimePicker();
            this.datepicker_sskbaslangic = new System.Windows.Forms.DateTimePicker();
            this.datagridview_Personel = new System.Windows.Forms.DataGridView();
            this.ayrinti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_sil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_düzenle = new System.Windows.Forms.Button();
            this.textBox_adres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_eposta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBox_Tc = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_yetki = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Personel)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label5.Location = new System.Drawing.Point(1052, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Durumu";
            // 
            // comboBox_durum
            // 
            this.comboBox_durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.comboBox_durum.FormattingEnabled = true;
            this.comboBox_durum.Items.AddRange(new object[] {
            "",
            "Aktif",
            "Pasif"});
            this.comboBox_durum.Location = new System.Drawing.Point(1055, 175);
            this.comboBox_durum.Name = "comboBox_durum";
            this.comboBox_durum.Size = new System.Drawing.Size(211, 25);
            this.comboBox_durum.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label8.Location = new System.Drawing.Point(796, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "SSK Numaarası";
            // 
            // textBox_sskno
            // 
            this.textBox_sskno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textBox_sskno.ForeColor = System.Drawing.Color.Black;
            this.textBox_sskno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_sskno.Location = new System.Drawing.Point(799, 175);
            this.textBox_sskno.Name = "textBox_sskno";
            this.textBox_sskno.Size = new System.Drawing.Size(211, 23);
            this.textBox_sskno.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label2.Location = new System.Drawing.Point(514, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // textBox_kullaniciadi
            // 
            this.textBox_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textBox_kullaniciadi.ForeColor = System.Drawing.Color.Black;
            this.textBox_kullaniciadi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_kullaniciadi.Location = new System.Drawing.Point(517, 65);
            this.textBox_kullaniciadi.Name = "textBox_kullaniciadi";
            this.textBox_kullaniciadi.Size = new System.Drawing.Size(211, 23);
            this.textBox_kullaniciadi.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label3.Location = new System.Drawing.Point(1052, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Departman";
            // 
            // comboBox_departman
            // 
            this.comboBox_departman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_departman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.comboBox_departman.FormattingEnabled = true;
            this.comboBox_departman.Items.AddRange(new object[] {
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
            this.comboBox_departman.Location = new System.Drawing.Point(1055, 120);
            this.comboBox_departman.Name = "comboBox_departman";
            this.comboBox_departman.Size = new System.Drawing.Size(211, 25);
            this.comboBox_departman.TabIndex = 57;
            // 
            // textBox_soyisim
            // 
            this.textBox_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textBox_soyisim.ForeColor = System.Drawing.Color.Black;
            this.textBox_soyisim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_soyisim.Location = new System.Drawing.Point(259, 63);
            this.textBox_soyisim.Name = "textBox_soyisim";
            this.textBox_soyisim.Size = new System.Drawing.Size(211, 23);
            this.textBox_soyisim.TabIndex = 48;
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1283, 30);
            this.panel_head.TabIndex = 56;
            // 
            // label_head
            // 
            this.label_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_head.Font = new System.Drawing.Font("Righteous", 12F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(12, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(1235, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Personel Ara";
            this.label_head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(1253, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkbox_maas_arasinda);
            this.panel1.Controls.Add(this.textbox_maxmaas);
            this.panel1.Controls.Add(this.checkbox_maas);
            this.panel1.Controls.Add(this.textbox_minmaas);
            this.panel1.Controls.Add(this.checkbox_sskbas);
            this.panel1.Controls.Add(this.checkbox_isegiris);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.datepicker_isebasmax);
            this.panel1.Controls.Add(this.checkbox_arasında);
            this.panel1.Controls.Add(this.datepicker_isebaslangic);
            this.panel1.Controls.Add(this.datepicker_sskbaslangic);
            this.panel1.Controls.Add(this.datagridview_Personel);
            this.panel1.Controls.Add(this.button_sil);
            this.panel1.Controls.Add(this.button_düzenle);
            this.panel1.Controls.Add(this.textBox_adres);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBox_telefon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_eposta);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TextBox_Tc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox_durum);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_sskno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_kullaniciadi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_departman);
            this.panel1.Controls.Add(this.textBox_soyisim);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_isim);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox_yetki);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 655);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkbox_maas_arasinda
            // 
            this.checkbox_maas_arasinda.AutoSize = true;
            this.checkbox_maas_arasinda.Enabled = false;
            this.checkbox_maas_arasinda.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_maas_arasinda.Location = new System.Drawing.Point(17, 216);
            this.checkbox_maas_arasinda.Name = "checkbox_maas_arasinda";
            this.checkbox_maas_arasinda.Size = new System.Drawing.Size(101, 21);
            this.checkbox_maas_arasinda.TabIndex = 209;
            this.checkbox_maas_arasinda.Text = "Maaş (Max)";
            this.checkbox_maas_arasinda.UseVisualStyleBackColor = true;
            // 
            // textbox_maxmaas
            // 
            this.textbox_maxmaas.Enabled = false;
            this.textbox_maxmaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_maxmaas.ForeColor = System.Drawing.Color.Black;
            this.textbox_maxmaas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_maxmaas.Location = new System.Drawing.Point(154, 210);
            this.textbox_maxmaas.Name = "textbox_maxmaas";
            this.textbox_maxmaas.Size = new System.Drawing.Size(74, 24);
            this.textbox_maxmaas.TabIndex = 208;
            // 
            // checkbox_maas
            // 
            this.checkbox_maas.AutoSize = true;
            this.checkbox_maas.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_maas.Location = new System.Drawing.Point(17, 185);
            this.checkbox_maas.Name = "checkbox_maas";
            this.checkbox_maas.Size = new System.Drawing.Size(61, 21);
            this.checkbox_maas.TabIndex = 207;
            this.checkbox_maas.Text = "Maaş";
            this.checkbox_maas.UseVisualStyleBackColor = true;
            this.checkbox_maas.CheckedChanged += new System.EventHandler(this.checkbox_maliyet_CheckedChanged);
            // 
            // textbox_minmaas
            // 
            this.textbox_minmaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_minmaas.ForeColor = System.Drawing.Color.Black;
            this.textbox_minmaas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_minmaas.Location = new System.Drawing.Point(154, 179);
            this.textbox_minmaas.Name = "textbox_minmaas";
            this.textbox_minmaas.Size = new System.Drawing.Size(74, 24);
            this.textbox_minmaas.TabIndex = 206;
            // 
            // checkbox_sskbas
            // 
            this.checkbox_sskbas.AutoSize = true;
            this.checkbox_sskbas.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_sskbas.Location = new System.Drawing.Point(17, 99);
            this.checkbox_sskbas.Name = "checkbox_sskbas";
            this.checkbox_sskbas.Size = new System.Drawing.Size(153, 21);
            this.checkbox_sskbas.TabIndex = 205;
            this.checkbox_sskbas.Text = "SSK Başlangıç Tarihi";
            this.checkbox_sskbas.UseVisualStyleBackColor = true;
            // 
            // checkbox_isegiris
            // 
            this.checkbox_isegiris.AutoSize = true;
            this.checkbox_isegiris.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_isegiris.Location = new System.Drawing.Point(259, 99);
            this.checkbox_isegiris.Name = "checkbox_isegiris";
            this.checkbox_isegiris.Size = new System.Drawing.Size(147, 21);
            this.checkbox_isegiris.TabIndex = 204;
            this.checkbox_isegiris.Text = "İşe Başlangıç Tarihi";
            this.checkbox_isegiris.UseVisualStyleBackColor = true;
            this.checkbox_isegiris.CheckedChanged += new System.EventHandler(this.checkbox_isegiris_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label12.Location = new System.Drawing.Point(256, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 17);
            this.label12.TabIndex = 203;
            this.label12.Text = "İşe Başlangıç Tarihi Max";
            // 
            // datepicker_isebasmax
            // 
            this.datepicker_isebasmax.Checked = false;
            this.datepicker_isebasmax.Enabled = false;
            this.datepicker_isebasmax.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_isebasmax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_isebasmax.Location = new System.Drawing.Point(259, 205);
            this.datepicker_isebasmax.Name = "datepicker_isebasmax";
            this.datepicker_isebasmax.Size = new System.Drawing.Size(211, 29);
            this.datepicker_isebasmax.TabIndex = 202;
            // 
            // checkbox_arasında
            // 
            this.checkbox_arasında.AutoSize = true;
            this.checkbox_arasında.Enabled = false;
            this.checkbox_arasında.Font = new System.Drawing.Font("Righteous", 7F);
            this.checkbox_arasında.Location = new System.Drawing.Point(259, 158);
            this.checkbox_arasında.Name = "checkbox_arasında";
            this.checkbox_arasında.Size = new System.Drawing.Size(104, 17);
            this.checkbox_arasında.TabIndex = 199;
            this.checkbox_arasında.Text = "2 Tarih Arasında";
            this.checkbox_arasında.UseVisualStyleBackColor = true;
            this.checkbox_arasında.CheckedChanged += new System.EventHandler(this.checkbox_isebaslangıc_CheckedChanged);
            // 
            // datepicker_isebaslangic
            // 
            this.datepicker_isebaslangic.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_isebaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_isebaslangic.Location = new System.Drawing.Point(259, 123);
            this.datepicker_isebaslangic.Name = "datepicker_isebaslangic";
            this.datepicker_isebaslangic.Size = new System.Drawing.Size(211, 29);
            this.datepicker_isebaslangic.TabIndex = 197;
            this.datepicker_isebaslangic.ValueChanged += new System.EventHandler(this.datepicker_isebaslangic_ValueChanged);
            // 
            // datepicker_sskbaslangic
            // 
            this.datepicker_sskbaslangic.Checked = false;
            this.datepicker_sskbaslangic.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_sskbaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_sskbaslangic.Location = new System.Drawing.Point(17, 123);
            this.datepicker_sskbaslangic.Name = "datepicker_sskbaslangic";
            this.datepicker_sskbaslangic.Size = new System.Drawing.Size(211, 29);
            this.datepicker_sskbaslangic.TabIndex = 196;
            // 
            // datagridview_Personel
            // 
            this.datagridview_Personel.AllowUserToAddRows = false;
            this.datagridview_Personel.AllowUserToDeleteRows = false;
            this.datagridview_Personel.AllowUserToResizeColumns = false;
            this.datagridview_Personel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Personel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_Personel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_Personel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_Personel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Righteous", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Personel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_Personel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_Personel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ayrinti});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Fredoka One", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_Personel.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_Personel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview_Personel.EnableHeadersVisualStyles = false;
            this.datagridview_Personel.Location = new System.Drawing.Point(0, 291);
            this.datagridview_Personel.MultiSelect = false;
            this.datagridview_Personel.Name = "datagridview_Personel";
            this.datagridview_Personel.ReadOnly = true;
            this.datagridview_Personel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Personel.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_Personel.RowHeadersWidth = 35;
            this.datagridview_Personel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Personel.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview_Personel.RowTemplate.Height = 39;
            this.datagridview_Personel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_Personel.Size = new System.Drawing.Size(1283, 362);
            this.datagridview_Personel.TabIndex = 195;
            this.datagridview_Personel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_Personel_CellClick);
            this.datagridview_Personel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_Siparis_CellContentClick);
            // 
            // ayrinti
            // 
            this.ayrinti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ayrinti.HeaderText = "Ayrıntılar";
            this.ayrinti.Name = "ayrinti";
            this.ayrinti.ReadOnly = true;
            this.ayrinti.Text = "Detay";
            this.ayrinti.UseColumnTextForButtonValue = true;
            this.ayrinti.Width = 88;
            // 
            // button_sil
            // 
            this.button_sil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sil.BackColor = System.Drawing.Color.Brown;
            this.button_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sil.Font = new System.Drawing.Font("Righteous", 10.5F);
            this.button_sil.ForeColor = System.Drawing.Color.White;
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.ImageKey = "delete.png";
            this.button_sil.ImageList = this.ımageList1;
            this.button_sil.Location = new System.Drawing.Point(917, 222);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(93, 50);
            this.button_sil.TabIndex = 194;
            this.button_sil.Text = " Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
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
            // button_düzenle
            // 
            this.button_düzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_düzenle.BackColor = System.Drawing.Color.Brown;
            this.button_düzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_düzenle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_düzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_düzenle.Font = new System.Drawing.Font("Righteous", 10.5F);
            this.button_düzenle.ForeColor = System.Drawing.Color.White;
            this.button_düzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_düzenle.ImageKey = "edit.png";
            this.button_düzenle.ImageList = this.ımageList1;
            this.button_düzenle.Location = new System.Drawing.Point(799, 222);
            this.button_düzenle.Name = "button_düzenle";
            this.button_düzenle.Size = new System.Drawing.Size(112, 50);
            this.button_düzenle.TabIndex = 193;
            this.button_düzenle.Text = " Düzenle";
            this.button_düzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_düzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_düzenle.UseVisualStyleBackColor = false;
            this.button_düzenle.Click += new System.EventHandler(this.button_düzenle_Click);
            // 
            // textBox_adres
            // 
            this.textBox_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textBox_adres.ForeColor = System.Drawing.Color.Black;
            this.textBox_adres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_adres.Location = new System.Drawing.Point(517, 175);
            this.textBox_adres.Multiline = true;
            this.textBox_adres.Name = "textBox_adres";
            this.textBox_adres.Size = new System.Drawing.Size(211, 62);
            this.textBox_adres.TabIndex = 156;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label10.Location = new System.Drawing.Point(514, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 155;
            this.label10.Text = "Adres";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label15.Location = new System.Drawing.Point(514, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 17);
            this.label15.TabIndex = 154;
            this.label15.Text = "Telefon Numarası";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textBox_telefon.ForeColor = System.Drawing.Color.Black;
            this.textBox_telefon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_telefon.Location = new System.Drawing.Point(517, 120);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(211, 23);
            this.textBox_telefon.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label1.Location = new System.Drawing.Point(796, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 152;
            this.label1.Text = "E_Posta";
            // 
            // textBox_eposta
            // 
            this.textBox_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textBox_eposta.ForeColor = System.Drawing.Color.Black;
            this.textBox_eposta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_eposta.Location = new System.Drawing.Point(799, 63);
            this.textBox_eposta.Name = "textBox_eposta";
            this.textBox_eposta.Size = new System.Drawing.Size(211, 23);
            this.textBox_eposta.TabIndex = 151;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label13.Location = new System.Drawing.Point(796, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 17);
            this.label13.TabIndex = 150;
            this.label13.Text = "TC Kimlik Numarası";
            // 
            // TextBox_Tc
            // 
            this.TextBox_Tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TextBox_Tc.ForeColor = System.Drawing.Color.Black;
            this.TextBox_Tc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBox_Tc.Location = new System.Drawing.Point(799, 120);
            this.TextBox_Tc.MaxLength = 11;
            this.TextBox_Tc.Name = "TextBox_Tc";
            this.TextBox_Tc.Size = new System.Drawing.Size(211, 23);
            this.TextBox_Tc.TabIndex = 149;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Righteous", 12F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(1055, 222);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(211, 50);
            this.button9.TabIndex = 55;
            this.button9.Text = "Personelleri Ara";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label7.Location = new System.Drawing.Point(14, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "İsim";
            // 
            // textBox_isim
            // 
            this.textBox_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textBox_isim.ForeColor = System.Drawing.Color.Black;
            this.textBox_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_isim.Location = new System.Drawing.Point(17, 63);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(211, 23);
            this.textBox_isim.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label6.Location = new System.Drawing.Point(1052, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Yetki";
            // 
            // comboBox_yetki
            // 
            this.comboBox_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_yetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.comboBox_yetki.FormattingEnabled = true;
            this.comboBox_yetki.Items.AddRange(new object[] {
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
            this.comboBox_yetki.Location = new System.Drawing.Point(1055, 63);
            this.comboBox_yetki.Name = "comboBox_yetki";
            this.comboBox_yetki.Size = new System.Drawing.Size(211, 25);
            this.comboBox_yetki.TabIndex = 45;
            this.comboBox_yetki.SelectedIndexChanged += new System.EventHandler(this.comboBox_yetki_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label4.Location = new System.Drawing.Point(256, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Soyisim";
            // 
            // Search_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 655);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Personel";
            this.Load += new System.EventHandler(this.Search_Personel_Load);
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Personel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_durum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_sskno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kullaniciadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_departman;
        private System.Windows.Forms.TextBox textBox_soyisim;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_yetki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TextBox_Tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_eposta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.TextBox textBox_adres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button_düzenle;
        private System.Windows.Forms.DataGridView datagridview_Personel;
        private System.Windows.Forms.DataGridViewButtonColumn ayrinti;
        private System.Windows.Forms.CheckBox checkbox_sskbas;
        private System.Windows.Forms.CheckBox checkbox_isegiris;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datepicker_isebasmax;
        private System.Windows.Forms.CheckBox checkbox_arasında;
        private System.Windows.Forms.DateTimePicker datepicker_isebaslangic;
        private System.Windows.Forms.DateTimePicker datepicker_sskbaslangic;
        private System.Windows.Forms.CheckBox checkbox_maas_arasinda;
        private System.Windows.Forms.TextBox textbox_maxmaas;
        private System.Windows.Forms.CheckBox checkbox_maas;
        private System.Windows.Forms.TextBox textbox_minmaas;
    }
}