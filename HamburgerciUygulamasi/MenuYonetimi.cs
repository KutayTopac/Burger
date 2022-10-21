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
using Menu = HamburgerciUygulamasi.Siniflar.Menu;

namespace HamburgerciUygulamasi
{
    public partial class MenuYonetimi : Form
    {
        public MenuYonetimi()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            OrderDesign.menuler.Add(new Menu {  MenuAdi = txtMenuAdi.Text, Fiyati = nudMenuFiyati.Value });
            MessageBox.Show("Yeni menu eklendi");
        }
    }
}
