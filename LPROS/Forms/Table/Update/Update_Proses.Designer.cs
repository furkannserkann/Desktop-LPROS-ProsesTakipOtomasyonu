namespace LPROS.Forms.Table.Update
{
    partial class Update_Proses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Proses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_kod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_isim);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.button_guncelle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_kod);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 306);
            this.panel1.TabIndex = 44;
            // 
            // textBox_isim
            // 
            this.textBox_isim.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.textBox_isim.ForeColor = System.Drawing.Color.Black;
            this.textBox_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_isim.Location = new System.Drawing.Point(48, 155);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(211, 26);
            this.textBox_isim.TabIndex = 48;
            this.textBox_isim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.update_KeyDown);
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Controls.Add(this.pictureBox_close);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(309, 30);
            this.panel_head.TabIndex = 56;
            // 
            // label_head
            // 
            this.label_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_head.Font = new System.Drawing.Font("Orator Std", 15F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(12, 3);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(261, 26);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Proses Güncelle";
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(279, 0);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_close.TabIndex = 0;
            this.pictureBox_close.TabStop = false;
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_guncelle.FlatAppearance.BorderSize = 0;
            this.button_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guncelle.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.button_guncelle.ForeColor = System.Drawing.Color.White;
            this.button_guncelle.Location = new System.Drawing.Point(48, 231);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(211, 34);
            this.button_guncelle.TabIndex = 55;
            this.button_guncelle.Text = "Proses Bilgilerini Güncelle";
            this.button_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label7.Location = new System.Drawing.Point(45, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Proses Kodu";
            // 
            // textBox_kod
            // 
            this.textBox_kod.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.textBox_kod.ForeColor = System.Drawing.Color.Black;
            this.textBox_kod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_kod.Location = new System.Drawing.Point(48, 101);
            this.textBox_kod.Name = "textBox_kod";
            this.textBox_kod.Size = new System.Drawing.Size(211, 26);
            this.textBox_kod.TabIndex = 47;
            this.textBox_kod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.update_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label4.Location = new System.Drawing.Point(45, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Proses İsmi";
            // 
            // Update_Proses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Proses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Proses";
            this.Load += new System.EventHandler(this.Update_Proses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_kod;
        private System.Windows.Forms.Label label4;
    }
}