namespace LPROS.Forms.Table.Search
{
    partial class Search_Siparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Siparis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridview_ara_siparis = new System.Windows.Forms.DataGridView();
            this.ayrinti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_sil = new System.Windows.Forms.Button();
            this.ımageList_button = new System.Windows.Forms.ImageList(this.components);
            this.checkbox_maliyet_arasinda = new System.Windows.Forms.CheckBox();
            this.textbox_maxmaliyet = new System.Windows.Forms.TextBox();
            this.checkbox_maliyet = new System.Windows.Forms.CheckBox();
            this.textbox_minmaliyet = new System.Windows.Forms.TextBox();
            this.button_düzenle = new System.Windows.Forms.Button();
            this.checkbox_siparistarihibaslangic = new System.Windows.Forms.CheckBox();
            this.checkbox_teslimattarihibaslangic = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.datepicker_teslimatbitis = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.datepicker_siparisbitis = new System.Windows.Forms.DateTimePicker();
            this.checkbox_teslimatarasinda = new System.Windows.Forms.CheckBox();
            this.checkbox_siparisarasinda = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combobox_renk = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combobox_kayitpersoneli = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combobox_protez = new System.Windows.Forms.ComboBox();
            this.textbox_hastaadsoyad = new System.Windows.Forms.TextBox();
            this.button_ara = new System.Windows.Forms.Button();
            this.datepicker_teslimatbaslangic = new System.Windows.Forms.DateTimePicker();
            this.datepicker_siparisbaslangic = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_fisno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combobox_doktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combobox_hastane = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_ara_siparis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1252, 30);
            this.panel_head.TabIndex = 56;
            // 
            // label_head
            // 
            this.label_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_head.Font = new System.Drawing.Font("Righteous", 12.5F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(12, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(700, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Sipariş Ara";
            this.label_head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(1222, 0);
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
            this.panel1.Controls.Add(this.datagridview_ara_siparis);
            this.panel1.Controls.Add(this.button_sil);
            this.panel1.Controls.Add(this.checkbox_maliyet_arasinda);
            this.panel1.Controls.Add(this.textbox_maxmaliyet);
            this.panel1.Controls.Add(this.checkbox_maliyet);
            this.panel1.Controls.Add(this.textbox_minmaliyet);
            this.panel1.Controls.Add(this.button_düzenle);
            this.panel1.Controls.Add(this.checkbox_siparistarihibaslangic);
            this.panel1.Controls.Add(this.checkbox_teslimattarihibaslangic);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.datepicker_teslimatbitis);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.datepicker_siparisbitis);
            this.panel1.Controls.Add(this.checkbox_teslimatarasinda);
            this.panel1.Controls.Add(this.checkbox_siparisarasinda);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.combobox_renk);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.combobox_kayitpersoneli);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.combobox_protez);
            this.panel1.Controls.Add(this.textbox_hastaadsoyad);
            this.panel1.Controls.Add(this.button_ara);
            this.panel1.Controls.Add(this.datepicker_teslimatbaslangic);
            this.panel1.Controls.Add(this.datepicker_siparisbaslangic);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_fisno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.combobox_doktor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.combobox_hastane);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 654);
            this.panel1.TabIndex = 44;
            // 
            // datagridview_ara_siparis
            // 
            this.datagridview_ara_siparis.AllowUserToAddRows = false;
            this.datagridview_ara_siparis.AllowUserToDeleteRows = false;
            this.datagridview_ara_siparis.AllowUserToResizeColumns = false;
            this.datagridview_ara_siparis.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_ara_siparis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_ara_siparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_ara_siparis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_ara_siparis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Righteous", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_ara_siparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_ara_siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_ara_siparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ayrinti});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Fredoka One", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_ara_siparis.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_ara_siparis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview_ara_siparis.EnableHeadersVisualStyles = false;
            this.datagridview_ara_siparis.Location = new System.Drawing.Point(0, 254);
            this.datagridview_ara_siparis.MultiSelect = false;
            this.datagridview_ara_siparis.Name = "datagridview_ara_siparis";
            this.datagridview_ara_siparis.ReadOnly = true;
            this.datagridview_ara_siparis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_ara_siparis.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_ara_siparis.RowHeadersWidth = 35;
            this.datagridview_ara_siparis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_ara_siparis.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview_ara_siparis.RowTemplate.Height = 39;
            this.datagridview_ara_siparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_ara_siparis.Size = new System.Drawing.Size(1252, 398);
            this.datagridview_ara_siparis.TabIndex = 136;
            this.datagridview_ara_siparis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_ara_siparis_CellClick);
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
            this.button_sil.Location = new System.Drawing.Point(861, 186);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(93, 50);
            this.button_sil.TabIndex = 135;
            this.button_sil.Text = " Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // ımageList_button
            // 
            this.ımageList_button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_button.ImageStream")));
            this.ımageList_button.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_button.Images.SetKeyName(0, "icons8-broom-96.png");
            this.ımageList_button.Images.SetKeyName(1, "icons8-search-208.png");
            this.ımageList_button.Images.SetKeyName(2, "icons8-plus-math-90.png");
            this.ımageList_button.Images.SetKeyName(3, "icons8-search-more-90.png");
            this.ımageList_button.Images.SetKeyName(4, "icons8-delete-90.png");
            this.ımageList_button.Images.SetKeyName(5, "icons8-pencil-96.png");
            // 
            // checkbox_maliyet_arasinda
            // 
            this.checkbox_maliyet_arasinda.AutoSize = true;
            this.checkbox_maliyet_arasinda.Enabled = false;
            this.checkbox_maliyet_arasinda.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_maliyet_arasinda.Location = new System.Drawing.Point(501, 212);
            this.checkbox_maliyet_arasinda.Name = "checkbox_maliyet_arasinda";
            this.checkbox_maliyet_arasinda.Size = new System.Drawing.Size(112, 21);
            this.checkbox_maliyet_arasinda.TabIndex = 133;
            this.checkbox_maliyet_arasinda.Text = "Maliyet (Max)";
            this.checkbox_maliyet_arasinda.UseVisualStyleBackColor = true;
            this.checkbox_maliyet_arasinda.CheckedChanged += new System.EventHandler(this.checkbox_maliyet_arasinda_CheckedChanged);
            // 
            // textbox_maxmaliyet
            // 
            this.textbox_maxmaliyet.Enabled = false;
            this.textbox_maxmaliyet.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_maxmaliyet.ForeColor = System.Drawing.Color.Black;
            this.textbox_maxmaliyet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_maxmaliyet.Location = new System.Drawing.Point(638, 206);
            this.textbox_maxmaliyet.Name = "textbox_maxmaliyet";
            this.textbox_maxmaliyet.Size = new System.Drawing.Size(74, 26);
            this.textbox_maxmaliyet.TabIndex = 132;
            this.textbox_maxmaliyet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_sadeceSayi_KeyPress);
            // 
            // checkbox_maliyet
            // 
            this.checkbox_maliyet.AutoSize = true;
            this.checkbox_maliyet.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_maliyet.Location = new System.Drawing.Point(501, 181);
            this.checkbox_maliyet.Name = "checkbox_maliyet";
            this.checkbox_maliyet.Size = new System.Drawing.Size(72, 21);
            this.checkbox_maliyet.TabIndex = 131;
            this.checkbox_maliyet.Text = "Maliyet";
            this.checkbox_maliyet.UseVisualStyleBackColor = true;
            this.checkbox_maliyet.CheckedChanged += new System.EventHandler(this.checkbox_maliyet_CheckedChanged);
            // 
            // textbox_minmaliyet
            // 
            this.textbox_minmaliyet.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_minmaliyet.ForeColor = System.Drawing.Color.Black;
            this.textbox_minmaliyet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_minmaliyet.Location = new System.Drawing.Point(638, 175);
            this.textbox_minmaliyet.Name = "textbox_minmaliyet";
            this.textbox_minmaliyet.Size = new System.Drawing.Size(74, 26);
            this.textbox_minmaliyet.TabIndex = 130;
            this.textbox_minmaliyet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_sadeceSayi_KeyPress);
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
            this.button_düzenle.Location = new System.Drawing.Point(743, 186);
            this.button_düzenle.Name = "button_düzenle";
            this.button_düzenle.Size = new System.Drawing.Size(112, 50);
            this.button_düzenle.TabIndex = 128;
            this.button_düzenle.Text = " Düzenle";
            this.button_düzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_düzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_düzenle.UseVisualStyleBackColor = false;
            this.button_düzenle.Click += new System.EventHandler(this.button_düzenle_Click);
            // 
            // checkbox_siparistarihibaslangic
            // 
            this.checkbox_siparistarihibaslangic.AutoSize = true;
            this.checkbox_siparistarihibaslangic.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_siparistarihibaslangic.Location = new System.Drawing.Point(17, 99);
            this.checkbox_siparistarihibaslangic.Name = "checkbox_siparistarihibaslangic";
            this.checkbox_siparistarihibaslangic.Size = new System.Drawing.Size(107, 21);
            this.checkbox_siparistarihibaslangic.TabIndex = 88;
            this.checkbox_siparistarihibaslangic.Text = "Sipariş Tarihi";
            this.checkbox_siparistarihibaslangic.UseVisualStyleBackColor = true;
            this.checkbox_siparistarihibaslangic.CheckedChanged += new System.EventHandler(this.checkbox_siparistarihibaslangic_CheckedChanged);
            // 
            // checkbox_teslimattarihibaslangic
            // 
            this.checkbox_teslimattarihibaslangic.AutoSize = true;
            this.checkbox_teslimattarihibaslangic.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_teslimattarihibaslangic.Location = new System.Drawing.Point(259, 99);
            this.checkbox_teslimattarihibaslangic.Name = "checkbox_teslimattarihibaslangic";
            this.checkbox_teslimattarihibaslangic.Size = new System.Drawing.Size(117, 21);
            this.checkbox_teslimattarihibaslangic.TabIndex = 87;
            this.checkbox_teslimattarihibaslangic.Text = "Teslimat Tarihi";
            this.checkbox_teslimattarihibaslangic.UseVisualStyleBackColor = true;
            this.checkbox_teslimattarihibaslangic.CheckedChanged += new System.EventHandler(this.checkbox_teslimattarihibaslangic_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label12.Location = new System.Drawing.Point(256, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 85;
            this.label12.Text = "Teslimat Tarihi Bitiş";
            // 
            // datepicker_teslimatbitis
            // 
            this.datepicker_teslimatbitis.Checked = false;
            this.datepicker_teslimatbitis.Enabled = false;
            this.datepicker_teslimatbitis.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_teslimatbitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_teslimatbitis.Location = new System.Drawing.Point(259, 205);
            this.datepicker_teslimatbitis.Name = "datepicker_teslimatbitis";
            this.datepicker_teslimatbitis.Size = new System.Drawing.Size(211, 29);
            this.datepicker_teslimatbitis.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label11.Location = new System.Drawing.Point(15, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "Sipariş Tarihi Bitiş";
            // 
            // datepicker_siparisbitis
            // 
            this.datepicker_siparisbitis.Checked = false;
            this.datepicker_siparisbitis.Enabled = false;
            this.datepicker_siparisbitis.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_siparisbitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_siparisbitis.Location = new System.Drawing.Point(17, 205);
            this.datepicker_siparisbitis.Name = "datepicker_siparisbitis";
            this.datepicker_siparisbitis.Size = new System.Drawing.Size(211, 29);
            this.datepicker_siparisbitis.TabIndex = 82;
            // 
            // checkbox_teslimatarasinda
            // 
            this.checkbox_teslimatarasinda.AutoSize = true;
            this.checkbox_teslimatarasinda.Enabled = false;
            this.checkbox_teslimatarasinda.Font = new System.Drawing.Font("Righteous", 7F);
            this.checkbox_teslimatarasinda.Location = new System.Drawing.Point(259, 158);
            this.checkbox_teslimatarasinda.Name = "checkbox_teslimatarasinda";
            this.checkbox_teslimatarasinda.Size = new System.Drawing.Size(104, 17);
            this.checkbox_teslimatarasinda.TabIndex = 81;
            this.checkbox_teslimatarasinda.Text = "2 Tarih Arasında";
            this.checkbox_teslimatarasinda.UseVisualStyleBackColor = true;
            this.checkbox_teslimatarasinda.CheckedChanged += new System.EventHandler(this.checkBox_teslimat_CheckedChanged);
            // 
            // checkbox_siparisarasinda
            // 
            this.checkbox_siparisarasinda.AutoSize = true;
            this.checkbox_siparisarasinda.Enabled = false;
            this.checkbox_siparisarasinda.Font = new System.Drawing.Font("Righteous", 7F);
            this.checkbox_siparisarasinda.Location = new System.Drawing.Point(18, 158);
            this.checkbox_siparisarasinda.Name = "checkbox_siparisarasinda";
            this.checkbox_siparisarasinda.Size = new System.Drawing.Size(104, 17);
            this.checkbox_siparisarasinda.TabIndex = 80;
            this.checkbox_siparisarasinda.Text = "2 Tarih Arasında";
            this.checkbox_siparisarasinda.UseVisualStyleBackColor = true;
            this.checkbox_siparisarasinda.CheckedChanged += new System.EventHandler(this.checkBox_siparis_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label10.Location = new System.Drawing.Point(740, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "Renk";
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
            this.combobox_renk.Location = new System.Drawing.Point(743, 123);
            this.combobox_renk.Name = "combobox_renk";
            this.combobox_renk.Size = new System.Drawing.Size(211, 29);
            this.combobox_renk.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label8.Location = new System.Drawing.Point(986, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 75;
            this.label8.Text = "Kayıt Personeli";
            // 
            // combobox_kayitpersoneli
            // 
            this.combobox_kayitpersoneli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_kayitpersoneli.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.combobox_kayitpersoneli.FormattingEnabled = true;
            this.combobox_kayitpersoneli.Items.AddRange(new object[] {
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
            this.combobox_kayitpersoneli.Location = new System.Drawing.Point(989, 63);
            this.combobox_kayitpersoneli.Name = "combobox_kayitpersoneli";
            this.combobox_kayitpersoneli.Size = new System.Drawing.Size(211, 29);
            this.combobox_kayitpersoneli.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label3.Location = new System.Drawing.Point(498, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Protez Tipi";
            // 
            // combobox_protez
            // 
            this.combobox_protez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_protez.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.combobox_protez.FormattingEnabled = true;
            this.combobox_protez.Items.AddRange(new object[] {
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
            this.combobox_protez.Location = new System.Drawing.Point(501, 123);
            this.combobox_protez.Name = "combobox_protez";
            this.combobox_protez.Size = new System.Drawing.Size(211, 29);
            this.combobox_protez.TabIndex = 72;
            // 
            // textbox_hastaadsoyad
            // 
            this.textbox_hastaadsoyad.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_hastaadsoyad.ForeColor = System.Drawing.Color.Black;
            this.textbox_hastaadsoyad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_hastaadsoyad.Location = new System.Drawing.Point(259, 63);
            this.textbox_hastaadsoyad.Name = "textbox_hastaadsoyad";
            this.textbox_hastaadsoyad.Size = new System.Drawing.Size(211, 26);
            this.textbox_hastaadsoyad.TabIndex = 65;
            this.textbox_hastaadsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_sadeceHarf_KeyPress);
            // 
            // button_ara
            // 
            this.button_ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ara.FlatAppearance.BorderSize = 0;
            this.button_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ara.Font = new System.Drawing.Font("Righteous", 12F);
            this.button_ara.ForeColor = System.Drawing.Color.White;
            this.button_ara.Location = new System.Drawing.Point(989, 186);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(211, 50);
            this.button_ara.TabIndex = 71;
            this.button_ara.Text = "Siparişleri Ara";
            this.button_ara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ara.UseVisualStyleBackColor = false;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // datepicker_teslimatbaslangic
            // 
            this.datepicker_teslimatbaslangic.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_teslimatbaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_teslimatbaslangic.Location = new System.Drawing.Point(259, 123);
            this.datepicker_teslimatbaslangic.Name = "datepicker_teslimatbaslangic";
            this.datepicker_teslimatbaslangic.Size = new System.Drawing.Size(211, 29);
            this.datepicker_teslimatbaslangic.TabIndex = 69;
            this.datepicker_teslimatbaslangic.ValueChanged += new System.EventHandler(this.datetimepicker_teslimatbaslangic_ValueChanged);
            // 
            // datepicker_siparisbaslangic
            // 
            this.datepicker_siparisbaslangic.Checked = false;
            this.datepicker_siparisbaslangic.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_siparisbaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_siparisbaslangic.Location = new System.Drawing.Point(17, 123);
            this.datepicker_siparisbaslangic.Name = "datepicker_siparisbaslangic";
            this.datepicker_siparisbaslangic.Size = new System.Drawing.Size(211, 29);
            this.datepicker_siparisbaslangic.TabIndex = 67;
            this.datepicker_siparisbaslangic.ValueChanged += new System.EventHandler(this.datetimepicker_siparisbaslangic_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label7.Location = new System.Drawing.Point(14, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 66;
            this.label7.Text = "Fiş Numarası";
            // 
            // textbox_fisno
            // 
            this.textbox_fisno.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_fisno.ForeColor = System.Drawing.Color.Black;
            this.textbox_fisno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_fisno.Location = new System.Drawing.Point(17, 63);
            this.textbox_fisno.Name = "textbox_fisno";
            this.textbox_fisno.Size = new System.Drawing.Size(211, 26);
            this.textbox_fisno.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label6.Location = new System.Drawing.Point(740, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Doktor";
            // 
            // combobox_doktor
            // 
            this.combobox_doktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_doktor.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.combobox_doktor.FormattingEnabled = true;
            this.combobox_doktor.Items.AddRange(new object[] {
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
            this.combobox_doktor.Location = new System.Drawing.Point(743, 63);
            this.combobox_doktor.Name = "combobox_doktor";
            this.combobox_doktor.Size = new System.Drawing.Size(211, 29);
            this.combobox_doktor.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label5.Location = new System.Drawing.Point(498, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Hastane";
            // 
            // combobox_hastane
            // 
            this.combobox_hastane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_hastane.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.combobox_hastane.FormattingEnabled = true;
            this.combobox_hastane.Items.AddRange(new object[] {
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
            this.combobox_hastane.Location = new System.Drawing.Point(501, 63);
            this.combobox_hastane.Name = "combobox_hastane";
            this.combobox_hastane.Size = new System.Drawing.Size(211, 29);
            this.combobox_hastane.TabIndex = 60;
            this.combobox_hastane.SelectedIndexChanged += new System.EventHandler(this.combobox_hastane_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label4.Location = new System.Drawing.Point(256, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "Hasta Ad Soyad";
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
            // Search_Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 654);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Siparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Siparis";
            this.Load += new System.EventHandler(this.Search_Siparis_Load);
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_ara_siparis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combobox_protez;
        private System.Windows.Forms.TextBox textbox_hastaadsoyad;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.DateTimePicker datepicker_teslimatbaslangic;
        private System.Windows.Forms.DateTimePicker datepicker_siparisbaslangic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_fisno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combobox_doktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combobox_hastane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combobox_kayitpersoneli;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combobox_renk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datepicker_siparisbitis;
        private System.Windows.Forms.CheckBox checkbox_teslimatarasinda;
        private System.Windows.Forms.CheckBox checkbox_siparisarasinda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datepicker_teslimatbitis;
        private System.Windows.Forms.CheckBox checkbox_siparistarihibaslangic;
        private System.Windows.Forms.CheckBox checkbox_teslimattarihibaslangic;
        private System.Windows.Forms.Button button_düzenle;
        private System.Windows.Forms.ImageList ımageList_button;
        private System.Windows.Forms.CheckBox checkbox_maliyet;
        private System.Windows.Forms.TextBox textbox_minmaliyet;
        private System.Windows.Forms.CheckBox checkbox_maliyet_arasinda;
        private System.Windows.Forms.TextBox textbox_maxmaliyet;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.DataGridView datagridview_ara_siparis;
        private System.Windows.Forms.DataGridViewButtonColumn ayrinti;
        private System.Windows.Forms.ImageList ımageList1;
    }
}