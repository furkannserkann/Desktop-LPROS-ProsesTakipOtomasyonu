﻿namespace LPROS.Forms_Panel_Control
{
    partial class YetkiRenkControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiRenkControl));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button_renk_guncelle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_renk_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label4.Location = new System.Drawing.Point(271, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 84;
            this.label4.Text = "Renk İsmi:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox4.Location = new System.Drawing.Point(346, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 25);
            this.textBox4.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Righteous", 9.5F);
            this.label5.Location = new System.Drawing.Point(264, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "Renk Kodu:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Montserrat", 10.5F);
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox5.Location = new System.Drawing.Point(346, 7);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(131, 25);
            this.textBox5.TabIndex = 81;
            // 
            // button_renk_guncelle
            // 
            this.button_renk_guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_renk_guncelle.BackColor = System.Drawing.Color.Brown;
            this.button_renk_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_renk_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_renk_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_renk_guncelle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_renk_guncelle.ForeColor = System.Drawing.Color.White;
            this.button_renk_guncelle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_renk_guncelle.ImageKey = "icons8-pencil-96.png";
            this.button_renk_guncelle.ImageList = this.ımageList1;
            this.button_renk_guncelle.Location = new System.Drawing.Point(12, 41);
            this.button_renk_guncelle.Name = "button_renk_guncelle";
            this.button_renk_guncelle.Size = new System.Drawing.Size(160, 28);
            this.button_renk_guncelle.TabIndex = 91;
            this.button_renk_guncelle.Text = "   Güncelle";
            this.button_renk_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_renk_guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_renk_guncelle.UseVisualStyleBackColor = false;
            this.button_renk_guncelle.Click += new System.EventHandler(this.button_renk_guncelle_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Righteous", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.ImageKey = "icons8-broom-96.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(591, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 28);
            this.button3.TabIndex = 88;
            this.button3.Text = "   Temizle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Righteous", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.ImageKey = "icons8-search-208.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(591, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 28);
            this.button4.TabIndex = 87;
            this.button4.Text = "   Ara";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.Brown;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Righteous", 10F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.ImageKey = "icons8-delete-90.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(95, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 28);
            this.button5.TabIndex = 86;
            this.button5.Text = "   Sil";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button_renk_ekle
            // 
            this.button_renk_ekle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button_renk_ekle.BackColor = System.Drawing.Color.Brown;
            this.button_renk_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_renk_ekle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_renk_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_renk_ekle.Font = new System.Drawing.Font("Righteous", 10F);
            this.button_renk_ekle.ForeColor = System.Drawing.Color.White;
            this.button_renk_ekle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_renk_ekle.ImageKey = "icons8-plus-math-90.png";
            this.button_renk_ekle.ImageList = this.ımageList1;
            this.button_renk_ekle.Location = new System.Drawing.Point(12, 7);
            this.button_renk_ekle.Name = "button_renk_ekle";
            this.button_renk_ekle.Size = new System.Drawing.Size(77, 28);
            this.button_renk_ekle.TabIndex = 85;
            this.button_renk_ekle.Text = "   Ekle";
            this.button_renk_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_renk_ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_renk_ekle.UseVisualStyleBackColor = false;
            this.button_renk_ekle.Click += new System.EventHandler(this.button_eklerenk_Click);
            // 
            // YetkiRenkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 77);
            this.Controls.Add(this.button_renk_guncelle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_renk_ekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YetkiRenkControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YetkiRenkControl";
            this.Load += new System.EventHandler(this.YetkiRenkControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_renk_ekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button_renk_guncelle;
    }
}