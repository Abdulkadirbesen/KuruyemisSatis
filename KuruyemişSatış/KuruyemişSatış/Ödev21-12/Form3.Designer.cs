namespace Ödev21_12
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label = new System.Windows.Forms.Label();
            this.lblIndirimliTutar = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.labelOdeme = new System.Windows.Forms.Label();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.btnSiparişOnay = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnToplamTutarHesapla = new System.Windows.Forms.Button();
            this.labelToplamTutar = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.labelSepet = new System.Windows.Forms.Label();
            this.lbSepet = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.labelTutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.labelAdet = new System.Windows.Forms.Label();
            this.lbUrunler = new System.Windows.Forms.ListBox();
            this.labelUrunler = new System.Windows.Forms.Label();
            this.btnDukkanIslemleri = new System.Windows.Forms.Button();
            this.btnYeniSatisIslemi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(397, 410);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(110, 19);
            this.label.TabIndex = 73;
            this.label.Text = "İndirimli Tutar:";
            // 
            // lblIndirimliTutar
            // 
            this.lblIndirimliTutar.AutoSize = true;
            this.lblIndirimliTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIndirimliTutar.Location = new System.Drawing.Point(528, 410);
            this.lblIndirimliTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndirimliTutar.Name = "lblIndirimliTutar";
            this.lblIndirimliTutar.Size = new System.Drawing.Size(64, 17);
            this.lblIndirimliTutar.TabIndex = 72;
            this.lblIndirimliTutar.Text = "              ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(100, 446);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(72, 17);
            this.lblTutar.TabIndex = 71;
            this.lblTutar.Text = "                ";
            // 
            // labelOdeme
            // 
            this.labelOdeme.AutoSize = true;
            this.labelOdeme.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdeme.Location = new System.Drawing.Point(397, 358);
            this.labelOdeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOdeme.Name = "labelOdeme";
            this.labelOdeme.Size = new System.Drawing.Size(70, 21);
            this.labelOdeme.TabIndex = 70;
            this.labelOdeme.Text = "Ödeme:";
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKrediKarti.Location = new System.Drawing.Point(591, 356);
            this.rbKrediKarti.Margin = new System.Windows.Forms.Padding(4);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(115, 25);
            this.rbKrediKarti.TabIndex = 69;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            this.rbKrediKarti.CheckedChanged += new System.EventHandler(this.rbKrediKarti_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(493, 356);
            this.rbNakit.Margin = new System.Windows.Forms.Padding(4);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(73, 25);
            this.rbNakit.TabIndex = 68;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // btnSiparişOnay
            // 
            this.btnSiparişOnay.Location = new System.Drawing.Point(655, 393);
            this.btnSiparişOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparişOnay.Name = "btnSiparişOnay";
            this.btnSiparişOnay.Size = new System.Drawing.Size(139, 43);
            this.btnSiparişOnay.TabIndex = 67;
            this.btnSiparişOnay.Text = "Siparişi Onayla";
            this.btnSiparişOnay.UseVisualStyleBackColor = true;
            this.btnSiparişOnay.Visible = false;
            this.btnSiparişOnay.Click += new System.EventHandler(this.btnSiparişOnay_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(92, 399);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(4);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(72, 22);
            this.nudAdet.TabIndex = 66;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnToplamTutarHesapla
            // 
            this.btnToplamTutarHesapla.Location = new System.Drawing.Point(655, 287);
            this.btnToplamTutarHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnToplamTutarHesapla.Name = "btnToplamTutarHesapla";
            this.btnToplamTutarHesapla.Size = new System.Drawing.Size(139, 43);
            this.btnToplamTutarHesapla.TabIndex = 65;
            this.btnToplamTutarHesapla.Text = "Toplam Tutar Hesapla";
            this.btnToplamTutarHesapla.UseVisualStyleBackColor = true;
            this.btnToplamTutarHesapla.Click += new System.EventHandler(this.btnToplamTutarHesapla_Click);
            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelToplamTutar.Location = new System.Drawing.Point(397, 300);
            this.labelToplamTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(105, 19);
            this.labelToplamTutar.TabIndex = 64;
            this.labelToplamTutar.Text = "Toplam Tutar:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(528, 300);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(64, 17);
            this.lblToplam.TabIndex = 63;
            this.lblToplam.Text = "              ";
            // 
            // labelSepet
            // 
            this.labelSepet.AutoSize = true;
            this.labelSepet.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSepet.Location = new System.Drawing.Point(397, 22);
            this.labelSepet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSepet.Name = "labelSepet";
            this.labelSepet.Size = new System.Drawing.Size(69, 22);
            this.labelSepet.TabIndex = 62;
            this.labelSepet.Text = "SEPET\r\n";
            // 
            // lbSepet
            // 
            this.lbSepet.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSepet.FormattingEnabled = true;
            this.lbSepet.ItemHeight = 18;
            this.lbSepet.Location = new System.Drawing.Point(393, 49);
            this.lbSepet.Margin = new System.Windows.Forms.Padding(4);
            this.lbSepet.Name = "lbSepet";
            this.lbSepet.Size = new System.Drawing.Size(399, 220);
            this.lbSepet.TabIndex = 61;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Enabled = false;
            this.btnSepeteEkle.Location = new System.Drawing.Point(199, 437);
            this.btnSepeteEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(135, 32);
            this.btnSepeteEkle.TabIndex = 60;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // labelTutar
            // 
            this.labelTutar.AutoSize = true;
            this.labelTutar.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTutar.Location = new System.Drawing.Point(24, 444);
            this.labelTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(49, 19);
            this.labelTutar.TabIndex = 59;
            this.labelTutar.Text = "Tutar:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(199, 393);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(135, 36);
            this.btnHesapla.TabIndex = 58;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // labelAdet
            // 
            this.labelAdet.AutoSize = true;
            this.labelAdet.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdet.Location = new System.Drawing.Point(24, 404);
            this.labelAdet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdet.Name = "labelAdet";
            this.labelAdet.Size = new System.Drawing.Size(46, 19);
            this.labelAdet.TabIndex = 57;
            this.labelAdet.Text = "Adet:";
            // 
            // lbUrunler
            // 
            this.lbUrunler.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunler.FormattingEnabled = true;
            this.lbUrunler.ItemHeight = 18;
            this.lbUrunler.Location = new System.Drawing.Point(20, 49);
            this.lbUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.lbUrunler.Name = "lbUrunler";
            this.lbUrunler.Size = new System.Drawing.Size(312, 310);
            this.lbUrunler.TabIndex = 56;
            this.lbUrunler.SelectedIndexChanged += new System.EventHandler(this.lbUrunler_SelectedIndexChanged);
            // 
            // labelUrunler
            // 
            this.labelUrunler.AutoSize = true;
            this.labelUrunler.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUrunler.Location = new System.Drawing.Point(21, 22);
            this.labelUrunler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUrunler.Name = "labelUrunler";
            this.labelUrunler.Size = new System.Drawing.Size(103, 22);
            this.labelUrunler.TabIndex = 55;
            this.labelUrunler.Text = "ÜRÜNLER";
            // 
            // btnDukkanIslemleri
            // 
            this.btnDukkanIslemleri.Location = new System.Drawing.Point(393, 446);
            this.btnDukkanIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnDukkanIslemleri.Name = "btnDukkanIslemleri";
            this.btnDukkanIslemleri.Size = new System.Drawing.Size(200, 46);
            this.btnDukkanIslemleri.TabIndex = 74;
            this.btnDukkanIslemleri.Text = "Dükkan İşlemleri";
            this.btnDukkanIslemleri.UseVisualStyleBackColor = true;
            this.btnDukkanIslemleri.Click += new System.EventHandler(this.btnDukkanIslemleri_Click);
            // 
            // btnYeniSatisIslemi
            // 
            this.btnYeniSatisIslemi.Location = new System.Drawing.Point(655, 448);
            this.btnYeniSatisIslemi.Margin = new System.Windows.Forms.Padding(4);
            this.btnYeniSatisIslemi.Name = "btnYeniSatisIslemi";
            this.btnYeniSatisIslemi.Size = new System.Drawing.Size(139, 44);
            this.btnYeniSatisIslemi.TabIndex = 75;
            this.btnYeniSatisIslemi.Text = "Yeni Satış İşlemi";
            this.btnYeniSatisIslemi.UseVisualStyleBackColor = true;
            this.btnYeniSatisIslemi.Click += new System.EventHandler(this.btnYeniSatisIslemi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 491);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 76;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(199, 491);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(106, 31);
            this.btnAra.TabIndex = 77;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnYazdır
            // 
            this.btnYazdır.Location = new System.Drawing.Point(655, 498);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(137, 42);
            this.btnYazdır.TabIndex = 78;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 544);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnYeniSatisIslemi);
            this.Controls.Add(this.btnDukkanIslemleri);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lblIndirimliTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.labelOdeme);
            this.Controls.Add(this.rbKrediKarti);
            this.Controls.Add(this.rbNakit);
            this.Controls.Add(this.btnSiparişOnay);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.btnToplamTutarHesapla);
            this.Controls.Add(this.labelToplamTutar);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.labelSepet);
            this.Controls.Add(this.lbSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.labelAdet);
            this.Controls.Add(this.lbUrunler);
            this.Controls.Add(this.labelUrunler);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "SATIŞ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblIndirimliTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label labelOdeme;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Button btnSiparişOnay;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnToplamTutarHesapla;
        private System.Windows.Forms.Label labelToplamTutar;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label labelSepet;
        private System.Windows.Forms.ListBox lbSepet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label labelAdet;
        private System.Windows.Forms.ListBox lbUrunler;
        private System.Windows.Forms.Label labelUrunler;
        private System.Windows.Forms.Button btnDukkanIslemleri;
        private System.Windows.Forms.Button btnYeniSatisIslemi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnYazdır;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}