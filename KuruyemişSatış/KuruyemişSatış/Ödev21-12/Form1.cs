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
    public partial class Form1 : Form
    {
        Form2 SecimIslemi = new Form2();
        Form4 DukkanIslemleri=new Form4();
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-2N9J56H;Initial Catalog=KuruyemisSatıs;Integrated Security=True");

        public static KasaGorevlisi yeniKasiyer = new KasaGorevlisi();
        public static KasaGorevlisi GirisYapanKasaGorevlisi = new KasaGorevlisi();
        public static KasaGorevlisi KasaGorevlisi1 = new KasaGorevlisi("ABDULKADİR", "BEŞEN", "1" , 5519625170);
        public static KasaGorevlisi KasaGorevlisi2 = new KasaGorevlisi("V","D","2",987654321);
       

        private void btnKasiyerGiris_Click(object sender, EventArgs e)
        {
            if (baglantı.State.ToString() == "Closed")
            {
                baglantı.Open();
                MessageBox.Show("Bağlantı durumu açık");
            }
            else
            {
                MessageBox.Show("Bağlantı zaten açık");
            }



            GirisYapanKasaGorevlisi.Ad = txtKasiyerAd.Text.ToUpper();
            GirisYapanKasaGorevlisi.Soyad = txtKasiyerSoyadi.Text.ToUpper();
            GirisYapanKasaGorevlisi.SigortaNo = txtSigortaNo.Text.ToUpper();


            if (GirisYapanKasaGorevlisi.Ad==KasaGorevlisi1.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi1.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi1.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else if (GirisYapanKasaGorevlisi.Ad == KasaGorevlisi2.Ad && GirisYapanKasaGorevlisi.Soyad == KasaGorevlisi2.Soyad && GirisYapanKasaGorevlisi.SigortaNo == KasaGorevlisi2.SigortaNo)
            {
                GirisYapanKasaGorevlisi.KisiBilgisiDoldur(txtKasiyerAd.Text, txtKasiyerSoyadi.Text, txtSigortaNo.Text);
                SecimIslemi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen Kasiyer Bilgileri Yanlış. Lütfen Tekrar Deneyin.");
                txtKasiyerAd.Text = "";
                txtKasiyerSoyadi.Text = "";
                txtSigortaNo.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
