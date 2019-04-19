namespace LPROS.Forms_Panel
{
    partial class HastanelerDoktorlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastanelerDoktorlar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox_transfer = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridview_hastane = new System.Windows.Forms.DataGridView();
            this.datagridview_doktor = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.duzenle = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_transfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_hastane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_doktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_transfer
            // 
            this.pictureBox_transfer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_transfer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_transfer.Image")));
            this.pictureBox_transfer.Location = new System.Drawing.Point(263, 225);
            this.pictureBox_transfer.Name = "pictureBox_transfer";
            this.pictureBox_transfer.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_transfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_transfer.TabIndex = 2;
            this.pictureBox_transfer.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 12F);
            this.label4.Location = new System.Drawing.Point(-1, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Hastaneler";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Righteous", 12F);
            this.label1.Location = new System.Drawing.Point(315, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Doktorlar";
            // 
            // datagridview_hastane
            // 
            this.datagridview_hastane.AllowUserToAddRows = false;
            this.datagridview_hastane.AllowUserToDeleteRows = false;
            this.datagridview_hastane.AllowUserToResizeRows = false;
            this.datagridview_hastane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_hastane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridview_hastane.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_hastane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Righteous", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_hastane.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_hastane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_hastane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.update});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Fredoka One", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_hastane.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_hastane.EnableHeadersVisualStyles = false;
            this.datagridview_hastane.Location = new System.Drawing.Point(3, 30);
            this.datagridview_hastane.MultiSelect = false;
            this.datagridview_hastane.Name = "datagridview_hastane";
            this.datagridview_hastane.ReadOnly = true;
            this.datagridview_hastane.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_hastane.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview_hastane.RowHeadersWidth = 35;
            this.datagridview_hastane.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_hastane.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview_hastane.RowTemplate.Height = 45;
            this.datagridview_hastane.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_hastane.Size = new System.Drawing.Size(218, 466);
            this.datagridview_hastane.TabIndex = 45;
            this.datagridview_hastane.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_hastane_CellClick);
            this.datagridview_hastane.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridview_hastane_CellMouseClick);
            // 
            // datagridview_doktor
            // 
            this.datagridview_doktor.AllowUserToAddRows = false;
            this.datagridview_doktor.AllowUserToDeleteRows = false;
            this.datagridview_doktor.AllowUserToResizeColumns = false;
            this.datagridview_doktor.AllowUserToResizeRows = false;
            this.datagridview_doktor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridview_doktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview_doktor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.datagridview_doktor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Righteous", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_doktor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridview_doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_doktor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.duzenle});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Fredoka One", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_doktor.DefaultCellStyle = dataGridViewCellStyle8;
            this.datagridview_doktor.EnableHeadersVisualStyles = false;
            this.datagridview_doktor.Location = new System.Drawing.Point(319, 30);
            this.datagridview_doktor.MultiSelect = false;
            this.datagridview_doktor.Name = "datagridview_doktor";
            this.datagridview_doktor.ReadOnly = true;
            this.datagridview_doktor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_doktor.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridview_doktor.RowHeadersWidth = 35;
            this.datagridview_doktor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_doktor.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridview_doktor.RowTemplate.Height = 45;
            this.datagridview_doktor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview_doktor.Size = new System.Drawing.Size(435, 466);
            this.datagridview_doktor.TabIndex = 47;
            this.datagridview_doktor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_doktor_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // update
            // 
            this.update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Righteous", 10F);
            this.update.DefaultCellStyle = dataGridViewCellStyle2;
            this.update.HeaderText = "Düzenle";
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.update.Text = "Düzenle";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 96;
            // 
            // duzenle
            // 
            this.duzenle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Righteous", 10F);
            this.duzenle.DefaultCellStyle = dataGridViewCellStyle7;
            this.duzenle.HeaderText = "Düzenle";
            this.duzenle.Name = "duzenle";
            this.duzenle.ReadOnly = true;
            this.duzenle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseColumnTextForButtonValue = true;
            this.duzenle.Width = 96;
            // 
            // HastanelerDoktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.datagridview_doktor);
            this.Controls.Add(this.datagridview_hastane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_transfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastanelerDoktorlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastanelerDoktorlar";
            this.Load += new System.EventHandler(this.HastanelerDoktorlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_transfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_hastane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_doktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_transfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridview_hastane;
        private System.Windows.Forms.DataGridView datagridview_doktor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn duzenle;
    }
}