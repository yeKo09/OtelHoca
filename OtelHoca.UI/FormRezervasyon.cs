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
    public partial class FormRezervasyon : Form
    {

        private int sayac;
        private List<OdaRezervasyon> odaRezervasyonlari;

        public FormRezervasyon()
        {
            InitializeComponent();
            sayac = 99;
            odaRezervasyonlari = new List<OdaRezervasyon>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            List<Button> ilkKat = OdalariEkle(1);
            ftKat1.Controls.AddRange(ilkKat.ToArray());

            List<Button> ikinciKat = OdalariEkle(2);
            ftKat2.Controls.AddRange(ikinciKat.ToArray());

            List<Button> ucuncuKat = OdalariEkle(3);
            ftKat3.Controls.AddRange(ucuncuKat.ToArray());

            KralDairesiEkle();

            
            gbMusteriBilgileri.Enabled = false;

        }

        private void KralDairesiEkle()
        {
            Button btn1 = new Button();
            btn1.Text = "Kral Dairesi";
            btn1.BackColor = Color.Green;
            btn1.ForeColor = Color.White;
            btn1.Tag = new OdaRezervasyon()
            { 
                Oda = new Oda() 
                {
                    Kapasite = 5,
                    Numarasi = 200,
                    OdaDurumu = OdaDurumu.Bos
                },
                
            };
            btn1.Width = 300;
            btn1.Height = 50;
            btn1.Click += Btn_Click;

            ftKat4.Controls.Add(btn1); 
        }

        private List<Button> OdalariEkle(byte kapasite)
        {
            List<Button> odaButonlari = new List<Button>();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = (++this.sayac).ToString();
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.White;
                btn.Tag = new OdaRezervasyon()
                {
                    Oda = new Oda()
                    {
                        Kapasite = kapasite,
                        Numarasi = int.Parse(btn.Text),
                        OdaDurumu = OdaDurumu.Bos
                    },
                    
                };

                btn.Click += Btn_Click;

                odaButonlari.Add(btn);
            }

            return odaButonlari;
        }

        Button tiklanilanButton = null;
        private void Btn_Click(object sender, EventArgs e)
        {
            tiklanilanButton = sender as Button;
            gbMusteriBilgileri.Enabled = true;
 
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidationControl())
            {
                return;
            }
            
            OdaRezervasyon odaRezervasyonlari = tiklanilanButton.Tag as OdaRezervasyon;
            if (odaRezervasyonlari.Oda.OdaDurumu == OdaDurumu.Bos && numKisiSayisi.Value <= odaRezervasyonlari.Oda.Kapasite)
            {
                //rez al
                odaRezervasyonlari.Musteri = new Musteri()
                {
                    AdSoyad = txtAdSoyad.Text,
                    TCNo = mtxtTcNo.Text,
                    TelNo = mTxtTelNo.Text,
                    Yas = numYas.Text
                };

                odaRezervasyonlari.GirisTarihi = dtGirisTarihi.Value;

                odaRezervasyonlari.Oda.OdaDurumu = OdaDurumu.Dolu;
                tiklanilanButton.BackColor = Color.Red;
               
                MessageBox.Show("Rezervasyon eklendi!");
                this.odaRezervasyonlari.Add(odaRezervasyonlari);
                this.Tag = this.odaRezervasyonlari;
            }
            else if(odaRezervasyonlari.Oda.OdaDurumu == OdaDurumu.Dolu)
            {
                //oda dolu
                MessageBox.Show("Oda dolu!!");
            }else if(numKisiSayisi.Value > odaRezervasyonlari.Oda.Kapasite) 
            {
                MessageBox.Show("Oda Kapasitesi Yeterli Değil.");
            }
        }

        private bool ValidationControl()
        {
            if (txtAdSoyad.Text.isEmpty() || mtxtTcNo.Text.isEmpty() || mTxtTelNo.Text.isEmpty())
            {
                MessageBox.Show("Bos deger girilemez!");
                return false;
            };
            if (txtAdSoyad.Text.isNumber())
            {
                MessageBox.Show("Ad Soyad kisminda numara olamaz!");
                return false;
            }
            if (mtxtTcNo.Text.isTcIncorrect())
            {
                MessageBox.Show("TC Kimlik numarasi 11 haneli olmak zorundadir.");
                return false;
            }
            if (mTxtTelNo.Text.isTelNoIncorrect())
            {
                MessageBox.Show("Telefon numaranizi eksik girdiniz.");
                return false;
            }

            return true;
        }
    }
}
