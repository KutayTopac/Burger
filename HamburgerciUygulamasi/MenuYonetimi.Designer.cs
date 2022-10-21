namespace HamburgerciUygulamasi
{
    partial class MenuYonetimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.nudMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.btnMenuKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(123, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENÜ BİLGİLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menü Adı :";
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(130, 96);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(159, 20);
            this.txtMenuAdi.TabIndex = 5;
            // 
            // nudMenuFiyati
            // 
            this.nudMenuFiyati.Location = new System.Drawing.Point(130, 130);
            this.nudMenuFiyati.Name = "nudMenuFiyati";
            this.nudMenuFiyati.Size = new System.Drawing.Size(90, 20);
            this.nudMenuFiyati.TabIndex = 6;
            // 
            // btnMenuKaydet
            // 
            this.btnMenuKaydet.BackColor = System.Drawing.Color.PeachPuff;
            this.btnMenuKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuKaydet.Location = new System.Drawing.Point(128, 178);
            this.btnMenuKaydet.Name = "btnMenuKaydet";
            this.btnMenuKaydet.Size = new System.Drawing.Size(136, 42);
            this.btnMenuKaydet.TabIndex = 7;
            this.btnMenuKaydet.Text = "KAYDET";
            this.btnMenuKaydet.UseVisualStyleBackColor = false;
            this.btnMenuKaydet.Click += new System.EventHandler(this.btnMenuKaydet_Click);
            // 
            // MenuYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 308);
            this.Controls.Add(this.btnMenuKaydet);
            this.Controls.Add(this.nudMenuFiyati);
            this.Controls.Add(this.txtMenuAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuYonetimi";
            this.Text = "MenuYonetimi";
            ((System.ComponentModel.ISupportInitialize)(this.nudMenuFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.NumericUpDown nudMenuFiyati;
        private System.Windows.Forms.Button btnMenuKaydet;
    }
}