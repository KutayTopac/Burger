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
    public partial class OrderDesign : Form
    {
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi="Big King", Fiyati=78.25M},
            new Menu{MenuAdi="Double King Chicken", Fiyati=69.75M},
            new Menu{MenuAdi="Steakhouse", Fiyati=72.50M},
            new Menu{MenuAdi="Whooper", Fiyati=70.00M},
            new Menu{MenuAdi="Whooper Jr.", Fiyati=67.75M},
            new Menu{MenuAdi="Chicken Royal", Fiyati=71.25M}
        };

        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraAdi="Ketçap", EkstraFiyati=2.50M},
            new EkstraMalzeme{EkstraAdi="Mayonez", EkstraFiyati=2.50M},
            new EkstraMalzeme{EkstraAdi="Hardal", EkstraFiyati=2.75M},
            new EkstraMalzeme{EkstraAdi="BBQ", EkstraFiyati=3.00M},
            new EkstraMalzeme{EkstraAdi="Ranch", EkstraFiyati=2.00M},
            new EkstraMalzeme{EkstraAdi="Buffalo", EkstraFiyati=2.25M}
        };

        public OrderDesign()
        {
            InitializeComponent();
            int x = 20;
            int y = 16;
            foreach (var item in menuler)
            {
                cboMenu.Items.Add(item);
            }
            cboMenu.SelectedIndex = 0;
            foreach (var item in ekstralar)
            {
                CheckBox a = new CheckBox();
                a.Text = item.EkstraAdi;
                a.Tag = item;
                a.Location = new Point(x, y);
                pnlMalzeme.Controls.Add(a);                
                y += 22;
            }

        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            List<EkstraMalzeme> secilenEkstraMalzemeler = new List<EkstraMalzeme>();
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.Menu = (Menu)cboMenu.SelectedItem;

            if (rbKucuk.Checked)
                yeniSiparis.Boyut = Enums.Boyut.Kucuk;
            else if (rbOrta.Checked)
                yeniSiparis.Boyut = Enums.Boyut.Orta;
            else
                yeniSiparis.Boyut = Enums.Boyut.Buyuk;
            foreach (CheckBox item in pnlMalzeme.Controls)
            {
                if (item.Checked)
                    secilenEkstraMalzemeler.Add((EkstraMalzeme)item.Tag);
            }
            yeniSiparis.EkstraMalzemeler = secilenEkstraMalzemeler;
            yeniSiparis.Adet = (int)nudAdet.Value;
            yeniSiparis.Hesapla();
            
            tumSiparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);
            lstMenu.Items.Add(yeniSiparis);
            TutarHesapla();
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lstMenu.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lstMenu.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("c2");
            return toplamTutar;
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Toplam Sipariş Tutarı :" + TutarHesapla() + "\nSatın almayı tamamlamak istiyor musunuz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dialogResult == DialogResult.Yes)
            {
                lstMenu.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlanmıştır");
            }
            else
                MessageBox.Show("İptal edildi");
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
