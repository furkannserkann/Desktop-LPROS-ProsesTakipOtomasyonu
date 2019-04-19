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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Talimat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridview_proses = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_temizle_isim = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textbox_ara_kod = new System.Windows.Forms.TextBox();
            this.textbox_ara_isim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textbot_talimat_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.button_talimat_kaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textbot_talimat_kod = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.datagridview_proses);
            this.panel1.Controls.Add(this.button_temizle_isim);
            this.panel1.Controls.Add(this.textbox_ara_kod);
            this.panel1.Controls.Add(this.textbox_ara_isim);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textbot_talimat_isim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.button_talimat_kaydet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textbot_talimat_kod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 496);
            this.panel1.TabIndex = 44;
            // 
            // datagridview_proses
            // 
            this.datagridview_proses.AllowUserToAddRows = false;
            this.datagridview_proses.AllowUserToDeleteRows = false;
            this.datagridview_proses.AllowUserToResizeColumns = false;
            this.datagridview_proses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_proses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_proses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_proses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_proses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_proses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Righteous", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_proses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_proses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_proses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ekle,
            this.sira});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Fredoka One", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_proses.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_proses.EnableHeadersVisualStyles = false;
            this.datagridview_proses.Location = new System.Drawing.Point(306, 90);
            this.datagridview_proses.MultiSelect = false;
            this.datagridview_proses.Name = "datagridview_proses";
            this.datagridview_proses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_proses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_proses.RowHeadersWidth = 35;
            this.datagridview_proses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_proses.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview_proses.RowTemplate.Height = 39;
            this.datagridview_proses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_proses.Size = new System.Drawing.Size(525, 401);
            this.datagridview_proses.TabIndex = 103;
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
            this.button_temizle_isim.ImageKey = "icons8-broom-96.png";
            this.button_temizle_isim.ImageList = this.ımageList1;
            this.button_temizle_isim.Location = new System.Drawing.Point(657, 61);
            this.button_temizle_isim.Name = "button_temizle_isim";
            this.button_temizle_isim.Size = new System.Drawing.Size(41, 23);
            this.button_temizle_isim.TabIndex = 102;
            this.button_temizle_isim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_temizle_isim.UseVisualStyleBackColor = false;
            this.button_temizle_isim.Click += new System.EventHandler(this.button_temizle_isim_Click);
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
            // textbox_ara_kod
            // 
            this.textbox_ara_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textbox_ara_kod.ForeColor = System.Drawing.Color.Black;
            this.textbox_ara_kod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_ara_kod.Location = new System.Drawing.Point(306, 61);
            this.textbox_ara_kod.Name = "textbox_ara_kod";
            this.textbox_ara_kod.Size = new System.Drawing.Size(139, 23);
            this.textbox_ara_kod.TabIndex = 100;
            this.textbox_ara_kod.TextChanged += new System.EventHandler(this.textbox_ara_kod_TextChanged);
            // 
            // textbox_ara_isim
            // 
            this.textbox_ara_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.textbox_ara_isim.ForeColor = System.Drawing.Color.Black;
            this.textbox_ara_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_ara_isim.Location = new System.Drawing.Point(457, 61);
            this.textbox_ara_isim.Name = "textbox_ara_isim";
            this.textbox_ara_isim.Size = new System.Drawing.Size(193, 23);
            this.textbox_ara_isim.TabIndex = 98;
            this.textbox_ara_isim.TextChanged += new System.EventHandler(this.textbox_ara_isim_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label3.Location = new System.Drawing.Point(303, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Proses Kodu:";
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
            // textbot_talimat_isim
            // 
            this.textbot_talimat_isim.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbot_talimat_isim.ForeColor = System.Drawing.Color.Black;
            this.textbot_talimat_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbot_talimat_isim.Location = new System.Drawing.Point(41, 253);
            this.textbot_talimat_isim.Name = "textbot_talimat_isim";
            this.textbot_talimat_isim.Size = new System.Drawing.Size(211, 26);
            this.textbot_talimat_isim.TabIndex = 63;
            this.textbot_talimat_isim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbot_talimat_kod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label1.Location = new System.Drawing.Point(454, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 91;
            this.label1.Text = "Proses İsmi:";
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
            // textbot_talimat_kod
            // 
            this.textbot_talimat_kod.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbot_talimat_kod.ForeColor = System.Drawing.Color.Black;
            this.textbot_talimat_kod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbot_talimat_kod.Location = new System.Drawing.Point(41, 172);
            this.textbot_talimat_kod.Name = "textbot_talimat_kod";
            this.textbot_talimat_kod.Size = new System.Drawing.Size(211, 26);
            this.textbot_talimat_kod.TabIndex = 47;
            this.textbot_talimat_kod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbot_talimat_kod_KeyDown);
            // 
            // Add_Talimat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 496);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Talimat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Talimat";
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
        private System.Windows.Forms.TextBox textbot_talimat_isim;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Button button_talimat_kaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbot_talimat_kod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button_temizle_isim;
        private System.Windows.Forms.TextBox textbox_ara_kod;
        private System.Windows.Forms.TextBox textbox_ara_isim;
        private System.Windows.Forms.DataGridView datagridview_proses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn sira;
    }
}