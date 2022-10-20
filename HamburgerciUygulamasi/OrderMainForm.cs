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

        private void tsmiSiparisOlustur_Click(object sender, EventArgs e)
        {
            OrderDesign siparisYonetimi = new OrderDesign();
            siparisYonetimi.MdiParent = this;
            siparisYonetimi.Show();
        }

        private void tsmiSiparisBilgileri_Click(object sender, EventArgs e)
        {

        }

        private void tsmiMenuEkle_Click(object sender, EventArgs e)
        {

        }

        private void tsmiEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
