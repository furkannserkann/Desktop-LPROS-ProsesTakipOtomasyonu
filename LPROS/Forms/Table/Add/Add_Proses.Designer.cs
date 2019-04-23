namespace LPROS.Forms.Table.Add
{
    partial class Add_Proses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Proses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.datagridview_malzeme = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_proses_isim = new System.Windows.Forms.TextBox();
            this.button_proses_kaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_proses_kod = new System.Windows.Forms.TextBox();
            this.checkbox_secili = new System.Windows.Forms.CheckBox();
            this.ekle = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_malzeme)).BeginInit();
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
            this.panel_head.Size = new System.Drawing.Size(834, 30);
            this.panel_head.TabIndex = 56;
            // 
            // label_head
            // 
            this.label_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_head.Font = new System.Drawing.Font("Righteous", 12F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(11, -1);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(786, 31);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Proses Ekle";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkbox_secili);
            this.panel1.Controls.Add(this.datagridview_malzeme);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textbox_proses_isim);
            this.panel1.Controls.Add(this.button_proses_kaydet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbox_proses_kod);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 572);
            this.panel1.TabIndex = 43;
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
            // datagridview_malzeme
            // 
            this.datagridview_malzeme.AllowUserToAddRows = false;
            this.datagridview_malzeme.AllowUserToDeleteRows = false;
            this.datagridview_malzeme.AllowUserToResizeColumns = false;
            this.datagridview_malzeme.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_malzeme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.datagridview_malzeme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_malzeme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_malzeme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_malzeme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Righteous", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_malzeme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.datagridview_malzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_malzeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ekle,
            this.adet});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Fredoka One", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_malzeme.DefaultCellStyle = dataGridViewCellStyle18;
            this.datagridview_malzeme.EnableHeadersVisualStyles = false;
            this.datagridview_malzeme.Location = new System.Drawing.Point(306, 64);
            this.datagridview_malzeme.MultiSelect = false;
            this.datagridview_malzeme.Name = "datagridview_malzeme";
            this.datagridview_malzeme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_malzeme.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.datagridview_malzeme.RowHeadersWidth = 35;
            this.datagridview_malzeme.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_malzeme.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.datagridview_malzeme.RowTemplate.Height = 39;
            this.datagridview_malzeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_malzeme.Size = new System.Drawing.Size(525, 503);
            this.datagridview_malzeme.TabIndex = 113;
            this.datagridview_malzeme.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.datagridview_malzeme_CellBeginEdit);
            this.datagridview_malzeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_malzeme_CellContentClick);
            this.datagridview_malzeme.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_malzeme_CellEndEdit);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label8.Location = new System.Drawing.Point(38, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 108;
            this.label8.Text = "Proses İsmi";
            // 
            // textbox_proses_isim
            // 
            this.textbox_proses_isim.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_proses_isim.ForeColor = System.Drawing.Color.Black;
            this.textbox_proses_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_proses_isim.Location = new System.Drawing.Point(41, 253);
            this.textbox_proses_isim.Name = "textbox_proses_isim";
            this.textbox_proses_isim.Size = new System.Drawing.Size(211, 26);
            this.textbox_proses_isim.TabIndex = 107;
            // 
            // button_proses_kaydet
            // 
            this.button_proses_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_proses_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_proses_kaydet.FlatAppearance.BorderSize = 0;
            this.button_proses_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_proses_kaydet.Font = new System.Drawing.Font("Righteous", 12F);
            this.button_proses_kaydet.ForeColor = System.Drawing.Color.White;
            this.button_proses_kaydet.Location = new System.Drawing.Point(41, 334);
            this.button_proses_kaydet.Name = "button_proses_kaydet";
            this.button_proses_kaydet.Size = new System.Drawing.Size(211, 50);
            this.button_proses_kaydet.TabIndex = 106;
            this.button_proses_kaydet.Text = "Proses Kaydet";
            this.button_proses_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_proses_kaydet.UseVisualStyleBackColor = false;
            this.button_proses_kaydet.Click += new System.EventHandler(this.button_proses_kaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label7.Location = new System.Drawing.Point(38, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Proses Kodu";
            // 
            // textbox_proses_kod
            // 
            this.textbox_proses_kod.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_proses_kod.ForeColor = System.Drawing.Color.Black;
            this.textbox_proses_kod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_proses_kod.Location = new System.Drawing.Point(41, 172);
            this.textbox_proses_kod.Name = "textbox_proses_kod";
            this.textbox_proses_kod.Size = new System.Drawing.Size(211, 26);
            this.textbox_proses_kod.TabIndex = 104;
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
            this.checkbox_secili.TabIndex = 114;
            this.checkbox_secili.Text = "Seçili Olanlar";
            this.checkbox_secili.UseVisualStyleBackColor = true;
            this.checkbox_secili.Visible = false;
            this.checkbox_secili.CheckedChanged += new System.EventHandler(this.checkbox_secili_CheckedChanged);
            // 
            // ekle
            // 
            this.ekle.HeaderText = "Ekle";
            this.ekle.Name = "ekle";
            this.ekle.Width = 53;
            // 
            // adet
            // 
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            this.adet.Width = 76;
            // 
            // Add_Proses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Proses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Proses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Proses_FormClosed);
            this.Load += new System.EventHandler(this.Add_Proses_Load);
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_malzeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridview_malzeme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_proses_isim;
        private System.Windows.Forms.Button button_proses_kaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_proses_kod;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.CheckBox checkbox_secili;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
    }
}