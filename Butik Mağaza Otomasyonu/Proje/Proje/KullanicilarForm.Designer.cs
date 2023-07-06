namespace Proje
{
    partial class KullanicilarForm
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.kullanicilarCombo = new System.Windows.Forms.ComboBox();
            this.kullaniciSilButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kullaniciEkleButton = new System.Windows.Forms.Button();
            this.kullaniciEkleSifre = new System.Windows.Forms.TextBox();
            this.kullaniciEkleAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.kullanicilarCombo);
            this.groupBox5.Controls.Add(this.kullaniciSilButton);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(29, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 188);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kullanıcı Sil";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // kullanicilarCombo
            // 
            this.kullanicilarCombo.FormattingEnabled = true;
            this.kullanicilarCombo.Location = new System.Drawing.Point(152, 63);
            this.kullanicilarCombo.Name = "kullanicilarCombo";
            this.kullanicilarCombo.Size = new System.Drawing.Size(146, 21);
            this.kullanicilarCombo.TabIndex = 7;
            // 
            // kullaniciSilButton
            // 
            this.kullaniciSilButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kullaniciSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciSilButton.ForeColor = System.Drawing.SystemColors.Control;
            this.kullaniciSilButton.Location = new System.Drawing.Point(223, 110);
            this.kullaniciSilButton.Name = "kullaniciSilButton";
            this.kullaniciSilButton.Size = new System.Drawing.Size(75, 30);
            this.kullaniciSilButton.TabIndex = 6;
            this.kullaniciSilButton.Text = "Sil";
            this.kullaniciSilButton.UseVisualStyleBackColor = false;
            this.kullaniciSilButton.Click += new System.EventHandler(this.kullaniciSilButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(26, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = " Kullancı Adı:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.kullaniciEkleButton);
            this.groupBox4.Controls.Add(this.kullaniciEkleSifre);
            this.groupBox4.Controls.Add(this.kullaniciEkleAdi);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(29, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 188);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kullanıcı Ekle";
            // 
            // kullaniciEkleButton
            // 
            this.kullaniciEkleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kullaniciEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciEkleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.kullaniciEkleButton.Location = new System.Drawing.Point(223, 115);
            this.kullaniciEkleButton.Name = "kullaniciEkleButton";
            this.kullaniciEkleButton.Size = new System.Drawing.Size(75, 30);
            this.kullaniciEkleButton.TabIndex = 6;
            this.kullaniciEkleButton.Text = "Ekle";
            this.kullaniciEkleButton.UseVisualStyleBackColor = false;
            this.kullaniciEkleButton.Click += new System.EventHandler(this.kullaniciEkleButton_Click);
            // 
            // kullaniciEkleSifre
            // 
            this.kullaniciEkleSifre.Location = new System.Drawing.Point(115, 77);
            this.kullaniciEkleSifre.Name = "kullaniciEkleSifre";
            this.kullaniciEkleSifre.PasswordChar = '*';
            this.kullaniciEkleSifre.Size = new System.Drawing.Size(183, 20);
            this.kullaniciEkleSifre.TabIndex = 4;
            // 
            // kullaniciEkleAdi
            // 
            this.kullaniciEkleAdi.Location = new System.Drawing.Point(116, 34);
            this.kullaniciEkleAdi.Name = "kullaniciEkleAdi";
            this.kullaniciEkleAdi.Size = new System.Drawing.Size(183, 20);
            this.kullaniciEkleAdi.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(57, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Şifre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(19, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = " Kullancı Adı:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(394, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 391);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı:";
            this.columnHeader1.Width = 211;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(534, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KullanicilarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.hehe;
            this.ClientSize = new System.Drawing.Size(647, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullanicilarForm";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.KullanicilarForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox kullanicilarCombo;
        private System.Windows.Forms.Button kullaniciSilButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button kullaniciEkleButton;
        private System.Windows.Forms.TextBox kullaniciEkleSifre;
        private System.Windows.Forms.TextBox kullaniciEkleAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
    }
}