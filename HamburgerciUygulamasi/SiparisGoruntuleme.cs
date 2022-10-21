using HamburgerciUygulamasi.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciUygulamasi
{
    public partial class SiparisGoruntuleme : Form
    {
        public SiparisGoruntuleme()
        {
            InitializeComponent();
           
        }

        private void SiparisGoruntuleme_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdet = 0;

            foreach (Siparis siparis in OrderDesign.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (EkstraMalzeme ekstraMalzeme in siparis.EkstraMalzemeler)
                {
                    ekstraMalzemeGeliri += ekstraMalzeme.EkstraFiyati;
                }
                satisAdet += siparis.Adet;
                lstSiparisGoruntule.Items.Add(siparis);
            }
            lblCiro.Text = ciro.ToString("c2");
            lblEkstraMalzemeFiyati.Text = ekstraMalzemeGeliri.ToString("c2");
            lblSatilanUrunAdedi.Text =lstSiparisGoruntule.Items.Count.ToString();
            lblSiparisAdet.Text = satisAdet.ToString();
        }
    }
}
