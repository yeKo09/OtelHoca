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
    public partial class FormFaturalandirma : Form
    {

        private List<OdaRezervasyon> odaRezervasyonlari;
        private double fiyat;

        public FormFaturalandirma()
        {
            InitializeComponent();
        }

        public FormFaturalandirma(List<OdaRezervasyon> odaRezervasyonlari) : this()
        {
            this.odaRezervasyonlari = odaRezervasyonlari;
            fiyat = 0;
        }

        private void FormFaturalandirma_Load(object sender, EventArgs e)
        {
            MusterileriYukle();
            HizmetleriYukle();
        }

        private void HizmetleriYukle()
        {
            flEkHizmetler.Controls.Add(new CheckBox() { Text = "Kola", Tag = new Hizmet() { HizmetAdi = "Kola", HizmetFiyati = 10 } });
            flEkHizmetler.Controls.Add(new CheckBox() { Text = "Çikolata", Tag = new Hizmet() { HizmetAdi = "Su", HizmetFiyati = 15 } });
            flEkHizmetler.Controls.Add(new CheckBox() { Text = "Bira", Tag = new Hizmet() { HizmetAdi = "Bira", HizmetFiyati = 30 } });
            flEkHizmetler.Controls.Add(new CheckBox() { Text = "Sarap", Tag = new Hizmet() { HizmetAdi = "Sarap", HizmetFiyati = 20 } });
            flEkHizmetler.Controls.Add(new CheckBox() { Text = "Cikolata", Tag = new Hizmet() { HizmetAdi = "Cikolata", HizmetFiyati = 30 } });
            flEkHizmetler.Controls.Add(new CheckBox() { Text = "Cips", Tag = new Hizmet() { HizmetAdi = "Cips", HizmetFiyati = 20 } }); ;
        }

        private void MusterileriYukle()
        {
            foreach (OdaRezervasyon item in this.odaRezervasyonlari)
            {
                cmbMusteri.Items.Add(item.Musteri);
            }
        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cmbMusteri.SelectedItem == null)
            {
                return;
            }

            String odaText = "";

            foreach (OdaRezervasyon item in this.odaRezervasyonlari)
            {
                if (item.Musteri.AdSoyad == cmbMusteri.SelectedItem.ToString())
                {
                    odaText = (item.Oda.Numarasi == 200) ? "Kral Dairesi Odasi - " : item.Oda.Numarasi + " numarali oda - ";
                    lblMusteriBilgileri.Text = item.Musteri.AdSoyad + " - " + odaText 
                        + item.GirisTarihi.ToShortDateString() + " girisli";
                    
                }
            }
        }

        private void dtCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            foreach (OdaRezervasyon item in this.odaRezervasyonlari)
            {
                if (item.Musteri.AdSoyad == cmbMusteri.SelectedItem.ToString())
                {
                    lblGunSayisi.Text = KalinacakGunSayisi(item.GirisTarihi, dtCikisTarihi.Value).ToString() + " gün X "
                        + item.Oda.Fiyat + " TL";
                    this.fiyat = item.Oda.Fiyat * KalinacakGunSayisi(item.GirisTarihi, dtCikisTarihi.Value);
                }
            }
            
            lblToplamFiyat.Text = this.fiyat.ToString();
        }
        public int KalinacakGunSayisi(DateTime GirisTarihi, DateTime CikisTarihi)
        {
            return (CikisTarihi - GirisTarihi).Days;

        }

        private void btnHizmetleriEkle_Click(object sender, EventArgs e)
        {
            double originalFiyat = this.fiyat;
            foreach (CheckBox item in flEkHizmetler.Controls)
            {
                if (item.Checked)
                {
                    this.fiyat += Convert.ToDouble(item.Tag.ToString());
                }
            }
            lblEkHizmetler.Text = (this.fiyat - originalFiyat).ToString() + " TL";
            lblToplamFiyat.Text = this.fiyat.ToString();
        }

        List<RezervasyonDetay> rDetay = new List<RezervasyonDetay>();
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            foreach (OdaRezervasyon item in this.odaRezervasyonlari)
            {
                if (item.Musteri.AdSoyad == cmbMusteri.SelectedItem.ToString())
                {
                    rDetay.Add(new RezervasyonDetay() 
                    {
                        ToplamFiyat = this.fiyat,
                        CikisTarihi = dtCikisTarihi.Value,
                        OdaRezervasyonu = item
                    });

                    
                }
            }
            MessageBox.Show("Ödeme Basarili");
            this.Tag = rDetay;
            flEkHizmetler.Controls.Clear();
            HizmetleriYukle();
            cmbMusteri.SelectedItem = null;
            lblEkHizmetler.Text = "0";
            lblGunSayisi.Text = "0";
            lblMusteriBilgileri.Text = "-";
            lblToplamFiyat.Text = "0";

        }

        
    }
}
