namespace LPROS.Forms
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_head = new System.Windows.Forms.Panel();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_forms = new System.Windows.Forms.Panel();
            this.datagridview_Siparis = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_ara = new System.Windows.Forms.Button();
            this.datepicker_tarihson = new System.Windows.Forms.DateTimePicker();
            this.datepicker_tarihbas = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_forms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Siparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.pictureBox_minimize);
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1364, 30);
            this.panel_head.TabIndex = 56;
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_minimize.Image")));
            this.pictureBox_minimize.Location = new System.Drawing.Point(1298, 0);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Padding = new System.Windows.Forms.Padding(7, 10, 7, 0);
            this.pictureBox_minimize.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_minimize.TabIndex = 17;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            // 
            // label_head
            // 
            this.label_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_head.Font = new System.Drawing.Font("Righteous", 12F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(12, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(1280, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Raporlar";
            this.label_head.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(1334, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel_forms);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 728);
            this.panel1.TabIndex = 58;
            // 
            // panel_forms
            // 
            this.panel_forms.Controls.Add(this.label1);
            this.panel_forms.Controls.Add(this.checkBox1);
            this.panel_forms.Controls.Add(this.datepicker_tarihson);
            this.panel_forms.Controls.Add(this.datepicker_tarihbas);
            this.panel_forms.Controls.Add(this.datagridview_Siparis);
            this.panel_forms.Controls.Add(this.label8);
            this.panel_forms.Controls.Add(this.pictureBox1);
            this.panel_forms.Controls.Add(this.button_ara);
            this.panel_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_forms.Location = new System.Drawing.Point(0, 30);
            this.panel_forms.Name = "panel_forms";
            this.panel_forms.Size = new System.Drawing.Size(1364, 696);
            this.panel_forms.TabIndex = 58;
            // 
            // datagridview_Siparis
            // 
            this.datagridview_Siparis.AllowUserToAddRows = false;
            this.datagridview_Siparis.AllowUserToDeleteRows = false;
            this.datagridview_Siparis.AllowUserToResizeColumns = false;
            this.datagridview_Siparis.AllowUserToResizeRows = false;
            this.datagridview_Siparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.datagridview_Siparis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_Siparis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview_Siparis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Siparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridview_Siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Yu Gothic", 9.1F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(7);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_Siparis.DefaultCellStyle = dataGridViewCellStyle10;
            this.datagridview_Siparis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridview_Siparis.EnableHeadersVisualStyles = false;
            this.datagridview_Siparis.Location = new System.Drawing.Point(0, 369);
            this.datagridview_Siparis.MultiSelect = false;
            this.datagridview_Siparis.Name = "datagridview_Siparis";
            this.datagridview_Siparis.ReadOnly = true;
            this.datagridview_Siparis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Siparis.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datagridview_Siparis.RowHeadersWidth = 35;
            this.datagridview_Siparis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_Siparis.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.datagridview_Siparis.RowTemplate.Height = 45;
            this.datagridview_Siparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_Siparis.Size = new System.Drawing.Size(1364, 327);
            this.datagridview_Siparis.TabIndex = 170;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label8.Location = new System.Drawing.Point(1112, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 169;
            this.label8.Text = "Pasta Grafiği gelsin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(999, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 274);
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // button_ara
            // 
            this.button_ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ara.FlatAppearance.BorderSize = 0;
            this.button_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ara.Font = new System.Drawing.Font("Righteous", 12F);
            this.button_ara.ForeColor = System.Drawing.Color.White;
            this.button_ara.Location = new System.Drawing.Point(579, 44);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(354, 50);
            this.button_ara.TabIndex = 167;
            this.button_ara.Text = "Raporu Göster";
            this.button_ara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ara.UseVisualStyleBackColor = false;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // datepicker_tarihson
            // 
            this.datepicker_tarihson.Checked = false;
            this.datepicker_tarihson.Enabled = false;
            this.datepicker_tarihson.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_tarihson.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_tarihson.Location = new System.Drawing.Point(267, 54);
            this.datepicker_tarihson.Name = "datepicker_tarihson";
            this.datepicker_tarihson.Size = new System.Drawing.Size(211, 29);
            this.datepicker_tarihson.TabIndex = 182;
            // 
            // datepicker_tarihbas
            // 
            this.datepicker_tarihbas.Checked = false;
            this.datepicker_tarihbas.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.datepicker_tarihbas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicker_tarihbas.Location = new System.Drawing.Point(30, 54);
            this.datepicker_tarihbas.Name = "datepicker_tarihbas";
            this.datepicker_tarihbas.Size = new System.Drawing.Size(211, 29);
            this.datepicker_tarihbas.TabIndex = 178;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.checkBox1.Location = new System.Drawing.Point(267, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 21);
            this.checkBox1.TabIndex = 188;
            this.checkBox1.Text = "Tarih 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 189;
            this.label1.Text = "label1";
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 728);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Raporlar_FormClosed);
            this.Load += new System.EventHandler(this.Raporlar_Load);
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_forms.ResumeLayout(false);
            this.panel_forms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_Siparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.Panel panel_forms;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView datagridview_Siparis;
        private System.Windows.Forms.DateTimePicker datepicker_tarihson;
        private System.Windows.Forms.DateTimePicker datepicker_tarihbas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}