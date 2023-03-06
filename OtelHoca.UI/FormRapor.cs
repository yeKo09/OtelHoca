using OtelHoca.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelHoca.UI
{
    public partial class FormRapor : Form
    {

        private List<RezervasyonDetay> rezervasyonDetaylari;
        private List<RezervasyonDetay> tarihFiltrelenmisRezervasyonDetaylari;
        private bool hemTarihHemDeIsimMi;

        public FormRapor()
        {
            InitializeComponent();
        }

        public FormRapor(List<RezervasyonDetay> rezervasyonDetaylari) : this()
        {
            this.rezervasyonDetaylari = rezervasyonDetaylari;
            this.tarihFiltrelenmisRezervasyonDetaylari = new List<RezervasyonDetay>();
            this.hemTarihHemDeIsimMi = false;
        }

        private void FormRapor_Load(object sender, EventArgs e)
        {
            DetaylariEkle();
            this.Tag = this.rezervasyonDetaylari;
        }

        private void DetaylariEkle()
        {
            foreach (RezervasyonDetay item in this.rezervasyonDetaylari)
            {
                ListeyeEkle(item);
            }
        }

        private void ListeyeEkle(RezervasyonDetay item)
        {
            ListViewItem item1 = new ListViewItem(item.OdaRezervasyonu.Musteri.AdSoyad, 0);
            item1.SubItems.Add(item.OdaRezervasyonu.GirisTarihi.Date.ToString());
            item1.SubItems.Add(item.CikisTarihi.Date.ToString());
            item1.SubItems.Add(item.OdaRezervasyonu.Oda.Numarasi.ToString());
            item1.SubItems.Add(item.ToplamFiyat.ToString());

          

            lwDetaylar.Items.Add(item1);
        }


        private bool AraBosMu()
        {
            return (string.IsNullOrEmpty(txtAra.Text));
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (AraBosMu())
            {
                MessageBox.Show("Deger girmeden arama yapamazsınız!");
                return;
            }
            

            lwDetaylar.Items.Clear();
            List<RezervasyonDetay> kullanilacakDetaylar = this.hemTarihHemDeIsimMi
                ? this.tarihFiltrelenmisRezervasyonDetaylari
                : this.rezervasyonDetaylari;

            foreach (RezervasyonDetay item in kullanilacakDetaylar)
            {
                if (item.OdaRezervasyonu.Musteri.AdSoyad.ToLower().Contains(txtAra.Text.ToLower()))
                {
                    ListeyeEkle(item);
                }
            }
            txtAra.Text = "";
            
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            lwDetaylar.Items.Clear();
            DetaylariEkle();
        }

        private void btnSadeceTarihFiltrele_Click(object sender, EventArgs e)
        {
            lwDetaylar.Items.Clear();
            foreach (RezervasyonDetay item in this.rezervasyonDetaylari)
            {
                if (DateTime.Compare(item.OdaRezervasyonu.GirisTarihi.Date, dtGirisTarihi.Value.Date) >= 0
                    && DateTime.Compare(dtCikisTarihi.Value.Date, item.CikisTarihi.Date) >= 0)
                {
                    ListeyeEkle(item);
                    this.tarihFiltrelenmisRezervasyonDetaylari.Add(item);
                }
            }
        }

        private void btnHemTarihHemIsim_Click(object sender, EventArgs e)
        {
            this.hemTarihHemDeIsimMi = true;
            btnAra_Click(new Button(), new EventArgs());
            this.hemTarihHemDeIsimMi = false;
        }
    }
}
