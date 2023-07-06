namespace Proje
{
    partial class UrunIslemleriForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.urunSilButton = new System.Windows.Forms.Button();
            this.urunAdiCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.urunGuncelleButton = new System.Windows.Forms.Button();
            this.urunAdiGuncelleBox = new System.Windows.Forms.ComboBox();
            this.guncelleAdetBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guncelleFiyatBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.urunEkleButton = new System.Windows.Forms.Button();
            this.ekleAdetBox = new System.Windows.Forms.TextBox();
            this.ekleFiyatBox = new System.Windows.Forms.TextBox();
            this.ekleAdiBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urunListeleView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunListeleView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.urunSilButton);
            this.groupBox3.Controls.Add(this.urunAdiCombo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(683, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 188);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Sil";
            // 
            // urunSilButton
            // 
            this.urunSilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunSilButton.ForeColor = System.Drawing.SystemColors.Control;
            this.urunSilButton.Location = new System.Drawing.Point(102, 116);
            this.urunSilButton.Name = "urunSilButton";
            this.urunSilButton.Size = new System.Drawing.Size(90, 30);
            this.urunSilButton.TabIndex = 13;
            this.urunSilButton.Text = "Sil";
            this.urunSilButton.UseVisualStyleBackColor = false;
            this.urunSilButton.Click += new System.EventHandler(this.urunSilButton_Click);
            // 
            // urunAdiCombo
            // 
            this.urunAdiCombo.FormattingEnabled = true;
            this.urunAdiCombo.Location = new System.Drawing.Point(9, 76);
            this.urunAdiCombo.Name = "urunAdiCombo";
            this.urunAdiCombo.Size = new System.Drawing.Size(183, 21);
            this.urunAdiCombo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ürün Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.urunGuncelleButton);
            this.groupBox2.Controls.Add(this.urunAdiGuncelleBox);
            this.groupBox2.Controls.Add(this.guncelleAdetBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.guncelleFiyatBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 188);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle";
            // 
            // urunGuncelleButton
            // 
            this.urunGuncelleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunGuncelleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.urunGuncelleButton.Location = new System.Drawing.Point(195, 138);
            this.urunGuncelleButton.Name = "urunGuncelleButton";
            this.urunGuncelleButton.Size = new System.Drawing.Size(90, 30);
            this.urunGuncelleButton.TabIndex = 7;
            this.urunGuncelleButton.Text = "Güncelle";
            this.urunGuncelleButton.UseVisualStyleBackColor = false;
            this.urunGuncelleButton.Click += new System.EventHandler(this.urunGuncelleButton_Click);
            // 
            // urunAdiGuncelleBox
            // 
            this.urunAdiGuncelleBox.FormattingEnabled = true;
            this.urunAdiGuncelleBox.Location = new System.Drawing.Point(102, 25);
            this.urunAdiGuncelleBox.Name = "urunAdiGuncelleBox";
            this.urunAdiGuncelleBox.Size = new System.Drawing.Size(183, 21);
            this.urunAdiGuncelleBox.TabIndex = 12;
            // 
            // guncelleAdetBox
            // 
            this.guncelleAdetBox.Location = new System.Drawing.Point(102, 103);
            this.guncelleAdetBox.Name = "guncelleAdetBox";
            this.guncelleAdetBox.Size = new System.Drawing.Size(183, 20);
            this.guncelleAdetBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ürün Adı:";
            // 
            // guncelleFiyatBox
            // 
            this.guncelleFiyatBox.Location = new System.Drawing.Point(102, 64);
            this.guncelleFiyatBox.Name = "guncelleFiyatBox";
            this.guncelleFiyatBox.Size = new System.Drawing.Size(183, 20);
            this.guncelleFiyatBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adet";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.urunEkleButton);
            this.groupBox1.Controls.Add(this.ekleAdetBox);
            this.groupBox1.Controls.Add(this.ekleFiyatBox);
            this.groupBox1.Controls.Add(this.ekleAdiBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(22, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Resim Seç";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // urunEkleButton
            // 
            this.urunEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urunEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunEkleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.urunEkleButton.Location = new System.Drawing.Point(223, 152);
            this.urunEkleButton.Name = "urunEkleButton";
            this.urunEkleButton.Size = new System.Drawing.Size(75, 30);
            this.urunEkleButton.TabIndex = 6;
            this.urunEkleButton.Text = "Ekle";
            this.urunEkleButton.UseVisualStyleBackColor = false;
            this.urunEkleButton.Click += new System.EventHandler(this.urunEkleButton_Click);
            // 
            // ekleAdetBox
            // 
            this.ekleAdetBox.Location = new System.Drawing.Point(115, 116);
            this.ekleAdetBox.Name = "ekleAdetBox";
            this.ekleAdetBox.Size = new System.Drawing.Size(183, 20);
            this.ekleAdetBox.TabIndex = 5;
            // 
            // ekleFiyatBox
            // 
            this.ekleFiyatBox.Location = new System.Drawing.Point(115, 77);
            this.ekleFiyatBox.Name = "ekleFiyatBox";
            this.ekleFiyatBox.Size = new System.Drawing.Size(183, 20);
            this.ekleFiyatBox.TabIndex = 4;
            // 
            // ekleAdiBox
            // 
            this.ekleAdiBox.Location = new System.Drawing.Point(115, 38);
            this.ekleAdiBox.Name = "ekleAdiBox";
            this.ekleAdiBox.Size = new System.Drawing.Size(183, 20);
            this.ekleAdiBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı:";
            // 
            // urunListeleView2
            // 
            this.urunListeleView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.urunListeleView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunListeleView2.Location = new System.Drawing.Point(6, 215);
            this.urunListeleView2.Name = "urunListeleView2";
            this.urunListeleView2.Size = new System.Drawing.Size(539, 218);
            this.urunListeleView2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(785, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(589, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // UrunIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urunListeleView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunIslemleriForm";
            this.Text = "Ürün işlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UrunIslemleriForm_FormClosing);
            this.Load += new System.EventHandler(this.UrunIslemleriForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunListeleView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button urunSilButton;
        private System.Windows.Forms.ComboBox urunAdiCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button urunGuncelleButton;
        private System.Windows.Forms.ComboBox urunAdiGuncelleBox;
        private System.Windows.Forms.TextBox guncelleAdetBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox guncelleFiyatBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button urunEkleButton;
        private System.Windows.Forms.TextBox ekleAdetBox;
        private System.Windows.Forms.TextBox ekleFiyatBox;
        private System.Windows.Forms.TextBox ekleAdiBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView urunListeleView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}