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
    public partial class SiparisForm : Form
    {
        public event EventHandler<MasaTasiEventArgs> MasaTasindi;

        private readonly Siparis siparis;
        private readonly KafeVeri db;
        private readonly BindingList<SiparisDetay> blDetay;

        public SiparisForm(Siparis siparis, KafeVeri db)
        {
            this.siparis = siparis;
            this.db = db;
            blDetay = new BindingList<SiparisDetay>(siparis.SiparisDetaylar);
            blDetay.ListChanged += BlDetay_ListChanged;
            InitializeComponent();
            dgvSiparisDetaylar.AutoGenerateColumns = false;
            dgvSiparisDetaylar.DataSource = blDetay;
            UrunleriListele();
            MasaNoGuncelle();
            OdemeTutariGuncelle();
        }

        private void BlDetay_ListChanged(object sender, ListChangedEventArgs e)
        {
            OdemeTutariGuncelle();
        }

        private void OdemeTutariGuncelle()
        {
            lblOdemeTutari.Text = siparis.ToplamTutarTL;
        }

        private void MasaNoGuncelle()
        {
            Text = $"Masa {siparis.MasaNo} (Acilis: {siparis.AcilisZamani}";
            lblMasaNo.Text = siparis.MasaNo.ToString("00");
            int[] dolumasalar = db.AktifSiparisler.Select(x => x.MasaNo).ToArray();
            cboMasaNo.DataSource = Enumerable.Range(1, db.MasaAdet).Where(x=>!dolumasalar.Contains(x)).ToList();
        }
        private void UrunleriListele()
        {
            cboUrun.DataSource = db.Urunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SiparisDetay sd = new SiparisDetay();
            Urun urun= (Urun)cboUrun.SelectedItem;
            sd.UrunAd = urun.UrunAd;
            sd.BirimFiyat = urun.BirimFiyat;
            sd.Adet = (int)nudAdet.Value;
            blDetay.Add(sd);

        }

        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.Iptal, 0);
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.Odendi, siparis.ToplamTutar());
          }

        private void SiparisiKapat(SiparisDurum durum, decimal odenenTutar)
        {
            siparis.KapanisZamani = DateTime.Now;
            siparis.Durum = durum;
            siparis.OdenenTutar = odenenTutar;
            db.AktifSiparisler.Remove(siparis);
            db.GecmisSiparisler.Add(siparis);
            Close();
            string str;
        }

        private void btnMasaTasi_Click(object sender, EventArgs e)
        {
            if (cboMasaNo.SelectedIndex == -1) return;
            int eskiMasaNo = siparis.MasaNo;
            int hedefMasaNo = (int)cboMasaNo.SelectedItem;
            siparis.MasaNo = hedefMasaNo;
            MasaNoGuncelle();
            if (MasaTasindi != null)
                MasaTasindi(this, new MasaTasiEventArgs(eskiMasaNo, hedefMasaNo));

            
        }
    }
}
