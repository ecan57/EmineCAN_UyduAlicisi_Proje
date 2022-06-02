
namespace UyduAlicisi
{
    partial class UyduAlicisiForm
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
            this.btnKanal = new System.Windows.Forms.Button();
            this.btnRadyo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKanal
            // 
            this.btnKanal.Location = new System.Drawing.Point(34, 84);
            this.btnKanal.Name = "btnKanal";
            this.btnKanal.Size = new System.Drawing.Size(178, 100);
            this.btnKanal.TabIndex = 0;
            this.btnKanal.Text = "KANAL";
            this.btnKanal.UseVisualStyleBackColor = true;
            this.btnKanal.Click += new System.EventHandler(this.btnKanal_Click);
            // 
            // btnRadyo
            // 
            this.btnRadyo.Location = new System.Drawing.Point(34, 243);
            this.btnRadyo.Name = "btnRadyo";
            this.btnRadyo.Size = new System.Drawing.Size(178, 100);
            this.btnRadyo.TabIndex = 1;
            this.btnRadyo.Text = "RADYO";
            this.btnRadyo.UseVisualStyleBackColor = true;
            this.btnRadyo.Click += new System.EventHandler(this.btnRadyo_Click);
            // 
            // UyduAlicisiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UyduAlicisi.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRadyo);
            this.Controls.Add(this.btnKanal);
            this.Name = "UyduAlicisiForm";
            this.Text = "Uydu Alıcısı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKanal;
        private System.Windows.Forms.Button btnRadyo;
    }
}

