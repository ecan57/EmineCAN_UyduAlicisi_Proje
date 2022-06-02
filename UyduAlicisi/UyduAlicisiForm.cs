using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UyduAlicisi
{
    public partial class UyduAlicisiForm : Form
    {
        public UyduAlicisiForm()
        {
            InitializeComponent();
        }

        private void btnKanal_Click(object sender, EventArgs e)
        {
            KanalForm kanalForm = new KanalForm();
            kanalForm.Show();
        }

        private void btnRadyo_Click(object sender, EventArgs e)
        {
            RadyoForm radyoForm = new RadyoForm();
            radyoForm.Show();
        }
    }
}
