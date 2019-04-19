namespace LPROS.Forms
{
    partial class CustomMessageDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_baslık = new System.Windows.Forms.Label();
            this.panel_head = new System.Windows.Forms.Panel();
            this.label_head = new System.Windows.Forms.Label();
            this.label_mesaj = new System.Windows.Forms.Label();
            this.button_onayla = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_baslık);
            this.panel1.Controls.Add(this.panel_head);
            this.panel1.Controls.Add(this.label_mesaj);
            this.panel1.Controls.Add(this.button_onayla);
            this.panel1.Controls.Add(this.button_iptal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 204);
            this.panel1.TabIndex = 0;
            // 
            // label_baslık
            // 
            this.label_baslık.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_baslık.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_baslık.Location = new System.Drawing.Point(11, 36);
            this.label_baslık.Name = "label_baslık";
            this.label_baslık.Size = new System.Drawing.Size(387, 30);
            this.label_baslık.TabIndex = 60;
            this.label_baslık.Text = "Başlık";
            this.label_baslık.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_head
            // 
            this.panel_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel_head.Controls.Add(this.label_head);
            this.panel_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_head.Location = new System.Drawing.Point(0, 0);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(412, 30);
            this.panel_head.TabIndex = 59;
            // 
            // label_head
            // 
            this.label_head.Font = new System.Drawing.Font("Orator Std", 15F);
            this.label_head.ForeColor = System.Drawing.Color.White;
            this.label_head.Location = new System.Drawing.Point(11, 0);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(390, 30);
            this.label_head.TabIndex = 16;
            this.label_head.Text = "Dikkat";
            // 
            // label_mesaj
            // 
            this.label_mesaj.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label_mesaj.Location = new System.Drawing.Point(8, 80);
            this.label_mesaj.Name = "label_mesaj";
            this.label_mesaj.Size = new System.Drawing.Size(390, 69);
            this.label_mesaj.TabIndex = 58;
            this.label_mesaj.Text = "Mesaj";
            this.label_mesaj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_onayla
            // 
            this.button_onayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_onayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_onayla.FlatAppearance.BorderSize = 0;
            this.button_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_onayla.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.button_onayla.ForeColor = System.Drawing.Color.White;
            this.button_onayla.Location = new System.Drawing.Point(225, 157);
            this.button_onayla.Name = "button_onayla";
            this.button_onayla.Size = new System.Drawing.Size(176, 34);
            this.button_onayla.TabIndex = 57;
            this.button_onayla.Text = "Onayla";
            this.button_onayla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_onayla.UseVisualStyleBackColor = false;
            this.button_onayla.Click += new System.EventHandler(this.button_onayla_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button_iptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_iptal.FlatAppearance.BorderSize = 0;
            this.button_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_iptal.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.button_iptal.ForeColor = System.Drawing.Color.White;
            this.button_iptal.Location = new System.Drawing.Point(11, 157);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(175, 34);
            this.button_iptal.TabIndex = 56;
            this.button_iptal.Text = "İptal Et";
            this.button_iptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_iptal.UseVisualStyleBackColor = false;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // CustomMessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 204);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uyarı";
            this.Load += new System.EventHandler(this.MessageDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel_head.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_onayla;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.Label label_mesaj;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.Label label_baslık;
    }
}