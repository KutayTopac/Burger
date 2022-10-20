namespace HamburgerciUygulamasi
{
    partial class OrderMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSiparisOlustur,
            this.tsmiSiparisBilgileri});
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // tsmiSiparisOlustur
            // 
            this.tsmiSiparisOlustur.Name = "tsmiSiparisOlustur";
            this.tsmiSiparisOlustur.Size = new System.Drawing.Size(180, 22);
            this.tsmiSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmiSiparisOlustur.Click += new System.EventHandler(this.tsmiSiparisOlustur_Click);
            // 
            // tsmiSiparisBilgileri
            // 
            this.tsmiSiparisBilgileri.Name = "tsmiSiparisBilgileri";
            this.tsmiSiparisBilgileri.Size = new System.Drawing.Size(180, 22);
            this.tsmiSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.tsmiSiparisBilgileri.Click += new System.EventHandler(this.tsmiSiparisBilgileri_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenuEkle,
            this.tsmiEkstraMalzemeEkle});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // tsmiMenuEkle
            // 
            this.tsmiMenuEkle.Name = "tsmiMenuEkle";
            this.tsmiMenuEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmiMenuEkle.Text = "Menü Ekle";
            this.tsmiMenuEkle.Click += new System.EventHandler(this.tsmiMenuEkle_Click);
            // 
            // tsmiEkstraMalzemeEkle
            // 
            this.tsmiEkstraMalzemeEkle.Name = "tsmiEkstraMalzemeEkle";
            this.tsmiEkstraMalzemeEkle.Size = new System.Drawing.Size(180, 22);
            this.tsmiEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmiEkstraMalzemeEkle.Click += new System.EventHandler(this.tsmiEkstraMalzemeEkle_Click);
            // 
            // OrderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 626);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderMainForm";
            this.Text = "Ana Ekran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSiparisOlustur;
        private System.Windows.Forms.ToolStripMenuItem tsmiSiparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuEkle;
        private System.Windows.Forms.ToolStripMenuItem tsmiEkstraMalzemeEkle;
    }
}

