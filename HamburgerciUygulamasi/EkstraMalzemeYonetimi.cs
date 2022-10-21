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
    public partial class EkstraMalzemeYonetimi : Form
    {
        public EkstraMalzemeYonetimi()
        {
            InitializeComponent();
        }

        private void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            OrderDesign.ekstralar.Add(new EkstraMalzeme { EkstraAdi = txtEkstraAdi.Text, EkstraFiyati = nudEkstraFiyati.Value });
            MessageBox.Show("Ekstra malzeme eklendi");
        }
    }
}
