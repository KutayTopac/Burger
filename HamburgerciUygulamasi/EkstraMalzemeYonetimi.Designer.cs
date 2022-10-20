namespace HamburgerciUygulamasi
{
    partial class EkstraMalzemeYonetimi
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
            this.btnEkstraKaydet = new System.Windows.Forms.Button();
            this.nudEkstraFiyati = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkstraKaydet
            // 
            this.btnEkstraKaydet.BackColor = System.Drawing.Color.Tan;
            this.btnEkstraKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkstraKaydet.Location = new System.Drawing.Point(130, 199);
            this.btnEkstraKaydet.Name = "btnEkstraKaydet";
            this.btnEkstraKaydet.Size = new System.Drawing.Size(136, 42);
            this.btnEkstraKaydet.TabIndex = 13;
            this.btnEkstraKaydet.Text = "KAYDET";
            this.btnEkstraKaydet.UseVisualStyleBackColor = false;
            // 
            // nudEkstraFiyati
            // 
            this.nudEkstraFiyati.Location = new System.Drawing.Point(132, 151);
            this.nudEkstraFiyati.Name = "nudEkstraFiyati";
            this.nudEkstraFiyati.Size = new System.Drawing.Size(90, 20);
            this.nudEkstraFiyati.TabIndex = 12;
            // 
            // txtEkstraAdi
            // 
            this.txtEkstraAdi.Location = new System.Drawing.Point(132, 117);
            this.txtEkstraAdi.Name = "txtEkstraAdi";
            this.txtEkstraAdi.Size = new System.Drawing.Size(159, 20);
            this.txtEkstraAdi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ekstra Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // EkstraMalzemeYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 312);
            this.Controls.Add(this.btnEkstraKaydet);
            this.Controls.Add(this.nudEkstraFiyati);
            this.Controls.Add(this.txtEkstraAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EkstraMalzemeYonetimi";
            this.Text = "EkstraMalzemeYonetimi";
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkstraKaydet;
        private System.Windows.Forms.NumericUpDown nudEkstraFiyati;
        private System.Windows.Forms.TextBox txtEkstraAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}