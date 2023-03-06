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
    public partial class FormMain : Form
    {
        private List<OdaRezervasyon> musteriler;
        private List<RezervasyonDetay> rDetay;
        private FormRezervasyon fm;
        private FormFaturalandirma ffat;
        private FormRapor fr;
        private FormTcKimlik ftc;
        public FormMain()
        {
            InitializeComponent();
            this.musteriler = new List<OdaRezervasyon>();
            this.rDetay = new List<RezervasyonDetay>();
            fm = null;
            ffat = null;
            fr = null;
            ftc = null;
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fm = new FormRezervasyon();
            fm.MdiParent = this;
            fm.Show();
        }


        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriler = fm.Tag as List<OdaRezervasyon>;
            ffat = new FormFaturalandirma(musteriler);
            ffat.MdiParent = this;
            ffat.Show();
        }

        private void raporuGor_Click(object sender, EventArgs e)
        {
            rDetay = ffat.Tag as List<RezervasyonDetay>;
            fr = new FormRapor(rDetay);
            fr.MdiParent = this;
            fr.Show();
        }

        private void tcKimlikGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rDetay = ffat.Tag as List<RezervasyonDetay>;
            ftc = new FormTcKimlik(rDetay);
            ftc.MdiParent = this;
            ftc.Show();
        }

    }    
}
