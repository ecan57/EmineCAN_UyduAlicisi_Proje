
namespace UyduAlicisi
{
    partial class KanalForm
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
            this.btnBul = new System.Windows.Forms.Button();
            this.tbxKanalAdi = new System.Windows.Forms.TextBox();
            this.tbxKanalID = new System.Windows.Forms.TextBox();
            this.tbxYayinAdi = new System.Windows.Forms.TextBox();
            this.tbxFrekans = new System.Windows.Forms.TextBox();
            this.dgvKanal = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblHDmi = new System.Windows.Forms.Label();
            this.lblRadyoID = new System.Windows.Forms.Label();
            this.lblDil = new System.Windows.Forms.Label();
            this.lblKanalID = new System.Windows.Forms.Label();
            this.lblKanalAd = new System.Windows.Forms.Label();
            this.lblFrekans = new System.Windows.Forms.Label();
            this.lblYayinAdi = new System.Windows.Forms.Label();
            this.cmbxDil = new System.Windows.Forms.ComboBox();
            this.cbxHDmi = new System.Windows.Forms.CheckBox();
            this.cmbxRadyoID = new System.Windows.Forms.ComboBox();
            this.btnGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(283, 15);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(93, 32);
            this.btnBul.TabIndex = 19;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // tbxKanalAdi
            // 
            this.tbxKanalAdi.Location = new System.Drawing.Point(114, 53);
            this.tbxKanalAdi.Multiline = true;
            this.tbxKanalAdi.Name = "tbxKanalAdi";
            this.tbxKanalAdi.Size = new System.Drawing.Size(361, 33);
            this.tbxKanalAdi.TabIndex = 15;
            // 
            // tbxKanalID
            // 
            this.tbxKanalID.Location = new System.Drawing.Point(114, 15);
            this.tbxKanalID.Multiline = true;
            this.tbxKanalID.Name = "tbxKanalID";
            this.tbxKanalID.Size = new System.Drawing.Size(137, 32);
            this.tbxKanalID.TabIndex = 16;
            // 
            // tbxYayinAdi
            // 
            this.tbxYayinAdi.Location = new System.Drawing.Point(114, 130);
            this.tbxYayinAdi.Multiline = true;
            this.tbxYayinAdi.Name = "tbxYayinAdi";
            this.tbxYayinAdi.Size = new System.Drawing.Size(361, 31);
            this.tbxYayinAdi.TabIndex = 17;
            // 
            // tbxFrekans
            // 
            this.tbxFrekans.Location = new System.Drawing.Point(114, 92);
            this.tbxFrekans.Multiline = true;
            this.tbxFrekans.Name = "tbxFrekans";
            this.tbxFrekans.Size = new System.Drawing.Size(361, 32);
            this.tbxFrekans.TabIndex = 18;
            // 
            // dgvKanal
            // 
            this.dgvKanal.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKanal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKanal.Location = new System.Drawing.Point(27, 279);
            this.dgvKanal.Name = "dgvKanal";
            this.dgvKanal.Size = new System.Drawing.Size(761, 138);
            this.dgvKanal.TabIndex = 14;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(545, 210);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(243, 42);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(545, 162);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(243, 42);
            this.btnVazgec.TabIndex = 10;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(545, 117);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(243, 39);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(545, 68);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(243, 42);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(545, 15);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(243, 47);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblHDmi
            // 
            this.lblHDmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHDmi.Location = new System.Drawing.Point(24, 224);
            this.lblHDmi.Name = "lblHDmi";
            this.lblHDmi.Size = new System.Drawing.Size(60, 21);
            this.lblHDmi.TabIndex = 5;
            this.lblHDmi.Text = "HD";
            this.lblHDmi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRadyoID
            // 
            this.lblRadyoID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRadyoID.Location = new System.Drawing.Point(24, 195);
            this.lblRadyoID.Name = "lblRadyoID";
            this.lblRadyoID.Size = new System.Drawing.Size(60, 21);
            this.lblRadyoID.TabIndex = 6;
            this.lblRadyoID.Text = "Radyo ID";
            this.lblRadyoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDil
            // 
            this.lblDil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDil.Location = new System.Drawing.Point(24, 168);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(60, 21);
            this.lblDil.TabIndex = 7;
            this.lblDil.Text = "Dil";
            this.lblDil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKanalID
            // 
            this.lblKanalID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKanalID.Location = new System.Drawing.Point(24, 15);
            this.lblKanalID.Name = "lblKanalID";
            this.lblKanalID.Size = new System.Drawing.Size(60, 32);
            this.lblKanalID.TabIndex = 8;
            this.lblKanalID.Text = "Kanal ID";
            this.lblKanalID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKanalAd
            // 
            this.lblKanalAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKanalAd.Location = new System.Drawing.Point(24, 53);
            this.lblKanalAd.Name = "lblKanalAd";
            this.lblKanalAd.Size = new System.Drawing.Size(60, 32);
            this.lblKanalAd.TabIndex = 7;
            this.lblKanalAd.Text = "Kanal Adı";
            this.lblKanalAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrekans
            // 
            this.lblFrekans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFrekans.Location = new System.Drawing.Point(24, 92);
            this.lblFrekans.Name = "lblFrekans";
            this.lblFrekans.Size = new System.Drawing.Size(60, 32);
            this.lblFrekans.TabIndex = 6;
            this.lblFrekans.Text = "Frekans";
            this.lblFrekans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYayinAdi
            // 
            this.lblYayinAdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYayinAdi.Location = new System.Drawing.Point(24, 130);
            this.lblYayinAdi.Name = "lblYayinAdi";
            this.lblYayinAdi.Size = new System.Drawing.Size(60, 32);
            this.lblYayinAdi.TabIndex = 5;
            this.lblYayinAdi.Text = "Yayın Adı";
            this.lblYayinAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbxDil
            // 
            this.cmbxDil.FormattingEnabled = true;
            this.cmbxDil.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce"});
            this.cmbxDil.Location = new System.Drawing.Point(114, 168);
            this.cmbxDil.Name = "cmbxDil";
            this.cmbxDil.Size = new System.Drawing.Size(361, 21);
            this.cmbxDil.TabIndex = 20;
            // 
            // cbxHDmi
            // 
            this.cbxHDmi.AutoSize = true;
            this.cbxHDmi.Location = new System.Drawing.Point(114, 228);
            this.cbxHDmi.Name = "cbxHDmi";
            this.cbxHDmi.Size = new System.Drawing.Size(15, 14);
            this.cbxHDmi.TabIndex = 21;
            this.cbxHDmi.UseVisualStyleBackColor = true;
            // 
            // cmbxRadyoID
            // 
            this.cmbxRadyoID.FormattingEnabled = true;
            this.cmbxRadyoID.Location = new System.Drawing.Point(114, 195);
            this.cmbxRadyoID.Name = "cmbxRadyoID";
            this.cmbxRadyoID.Size = new System.Drawing.Size(361, 21);
            this.cmbxRadyoID.TabIndex = 20;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(382, 15);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(93, 32);
            this.btnGetir.TabIndex = 22;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // KanalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UyduAlicisi.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.cbxHDmi);
            this.Controls.Add(this.cmbxRadyoID);
            this.Controls.Add(this.cmbxDil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.tbxKanalAdi);
            this.Controls.Add(this.tbxKanalID);
            this.Controls.Add(this.tbxYayinAdi);
            this.Controls.Add(this.tbxFrekans);
            this.Controls.Add(this.dgvKanal);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblYayinAdi);
            this.Controls.Add(this.lblFrekans);
            this.Controls.Add(this.lblHDmi);
            this.Controls.Add(this.lblKanalAd);
            this.Controls.Add(this.lblRadyoID);
            this.Controls.Add(this.lblDil);
            this.Controls.Add(this.lblKanalID);
            this.Name = "KanalForm";
            this.Text = "Kanal";
            this.Load += new System.EventHandler(this.KanalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKanal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox tbxKanalAdi;
        private System.Windows.Forms.TextBox tbxKanalID;
        private System.Windows.Forms.TextBox tbxYayinAdi;
        private System.Windows.Forms.TextBox tbxFrekans;
        private System.Windows.Forms.DataGridView dgvKanal;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblHDmi;
        private System.Windows.Forms.Label lblRadyoID;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.Label lblKanalID;
        private System.Windows.Forms.Label lblKanalAd;
        private System.Windows.Forms.Label lblFrekans;
        private System.Windows.Forms.Label lblYayinAdi;
        private System.Windows.Forms.ComboBox cmbxDil;
        private System.Windows.Forms.CheckBox cbxHDmi;
        private System.Windows.Forms.ComboBox cmbxRadyoID;
        private System.Windows.Forms.Button btnGetir;
    }
}