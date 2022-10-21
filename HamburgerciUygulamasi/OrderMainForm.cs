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
    public partial class OrderMainForm : Form
    {
        public OrderMainForm()
        {
            InitializeComponent();
            IsMdiContainer = true; // bu form açılan formları içersinde barındırır.
           
        }

        public void PencereyiGoster(Form acilacakForm)
        {
            bool durum = false;
            foreach (Form form in MdiChildren)
            {
                if (form.Text == acilacakForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                    form.Close();
            }
            if(durum == false)
            {
                acilacakForm.MdiParent = this;
                acilacakForm.Show();
            }
        }

        private void tsmiSiparisOlustur_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new OrderDesign());
        }

        private void tsmiSiparisBilgileri_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new SiparisGoruntuleme());
        }

        private void tsmiMenuEkle_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new MenuYonetimi());
        }

        private void tsmiEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            PencereyiGoster(new EkstraMalzemeYonetimi());
        }
    }
}
