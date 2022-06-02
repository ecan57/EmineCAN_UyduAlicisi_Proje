
namespace UyduAlicisi
{
    partial class RadyoForm
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
            this.lblRadyoID = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblRadyoAdi = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblFrekans = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblDil = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.dgvRadyo = new System.Windows.Forms.DataGridView();
            this.tbxFrekans = new System.Windows.Forms.TextBox();
            this.tbxRadyoID = new System.Windows.Forms.TextBox();
            this.tbxRadyoAdi = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.cmbxDil = new System.Windows.Forms.ComboBox();
            this.btnGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadyo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRadyoID
            // 
            this.lblRadyoID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRadyoID.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblRadyoID.Location = new System.Drawing.Point(15, 14);
            this.lblRadyoID.Name = "lblRadyoID";
            this.lblRadyoID.Size = new System.Drawing.Size(60, 32);
            this.lblRadyoID.TabIndex = 0;
            this.lblRadyoID.Text = "Radyo ID";
            this.lblRadyoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(415, 10);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(162, 33);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblRadyoAdi
            // 
            this.lblRadyoAdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRadyoAdi.Location = new System.Drawing.Point(15, 59);
            this.lblRadyoAdi.Name = "lblRadyoAdi";
            this.lblRadyoAdi.Size = new System.Drawing.Size(60, 33);
            this.lblRadyoAdi.TabIndex = 0;
            this.lblRadyoAdi.Text = "Radyo Adı";
            this.lblRadyoAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(415, 49);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(162, 33);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblFrekans
            // 
            this.lblFrekans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFrekans.Location = new System.Drawing.Point(15, 110);
            this.lblFrekans.Name = "lblFrekans";
            this.lblFrekans.Size = new System.Drawing.Size(60, 32);
            this.lblFrekans.TabIndex = 0;
            this.lblFrekans.Text = "Frekans";
            this.lblFrekans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(415, 88);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(162, 32);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblDil
            // 
            this.lblDil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDil.Location = new System.Drawing.Point(15, 162);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(60, 21);
            this.lblDil.TabIndex = 0;
            this.lblDil.Text = "Dil";
            this.lblDil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(415, 126);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(162, 31);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // dgvRadyo
            // 
            this.dgvRadyo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRadyo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadyo.Location = new System.Drawing.Point(15, 206);
            this.dgvRadyo.Name = "dgvRadyo";
            this.dgvRadyo.Size = new System.Drawing.Size(562, 232);
            this.dgvRadyo.TabIndex = 2;
            // 
            // tbxFrekans
            // 
            this.tbxFrekans.Location = new System.Drawing.Point(102, 110);
            this.tbxFrekans.Multiline = true;
            this.tbxFrekans.Name = "tbxFrekans";
            this.tbxFrekans.Size = new System.Drawing.Size(250, 32);
            this.tbxFrekans.TabIndex = 3;
            // 
            // tbxRadyoID
            // 
            this.tbxRadyoID.Location = new System.Drawing.Point(102, 14);
            this.tbxRadyoID.Multiline = true;
            this.tbxRadyoID.Name = "tbxRadyoID";
            this.tbxRadyoID.Size = new System.Drawing.Size(103, 32);
            this.tbxRadyoID.TabIndex = 3;
            // 
            // tbxRadyoAdi
            // 
            this.tbxRadyoAdi.Location = new System.Drawing.Point(102, 59);
            this.tbxRadyoAdi.Multiline = true;
            this.tbxRadyoAdi.Name = "tbxRadyoAdi";
            this.tbxRadyoAdi.Size = new System.Drawing.Size(250, 33);
            this.tbxRadyoAdi.TabIndex = 3;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(226, 14);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(60, 32);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(415, 162);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(162, 35);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // cmbxDil
            // 
            this.cmbxDil.FormattingEnabled = true;
            this.cmbxDil.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce"});
            this.cmbxDil.Location = new System.Drawing.Point(102, 162);
            this.cmbxDil.Name = "cmbxDil";
            this.cmbxDil.Size = new System.Drawing.Size(250, 21);
            this.cmbxDil.TabIndex = 5;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(292, 14);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(60, 32);
            this.btnGetir.TabIndex = 6;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // RadyoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UyduAlicisi.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.cmbxDil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.tbxRadyoAdi);
            this.Controls.Add(this.tbxRadyoID);
            this.Controls.Add(this.tbxFrekans);
            this.Controls.Add(this.dgvRadyo);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblDil);
            this.Controls.Add(this.lblFrekans);
            this.Controls.Add(this.lblRadyoAdi);
            this.Controls.Add(this.lblRadyoID);
            this.Name = "RadyoForm";
            this.Text = "Radyo";
            this.Load += new System.EventHandler(this.RadyoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadyo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadyoID;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblRadyoAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblFrekans;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.DataGridView dgvRadyo;
        private System.Windows.Forms.TextBox tbxFrekans;
        private System.Windows.Forms.TextBox tbxRadyoID;
        private System.Windows.Forms.TextBox tbxRadyoAdi;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ComboBox cmbxDil;
        private System.Windows.Forms.Button btnGetir;
    }
}