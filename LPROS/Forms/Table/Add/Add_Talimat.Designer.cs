namespace LPROS.Forms.Table.Add
{
    partial class Add_Talimat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Talimat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridview_proses = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_talimat_isim = new System.Windows.Forms.TextBox();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.button_talimat_kaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_talimat_kod = new System.Windows.Forms.TextBox();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.checkbox_secili = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_proses)).BeginInit();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkbox_secili);
            this.panel1.Controls.Add(this.datagridview_proses);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textbox_talimat_isim);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.button_talimat_kaydet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_talimat_kod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 572);
            this.panel1.TabIndex = 44;
            // 
            // datagridview_proses
            // 
            this.datagridview_proses.AllowUserToAddRows = false;
            this.datagridview_proses.AllowUserToDeleteRows = false;
            this.datagridview_proses.AllowUserToResizeColumns = false;
            this.datagridview_proses.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_proses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.datagridview_proses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_proses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_proses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_proses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Righteous", 10F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_proses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.datagridview_proses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_proses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ekle,
            this.sira});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Fredoka One", 10F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_proses.DefaultCellStyle = dataGridViewCellStyle28;
            this.datagridview_proses.EnableHeadersVisualStyles = false;
            this.datagridview_proses.Location = new System.Drawing.Point(306, 64);
            this.datagridview_proses.MultiSelect = false;
            this.datagridview_proses.Name = "datagridview_proses";
            this.datagridview_proses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_proses.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.datagridview_proses.RowHeadersWidth = 35;
            this.datagridview_proses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_proses.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.datagridview_proses.RowTemplate.Height = 39;
            this.datagridview_proses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_proses.Size = new System.Drawing.Size(525, 503);
            this.datagridview_proses.TabIndex = 103;
            this.datagridview_proses.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.datagridview_proses_CellBeginEdit);
            this.datagridview_proses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_proses_CellContentClick);
            this.datagridview_proses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_proses_CellEndEdit);
            // 
            // ekle
            // 
            this.ekle.HeaderText = "Ekle";
            this.ekle.Name = "ekle";
            this.ekle.Width = 53;
            // 
            // sira
            // 
            this.sira.HeaderText = "Sıra";
            this.sira.Name = "sira";
            this.sira.Width = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label8.Location = new System.Drawing.Point(38, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "Talimat İsmi";
            // 
            // textbox_talimat_isim
            // 
            this.textbox_talimat_isim.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_talimat_isim.ForeColor = System.Drawing.Color.Black;
            this.textbox_talimat_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_talimat_isim.Location = new System.Drawing.Point(41, 253);
            this.textbox_talimat_isim.Name = "textbox_talimat_isim";
            this.textbox_talimat_isim.Size = new System.Drawing.Size(211, 26);
            this.textbox_talimat_isim.TabIndex = 63;
            this.textbox_talimat_isim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbot_talimat_kod_KeyDown);
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(834, 30);
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
            this.label_head.Size = new System.Drawing.Size(768, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Talimat Ekle";
            this.label_head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(804, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            // 
            // button_talimat_kaydet
            // 
            this.button_talimat_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_talimat_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_talimat_kaydet.FlatAppearance.BorderSize = 0;
            this.button_talimat_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_talimat_kaydet.Font = new System.Drawing.Font("Righteous", 12F);
            this.button_talimat_kaydet.ForeColor = System.Drawing.Color.White;
            this.button_talimat_kaydet.Location = new System.Drawing.Point(41, 334);
            this.button_talimat_kaydet.Name = "button_talimat_kaydet";
            this.button_talimat_kaydet.Size = new System.Drawing.Size(211, 50);
            this.button_talimat_kaydet.TabIndex = 55;
            this.button_talimat_kaydet.Text = "Talimatı Kaydet";
            this.button_talimat_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_talimat_kaydet.UseVisualStyleBackColor = false;
            this.button_talimat_kaydet.Click += new System.EventHandler(this.button_talimat_kaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label7.Location = new System.Drawing.Point(38, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Talimat Kodu";
            // 
            // textbox_talimat_kod
            // 
            this.textbox_talimat_kod.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_talimat_kod.ForeColor = System.Drawing.Color.Black;
            this.textbox_talimat_kod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_talimat_kod.Location = new System.Drawing.Point(41, 172);
            this.textbox_talimat_kod.Name = "textbox_talimat_kod";
            this.textbox_talimat_kod.Size = new System.Drawing.Size(211, 26);
            this.textbox_talimat_kod.TabIndex = 47;
            this.textbox_talimat_kod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbot_talimat_kod_KeyDown);
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
            // checkbox_secili
            // 
            this.checkbox_secili.AutoSize = true;
            this.checkbox_secili.Checked = true;
            this.checkbox_secili.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_secili.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkbox_secili.Location = new System.Drawing.Point(306, 37);
            this.checkbox_secili.Name = "checkbox_secili";
            this.checkbox_secili.Size = new System.Drawing.Size(106, 21);
            this.checkbox_secili.TabIndex = 110;
            this.checkbox_secili.Text = "Seçili Olanlar";
            this.checkbox_secili.UseVisualStyleBackColor = true;
            this.checkbox_secili.CheckedChanged += new System.EventHandler(this.checkbox_secili_CheckedChanged);
            // 
            // Add_Talimat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Talimat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Talimat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Talimat_FormClosed);
            this.Load += new System.EventHandler(this.Add_Talimat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_proses)).EndInit();
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_talimat_isim;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Button button_talimat_kaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_talimat_kod;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView datagridview_proses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.CheckBox checkbox_secili;
    }
}