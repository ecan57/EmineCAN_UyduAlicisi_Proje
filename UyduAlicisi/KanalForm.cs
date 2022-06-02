using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UyduAlicisi.Data;
using UyduAlicisi.Model;

namespace UyduAlicisi
{
    public partial class KanalForm : Form
    {
        public KanalForm()
        {
            InitializeComponent();
        }
        UyduAlicisiDB db;
        private void KanalForm_Load(object sender, EventArgs e)
        {
            db = new UyduAlicisiDB();
            RadyolariDoldur();
            this.Text = db.Kanallar.ToplamKanalSayisi().ToString();
        }
        private void GridDoldur()
        {
            dgvKanal.DataSource = db.Kanallar.Liste();
        }
        private Kanal KanalDoldur()
        {
            Kanal kanal = new Kanal();

            kanal.KanalAdi = tbxKanalAdi.Text;
            kanal.Frekans = int.Parse(tbxFrekans.Text);
            kanal.YayinAdi = tbxYayinAdi.Text;
            kanal.Dil = cmbxDil.Text;
            kanal.RadyoID = (int)cmbxRadyoID.SelectedValue;
            kanal.HDmi = cbxHDmi.Checked;

            return kanal;
        }
        private void RadyolariDoldur()
        {
            cmbxRadyoID.DataSource = db.Radyolar.Liste();
            cmbxRadyoID.DisplayMember = "RadyoAdi";
            cmbxRadyoID.ValueMember = "RadyoID";
        }
        private void EnableDisable(bool kontrol)
        {
            btnEkle.Enabled = !kontrol;
            btnTemizle.Enabled = !kontrol;
            btnVazgec.Visible = kontrol;
            btnSil.Enabled = kontrol;
            btnGuncelle.Enabled = kontrol;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kanal kanal = KanalDoldur();
            db.Kanallar.Ekle(kanal);
            GridDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silinsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                db.Kanallar.Sil(int.Parse(tbxKanalID.Text));
                GridDoldur();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kanal kanal = KanalDoldur();
            kanal.KanalID = int.Parse(tbxKanalID.Text);
            db.Kanallar.Guncelle(kanal);
            GridDoldur();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {

            EnableDisable(false);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Kanal kanal = db.Kanallar.Bul(int.Parse(tbxKanalID.Text));
            if (kanal.KanalID > 0)
            {
                tbxKanalAdi.Text = kanal.KanalAdi;
                tbxFrekans.Text = kanal.Frekans.ToString();
                tbxYayinAdi.Text = kanal.YayinAdi;
                cmbxDil.Text = kanal.Dil;

                int indis = 0;
                for (int i = 0; i < cmbxRadyoID.Items.Count; i++)
                {
                    if (((Radyo)cmbxRadyoID.Items[i]).RadyoID == kanal.RadyoID)
                        indis = i;
                    break;
                }
                cmbxRadyoID.SelectedIndex = indis;
                EnableDisable(true);

                cbxHDmi.Checked = kanal.HDmi;
            }
            else
            {
                MessageBox.Show("Aradığınız radyo kanalı bulunamadı.");
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Kanallar", @"Data source=.; initial catalog=UyduAlicisi; integrated security=true");
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvKanal.DataSource = dataTable;
        }

    }
}
