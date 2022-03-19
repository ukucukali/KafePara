using ParaCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafePara
{
    public partial class GecmisSiparislerForm : Form
    {
        private readonly KafeVeri db;

        public GecmisSiparislerForm(KafeVeri db)
        {
            this.db = db;
            InitializeComponent();
            dgvSiparisDetaylar.DataSource = db.GecmisSiparisler;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count==0)
            {
                dgvSiparisDetaylar.DataSource = null;
                return;
            }

            Siparis siparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;
            dgvSiparisDetaylar.DataSource = siparis.SiparisDetaylar;
        }
    }
}
