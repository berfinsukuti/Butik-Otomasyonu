namespace Proje
{
    partial class StokForm
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
            this.urunAraBox = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.siralamaOlcutuCombo = new System.Windows.Forms.ComboBox();
            this.urunListeleView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urunListeleView)).BeginInit();
            this.SuspendLayout();
            // 
            // urunAraBox
            // 
            this.urunAraBox.Location = new System.Drawing.Point(262, 76);
            this.urunAraBox.Name = "urunAraBox";
            this.urunAraBox.Size = new System.Drawing.Size(154, 20);
            this.urunAraBox.TabIndex = 9;
            // 
            // araButton
            // 
            this.araButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.araButton.Location = new System.Drawing.Point(422, 68);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(80, 34);
            this.araButton.TabIndex = 8;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = false;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sıralama Ölçütü";
            // 
            // siralamaOlcutuCombo
            // 
            this.siralamaOlcutuCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siralamaOlcutuCombo.FormattingEnabled = true;
            this.siralamaOlcutuCombo.Items.AddRange(new object[] {
            "Alfabetik A-Z",
            "Fiyat düşükten yükseğe",
            "Fiyat yüksekten düşüğe",
            "En az satılan",
            "En fazla satılan",
            "Miktar en çok",
            "Miktar en az"});
            this.siralamaOlcutuCombo.Location = new System.Drawing.Point(27, 76);
            this.siralamaOlcutuCombo.Name = "siralamaOlcutuCombo";
            this.siralamaOlcutuCombo.Size = new System.Drawing.Size(199, 21);
            this.siralamaOlcutuCombo.TabIndex = 6;
            this.siralamaOlcutuCombo.SelectedIndexChanged += new System.EventHandler(this.siralamaOlcutuCombo_SelectedIndexChanged);
            // 
            // urunListeleView
            // 
            this.urunListeleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunListeleView.Location = new System.Drawing.Point(27, 115);
            this.urunListeleView.Name = "urunListeleView";
            this.urunListeleView.Size = new System.Drawing.Size(475, 284);
            this.urunListeleView.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(422, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje.Properties.Resources.djkhkhf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urunAraBox);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siralamaOlcutuCombo);
            this.Controls.Add(this.urunListeleView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StokForm";
            this.Text = "Stoklar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StokForm_FormClosing);
            this.Load += new System.EventHandler(this.StokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunListeleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urunAraBox;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox siralamaOlcutuCombo;
        private System.Windows.Forms.DataGridView urunListeleView;
        private System.Windows.Forms.Button button1;
    }
}