using HamburgerciUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciUygulamasi.Siniflar
{
    public class Siparis
    {
        public Boyut Boyut { get; set; }

        public int Adet { get; set; }

        public decimal ToplamTutar { get; set; }

        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }

        public Menu Menu { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += Menu.Fiyati;
            if (Boyut == Boyut.Orta)
                ToplamTutar += ToplamTutar * 0.10m;
            else if (Boyut == Boyut.Buyuk)
                ToplamTutar += ToplamTutar * 0.25m;

            foreach (var malzeme in EkstraMalzemeler)
            {
                ToplamTutar += malzeme.EkstraFiyati;
            }
            ToplamTutar *= Adet;
        }

        public override string ToString()
        {
            string ekstralar = "";
            if (EkstraMalzemeler.Count == 0)
                return "Menu adi :" + Menu.MenuAdi + Environment.NewLine + "Menu adedi :" + Adet + Environment.NewLine + "Menu boyutu :" + Boyut + Environment.NewLine + "Toplam tutar :" + ToplamTutar;
            foreach (var item in EkstraMalzemeler)
            {
                ekstralar += item.EkstraAdi + Environment.NewLine;
            }
            return "Menu adi :" + Menu.MenuAdi + Environment.NewLine + "Menu adedi :" + Adet + Environment.NewLine + "Menu boyutu :" +Boyut + Environment.NewLine + ekstralar + Environment.NewLine + "Toplam tutar :" + ToplamTutar;
        }
    }
}
