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
    public partial class RadyoForm : Form
    {
        public RadyoForm()
        {
            InitializeComponent();
        }
        UyduAlicisiDB db;
        private void RadyoForm_Load(object sender, EventArgs e)
        {
            db = new UyduAlicisiDB();
            this.Text = db.Radyolar.ToplamRadyoSayisi().ToString();
        }
        private void GridDoldur()
        {
            dgvRadyo.DataSource = db.Radyolar.Liste();
        }
        private Radyo RadyoDoldur()
        {
            Radyo radyo = new Radyo();

            radyo.RadyoAdi = tbxRadyoAdi.Text;
            radyo.Frekans = decimal.Parse(tbxFrekans.Text);
            radyo.Dil = cmbxDil.Text;

            return radyo;
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
            Radyo radyo = RadyoDoldur();
            db.Radyolar.Ekle(radyo);
            GridDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silinsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                db.Radyolar.Sil(int.Parse(tbxRadyoID.Text));
                GridDoldur();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Radyo radyo = RadyoDoldur();
            radyo.RadyoID = int.Parse(tbxRadyoID.Text);
            db.Radyolar.Guncelle(radyo);
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
            Radyo radyo = db.Radyolar.Bul(int.Parse(tbxRadyoID.Text));
            if (radyo.RadyoID > 0)
            {
                tbxRadyoAdi.Text = radyo.RadyoAdi;
                tbxFrekans.Text = radyo.Frekans.ToString();
                cmbxDil.SelectedItem = radyo.Dil;
            }
            else
            {
                MessageBox.Show("Aradığınız radyo kanalı bulunamadı.");
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Radyolar", @"Data source=.; initial catalog=UyduAlicisi; integrated security=true");
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvRadyo.DataSource = dataTable;
        }
    }
}
