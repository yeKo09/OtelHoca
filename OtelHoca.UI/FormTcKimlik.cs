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
    public partial class FormTcKimlik : Form
    {

        private List<RezervasyonDetay> rezervasyonDetaylari;

        public FormTcKimlik()
        {
            InitializeComponent();
        }

        public FormTcKimlik(List<RezervasyonDetay> rezervasyonDetaylari) : this()
        {
            this.rezervasyonDetaylari = rezervasyonDetaylari;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (RezervasyonDetay item in this.rezervasyonDetaylari)
            {
                if(DateTime.Compare(dtGun.Value.Date, item.OdaRezervasyonu.GirisTarihi.Date) >= 0
                    && DateTime.Compare(dtGun.Value.Date, item.CikisTarihi.Date) <= 0)
                {
                    ListViewItem item1 = new ListViewItem(item.OdaRezervasyonu.Musteri.TCNo);
                    listView1.Items.Add(item1);
                }
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count == 0)
            {
                MessageBox.Show("Gonderecek Data bulunmamaktadir.");
                return;
            }
            else
            {
                MessageBox.Show("Datalar gönderildi.");
            }
        }
    }
}
