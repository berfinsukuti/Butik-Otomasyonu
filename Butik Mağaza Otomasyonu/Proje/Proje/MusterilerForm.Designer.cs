namespace Proje
{
    partial class MusterilerForm
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.musteriAdiCombo = new System.Windows.Forms.ComboBox();
            this.musteriSil = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.msuteriEkleAdres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.musteriEkleButton = new System.Windows.Forms.Button();
            this.musteriEkleTelefon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.musteriEkleSoyadi = new System.Windows.Forms.TextBox();
            this.musteriEkleAdi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tumMusterilerView = new System.Windows.Forms.DataGridView();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumMusterilerView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox7.Controls.Add(this.musteriAdiCombo);
            this.groupBox7.Controls.Add(this.musteriSil);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Location = new System.Drawing.Point(695, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(210, 168);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Müteri Sil";
            // 
            // musteriAdiCombo
            // 
            this.musteriAdiCombo.FormattingEnabled = true;
            this.musteriAdiCombo.Location = new System.Drawing.Point(19, 57);
            this.musteriAdiCombo.Name = "musteriAdiCombo";
            this.musteriAdiCombo.Size = new System.Drawing.Size(175, 21);
            this.musteriAdiCombo.TabIndex = 7;
            // 
            // musteriSil
            // 
            this.musteriSil.BackColor = System.Drawing.Color.Black;
            this.musteriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriSil.ForeColor = System.Drawing.SystemColors.Control;
            this.musteriSil.Location = new System.Drawing.Point(119, 91);
            this.musteriSil.Name = "musteriSil";
            this.musteriSil.Size = new System.Drawing.Size(75, 30);
            this.musteriSil.TabIndex = 6;
            this.musteriSil.Text = "Sil";
            this.musteriSil.UseVisualStyleBackColor = false;
            this.musteriSil.Click += new System.EventHandler(this.musteriSil_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(19, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Müşteri Telefon:";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox6.Controls.Add(this.msuteriEkleAdres);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.musteriEkleButton);
            this.groupBox6.Controls.Add(this.musteriEkleTelefon);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.musteriEkleSoyadi);
            this.groupBox6.Controls.Add(this.musteriEkleAdi);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(15, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(620, 168);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Müşteri Kayıt";
            // 
            // msuteriEkleAdres
            // 
            this.msuteriEkleAdres.Location = new System.Drawing.Point(314, 34);
            this.msuteriEkleAdres.Multiline = true;
            this.msuteriEkleAdres.Name = "msuteriEkleAdres";
            this.msuteriEkleAdres.Size = new System.Drawing.Size(277, 110);
            this.msuteriEkleAdres.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(258, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 18);
            this.label17.TabIndex = 9;
            this.label17.Text = "Adres:";
            // 
            // musteriEkleButton
            // 
            this.musteriEkleButton.BackColor = System.Drawing.Color.Black;
            this.musteriEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriEkleButton.ForeColor = System.Drawing.SystemColors.Control;
            this.musteriEkleButton.Location = new System.Drawing.Point(177, 132);
            this.musteriEkleButton.Name = "musteriEkleButton";
            this.musteriEkleButton.Size = new System.Drawing.Size(75, 30);
            this.musteriEkleButton.TabIndex = 6;
            this.musteriEkleButton.Text = "Ekle";
            this.musteriEkleButton.UseVisualStyleBackColor = false;
            this.musteriEkleButton.Click += new System.EventHandler(this.musteriEkleButton_Click);
            // 
            // musteriEkleTelefon
            // 
            this.musteriEkleTelefon.Location = new System.Drawing.Point(69, 100);
            this.musteriEkleTelefon.Name = "musteriEkleTelefon";
            this.musteriEkleTelefon.Size = new System.Drawing.Size(183, 20);
            this.musteriEkleTelefon.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 18);
            this.label16.TabIndex = 7;
            this.label16.Text = "Telefon:";
            // 
            // musteriEkleSoyadi
            // 
            this.musteriEkleSoyadi.Location = new System.Drawing.Point(69, 66);
            this.musteriEkleSoyadi.Name = "musteriEkleSoyadi";
            this.musteriEkleSoyadi.Size = new System.Drawing.Size(183, 20);
            this.musteriEkleSoyadi.TabIndex = 4;
            // 
            // musteriEkleAdi
            // 
            this.musteriEkleAdi.Location = new System.Drawing.Point(69, 30);
            this.musteriEkleAdi.Name = "musteriEkleAdi";
            this.musteriEkleAdi.Size = new System.Drawing.Size(183, 20);
            this.musteriEkleAdi.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "Soyadı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(537, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Müşterilerin aldıkları";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tüm Müşteriler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(533, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(372, 214);
            this.dataGridView2.TabIndex = 10;
            // 
            // tumMusterilerView
            // 
            this.tumMusterilerView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tumMusterilerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tumMusterilerView.Location = new System.Drawing.Point(15, 220);
            this.tumMusterilerView.Name = "tumMusterilerView";
            this.tumMusterilerView.Size = new System.Drawing.Size(499, 214);
            this.tumMusterilerView.TabIndex = 9;
            // 
            // MusterilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Proje.Properties.Resources.hehe;
            this.ClientSize = new System.Drawing.Size(925, 463);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tumMusterilerView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MusterilerForm";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.MusterilerForm_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumMusterilerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox musteriAdiCombo;
        private System.Windows.Forms.Button musteriSil;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox msuteriEkleAdres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button musteriEkleButton;
        private System.Windows.Forms.TextBox musteriEkleTelefon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox musteriEkleSoyadi;
        private System.Windows.Forms.TextBox musteriEkleAdi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView tumMusterilerView;
    }
}