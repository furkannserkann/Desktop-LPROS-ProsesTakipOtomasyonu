﻿namespace LPROS.Forms.Table.Add
{
    partial class Add_Yetki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Yetki));
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel_head.Size = new System.Drawing.Size(312, 30);
            this.panel_head.TabIndex = 56;
            // 
            // label_head
            // 
            this.label_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_head.Font = new System.Drawing.Font("Orator Std", 15F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(12, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(246, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Yetki Ekle";
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_close.Image")));
            this.pictureBox_close.Location = new System.Drawing.Point(282, 0);
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
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.textBox_isim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 253);
            this.panel1.TabIndex = 45;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(48, 166);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(211, 34);
            this.button9.TabIndex = 58;
            this.button9.Text = "Yetki Türünü Kaydet";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label7.Location = new System.Drawing.Point(45, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Yetki İsmi";
            // 
            // textBox_isim
            // 
            this.textBox_isim.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_isim.ForeColor = System.Drawing.Color.Black;
            this.textBox_isim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_isim.Location = new System.Drawing.Point(48, 101);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(211, 26);
            this.textBox_isim.TabIndex = 56;
            // 
            // Add_Yetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 253);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Yetki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Yetki";
            this.Load += new System.EventHandler(this.Add_Yetki_Load);
            this.panel_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_isim;
    }
}