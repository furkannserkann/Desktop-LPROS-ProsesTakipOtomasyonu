namespace LPROS.Forms
{
    partial class Barkod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barkod));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_giris_cikis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_fisno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_personel = new System.Windows.Forms.TextBox();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.textbox_proses = new System.Windows.Forms.TextBox();
            this.textbox_hareket = new System.Windows.Forms.TextBox();
            this.datagridview_anlikproses = new System.Windows.Forms.DataGridView();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_anlikproses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_kaydet);
            this.panel1.Controls.Add(this.datagridview_anlikproses);
            this.panel1.Controls.Add(this.textbox_hareket);
            this.panel1.Controls.Add(this.textbox_proses);
            this.panel1.Controls.Add(this.button_giris_cikis);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textbox_fisno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textbox_personel);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 573);
            this.panel1.TabIndex = 57;
            // 
            // button_giris_cikis
            // 
            this.button_giris_cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_giris_cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_giris_cikis.FlatAppearance.BorderSize = 0;
            this.button_giris_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_giris_cikis.Font = new System.Drawing.Font("Righteous", 12F);
            this.button_giris_cikis.ForeColor = System.Drawing.Color.White;
            this.button_giris_cikis.Location = new System.Drawing.Point(16, 382);
            this.button_giris_cikis.Name = "button_giris_cikis";
            this.button_giris_cikis.Size = new System.Drawing.Size(211, 50);
            this.button_giris_cikis.TabIndex = 66;
            this.button_giris_cikis.Text = "Giriş/Çıkış Onayla";
            this.button_giris_cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_giris_cikis.UseVisualStyleBackColor = false;
            this.button_giris_cikis.Click += new System.EventHandler(this.button_giris_cikis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label4.Location = new System.Drawing.Point(13, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Hareket Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Sipariş Fiş Numarası";
            // 
            // textbox_fisno
            // 
            this.textbox_fisno.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_fisno.ForeColor = System.Drawing.Color.Black;
            this.textbox_fisno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_fisno.Location = new System.Drawing.Point(16, 144);
            this.textbox_fisno.Name = "textbox_fisno";
            this.textbox_fisno.Size = new System.Drawing.Size(174, 26);
            this.textbox_fisno.TabIndex = 50;
            this.textbox_fisno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textbox_fisno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_fisno_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label2.Location = new System.Drawing.Point(13, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Proses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Personel";
            // 
            // textbox_personel
            // 
            this.textbox_personel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_personel.ForeColor = System.Drawing.Color.Black;
            this.textbox_personel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_personel.Location = new System.Drawing.Point(16, 65);
            this.textbox_personel.Name = "textbox_personel";
            this.textbox_personel.Size = new System.Drawing.Size(211, 26);
            this.textbox_personel.TabIndex = 58;
            this.textbox_personel.Text = "Furkan Yılmaz";
            this.textbox_personel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_personel_KeyPress);
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(926, 30);
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
            this.label_head.Size = new System.Drawing.Size(685, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Proses Giriş/Çıkış";
            this.label_head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(896, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            // 
            // textbox_proses
            // 
            this.textbox_proses.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_proses.ForeColor = System.Drawing.Color.Black;
            this.textbox_proses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_proses.Location = new System.Drawing.Point(16, 223);
            this.textbox_proses.Name = "textbox_proses";
            this.textbox_proses.Size = new System.Drawing.Size(211, 26);
            this.textbox_proses.TabIndex = 67;
            this.textbox_proses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_personel_KeyPress);
            // 
            // textbox_hareket
            // 
            this.textbox_hareket.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_hareket.ForeColor = System.Drawing.Color.Black;
            this.textbox_hareket.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_hareket.Location = new System.Drawing.Point(16, 302);
            this.textbox_hareket.Name = "textbox_hareket";
            this.textbox_hareket.Size = new System.Drawing.Size(211, 26);
            this.textbox_hareket.TabIndex = 68;
            this.textbox_hareket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_personel_KeyPress);
            // 
            // datagridview_anlikproses
            // 
            this.datagridview_anlikproses.AllowUserToAddRows = false;
            this.datagridview_anlikproses.AllowUserToDeleteRows = false;
            this.datagridview_anlikproses.AllowUserToResizeColumns = false;
            this.datagridview_anlikproses.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_anlikproses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.datagridview_anlikproses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_anlikproses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_anlikproses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Righteous", 10F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_anlikproses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.datagridview_anlikproses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Fredoka One", 10F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_anlikproses.DefaultCellStyle = dataGridViewCellStyle28;
            this.datagridview_anlikproses.EnableHeadersVisualStyles = false;
            this.datagridview_anlikproses.Location = new System.Drawing.Point(249, 44);
            this.datagridview_anlikproses.MultiSelect = false;
            this.datagridview_anlikproses.Name = "datagridview_anlikproses";
            this.datagridview_anlikproses.ReadOnly = true;
            this.datagridview_anlikproses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_anlikproses.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.datagridview_anlikproses.RowHeadersWidth = 35;
            this.datagridview_anlikproses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_anlikproses.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.datagridview_anlikproses.RowTemplate.Height = 39;
            this.datagridview_anlikproses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_anlikproses.Size = new System.Drawing.Size(666, 516);
            this.datagridview_anlikproses.TabIndex = 104;
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kaydet.FlatAppearance.BorderSize = 0;
            this.button_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kaydet.Font = new System.Drawing.Font("Righteous", 12F);
            this.button_kaydet.ForeColor = System.Drawing.Color.White;
            this.button_kaydet.ImageKey = "arrow3.png";
            this.button_kaydet.ImageList = this.ımageList1;
            this.button_kaydet.Location = new System.Drawing.Point(196, 144);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(31, 26);
            this.button_kaydet.TabIndex = 105;
            this.button_kaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arrow1.png");
            this.ımageList1.Images.SetKeyName(1, "arrow2.png");
            this.ımageList1.Images.SetKeyName(2, "arrow3.png");
            // 
            // Barkod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 573);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barkod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Barkod_FormClosed);
            this.Load += new System.EventHandler(this.Barkod_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_anlikproses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_giris_cikis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_fisno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_personel;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.TextBox textbox_hareket;
        private System.Windows.Forms.TextBox textbox_proses;
        private System.Windows.Forms.DataGridView datagridview_anlikproses;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.ImageList ımageList1;
    }
}