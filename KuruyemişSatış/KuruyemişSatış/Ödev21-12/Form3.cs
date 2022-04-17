using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev21_12
{
    public partial class Form3 : Form
    {
        Form4 DukkanIslemleri = new Form4();


        public static decimal ToplamSatisTutari = 0;
        public static decimal GeciciTutar = 0;


        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2N9J56H;Initial Catalog=KuruyemisSatıs;Integrated Security=True");


        public static UrunKatalogu UrunKatalogu = new UrunKatalogu();

        public static HesapDefteri HesapDefteri = new HesapDefteri();

        public static SatisKalemi SatisKalemi = new SatisKalemi();
        public static Satis Satis = new Satis();
        public static NakitOdeme Nakit = new NakitOdeme();
        public static KrediKartiIleOdeme Kredili = new KrediKartiIleOdeme();


        private void Form3_Load(object sender, EventArgs e)
        {

            foreach (Urun u in UrunKatalogu.Dukkanimiz.UrunlerListesi)
            {
                lbUrunler.Items.Add(u);
            }
            if (lbUrunler.SelectedItem == null)
            {
                btnHesapla.Enabled = false;
            }
            else
            {
                btnHesapla.Enabled = true;
            }

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            Urun u = (Urun)lbUrunler.SelectedItem;
            u.Tanım.Miktar = Convert.ToInt32(nudAdet.Value);
            lblTutar.Text = u.Tanım.tutarhesapla().ToString() + " TL";
            btnSepeteEkle.Enabled = true;
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {

            Urun u = (Urun)lbUrunler.SelectedItem;
            u.Tanım.Miktar = Convert.ToInt32(nudAdet.Value);

            SatisKalemi.UrunEkle(u);
            lbSepet.Items.Add(u.Tanım.Ad + " " + u.Tanım.Fiyatı + " x " + u.Tanım.Miktar + " = " + u.Tanım.tutarhesapla().ToString() + " TL");
            lblTutar.Text = "    ";
            lbUrunler.SelectedItem = null;
            nudAdet.Value = 1;
            btnSepeteEkle.Enabled = false;
            GeciciTutar += u.Tanım.Fiyatı * u.Tanım.Miktar;


        }

        private void btnToplamTutarHesapla_Click(object sender, EventArgs e)
        {

            lblToplam.Text = GeciciTutar.ToString() + "  TL";
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            Satis.KrediliOdeme.OdemeMiktari = 0;
            Satis.NakitOdeme.Ode(GeciciTutar);
            lblIndirimliTutar.Text = Satis.NakitOdeme.OdemeMiktari.ToString() + " TL";
            btnSiparişOnay.Visible = true;

        }

        private void rbKrediKarti_CheckedChanged(object sender, EventArgs e)
        {
            Satis.NakitOdeme.OdemeMiktari = 0;
            Satis.KrediliOdeme.Ode(GeciciTutar);
            lblIndirimliTutar.Text = Satis.KrediliOdeme.OdemeMiktari.ToString() + " TL";
            btnSiparişOnay.Visible = true;
        }

        private void btnSiparişOnay_Click(object sender, EventArgs e)
        {
            foreach (Urun u in SatisKalemi.AlinanUrunler)
            {
                UrunKatalogu.Dukkanimiz.UrunCikar(u);
            }
            SatisKalemi.AlinanUrunler.Clear();
            Satis.Tarih = DateTime.Now;
            string mesaj = "";
            string[] veriler1 = new string
            [lbSepet.Items.Count];
            for (int i = 0; i < lbSepet.Items.Count; i++)
            {
                veriler1[i] = lbSepet.Items[i].ToString();
                mesaj += veriler1[i] + "\n";
            }
            MessageBox.Show("" + HesapDefteri.Dukkanimiz.DukkanAdi +
                            "\n" + HesapDefteri.Dukkanimiz.DukkanAdresi +
                            "\n\nSatış Tarihi : " + Satis.Tarih.ToString() +
                            "\nTerminal Seri Numarası : " + HesapDefteri.Dukkanimiz.Terminal1.SeriNo.ToString() +
                            "\n\nAlınan Ürünler\n" + mesaj +
                            "\n--------------------------------------------------------------" +
                            "\nToplam Tutar : " + (Satis.KrediliOdeme.OdemeMiktari + Satis.NakitOdeme.OdemeMiktari).ToString() +
                            "\n--------------------------------------------------------------" +
                            "\n\n Kasiyer : " + Form1.GirisYapanKasaGorevlisi.Ad + " " + Form1.GirisYapanKasaGorevlisi.Soyad
                );

            ToplamSatisTutari += Satis.KrediliOdeme.OdemeMiktari + Satis.NakitOdeme.OdemeMiktari;
            Satis.ToplamTutar += ToplamSatisTutari;
            btnHesapla.Enabled = false;
            btnSepeteEkle.Enabled = false;
            btnToplamTutarHesapla.Enabled = false;

        }

        private void lbUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUrunler.SelectedItem == null)
            {
                btnHesapla.Enabled = false;
            }
            else
            {
                nudAdet.Value = 1;
                Urun u = (Urun)lbUrunler.SelectedItem;
                nudAdet.Maximum = u.Tanım.UrunAdet;
                btnHesapla.Enabled = true;
            }
        }


        private void btnYeniSatisIslemi_Click(object sender, EventArgs e)
        {
            GeciciTutar = 0;
            if (Application.OpenForms[0] == this)
            {
                Application.Restart();
            }
            else
            {
                Form3 f = new Form3();
                f.Show();
                this.Close();

            }

        }

        private void btnDukkanIslemleri_Click(object sender, EventArgs e)
        {
            DukkanIslemleri.Show();
            this.Close();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int siraNo = lbUrunler.Items.IndexOf(textBox1.Text);
            if (siraNo > -1)
            {
                lbUrunler.SelectedIndex = siraNo;
            }
            else
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 18);
            SolidBrush firca = new SolidBrush(Color.Black);
            Pen kalem = new Pen(Color.Black);

            e.Graphics.DrawString("Düzenlenme Tarihi: " + DateTime.Now.ToLongDateString() + " " +
                       "" + DateTime.Now.ToLongTimeString(), font, firca, 50, 25);
            e.Graphics.DrawLine(kalem, 50, 65, 770, 65);
            e.Graphics.DrawLine(kalem, 50, 1000, 50, 65);

            e.Graphics.DrawLine(kalem, 50, 1000, 770, 1000);
            e.Graphics.DrawLine(kalem, 770, 1000, 770, 65);
            ////////////////////////////////////////////////
            font = new Font("Arial", 20, FontStyle.Bold);
            e.Graphics.DrawString("Ürün Listesi", font, firca, 350, 75);
            e.Graphics.DrawLine(kalem, 50, 110, 770, 110);

            font = new Font("Arial", 15, FontStyle.Bold);
            e.Graphics.DrawString("Sıra", font, firca, 60, 118);
            e.Graphics.DrawString("Birim fiyat", font, firca, 350, 118);
            e.Graphics.DrawString("Miktar", font, firca, 500, 118);
            e.Graphics.DrawString("Toplam Fiyat", font, firca, 610, 118);
            e.Graphics.DrawLine(kalem, 50, 150, 770, 150);
            /////////////////////////////////////////////////////

            e.Graphics.DrawString("Genel Toplam=" + lblToplam.Text + "  ", font, firca, 400, 1000);
            /////////////////////////////////////////////////////
            
        }
    }
}
