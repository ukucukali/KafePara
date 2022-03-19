using Newtonsoft.Json;
using ParaCafe.Data;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KafePara
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {

            VerileriOku();
            InitializeComponent();
            MasaOlustur();
        }

        private void OrnekUrunleriEkle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Ayran", BirimFiyat = 4.5m });
            db.Urunler.Add(new Urun() { UrunAd = "Cola", BirimFiyat = 5.5m });
        }

        private void MasaOlustur()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem($"Masa - {i}");
                lvi.Tag = i;
                lvi.ImageKey = db.AktifSiparisler.Any(x => x.MasaNo == i) ? "dolu" : "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            int no = (int)lvi.Tag;

            Siparis siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == no);

            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = no };
                db.AktifSiparisler.Add(siparis);
                lvi.ImageKey = "dolu";
            }

            SiparisForm sf = new SiparisForm(siparis, db);
            sf.MasaTasindi += Sf_MasaTasindi;
            sf.ShowDialog();

            if (siparis.Durum != SiparisDurum.Aktif)
                lvi.ImageKey = "bos";
        }

        private void Sf_MasaTasindi(object sender, MasaTasiEventArgs e)
        {
            foreach (ListViewItem lvi in lvwMasalar.Items)
            {
                if ((int)lvi.Tag == e.EskiMasaNo) lvi.ImageKey = "bos";
                if ((int)lvi.Tag == e.YeniMasaNo) lvi.ImageKey = "dolu";
            }
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm(db).ShowDialog();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }

        private void VerileriOku()
        {
            try
            {
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<KafeVeri>(json);

            }
            catch (Exception)
            {

                db = new KafeVeri();
                OrnekUrunleriEkle();

            }
        }
    }

}
