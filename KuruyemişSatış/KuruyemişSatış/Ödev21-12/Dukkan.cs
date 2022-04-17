using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev21_12
{
    public class Dukkan
    {
        public List<Urun> UrunlerListesi { get; set; }
        public Terminal Terminal1 = new Terminal();
        public string DukkanAdi { get; set; }
        public string DukkanAdresi { get; set; }

        
        public void UrunEkle(Urun u)
        {
            
           
            
            bool x = true;
           foreach (Urun ur in UrunlerListesi)
            {
               
                if (ur.Tanım.UrunKodu == u.Tanım.UrunKodu)
                {
                    x = false;
                    ur.Tanım.UrunAdet = ur.Tanım.UrunAdet + u.Tanım.UrunAdet;
                }
               
            }

           
            if(x==true)
            {
                UrunlerListesi.Add(u);
                x = true;

            }

            
        }
     
        public void UrunCikar(Urun u )
        {   
             
            bool x = true;
            
            foreach (Urun ur in UrunlerListesi)
            {
                
               
                if (ur.Tanım.UrunKodu == u.Tanım.UrunKodu)
                {
                    x = false;
                    ur.Tanım.UrunAdet = ur.Tanım.UrunAdet - u.Tanım.Miktar;
                }

            }


            if (x == true)
            {
                UrunlerListesi.Remove(u);
                x = true;

            }
            
        }
         public  string UrunListele()
         {
             string mesaj = "";
             foreach (Urun u in UrunlerListesi)
             {
                 {
                     mesaj += "\n Ürün Kodu: " + u.Tanım.UrunKodu.ToString() +
                              " Ürün Adı: " + u.Tanım.Ad+
                              " Ürün Fiyatı: " + u.Tanım.Fiyatı.ToString();
                 }

             }
             return mesaj;
         }

        public Dukkan()
        {
            this.DukkanAdi = "Kuruyemişcim";
            this.DukkanAdresi = "Haydar Bey, Turgut Özal Blv., 46050 Onikişubat/Kahramanmaraş";
            this.Terminal1.SeriNo = 001;

            this.UrunlerListesi = new List<Urun>();
            Urun U1 = new Urun();
            Urun U2 = new Urun();
            Urun U3 = new Urun();
            Urun U4 = new Urun();
            Urun U5 = new Urun();
            Urun U6 = new Urun();
            Urun U7 = new Urun();
            Urun U8 = new Urun();
            Urun U9 = new Urun();
            Urun U10 = new Urun();
            Urun U11 = new Urun();
            Urun U12 = new Urun();
            Urun U13 = new Urun();
            Urun U14 = new Urun();
            Urun U15 = new Urun();
            Urun U16 = new Urun();
            Urun U17 = new Urun();
            Urun U18 = new Urun();


            U1.Tanım.UrunKodu = 001;
            U1.Tanım.Tanım = "Kavrulmuş Kuruyemiş";
            U1.Tanım.Ad = "Kavrulmuş Badem İçi";
            U1.Tanım.Fiyatı = 117;
            U1.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U1);

            U2.Tanım.UrunKodu = 002;
            U2.Tanım.Tanım = "Kavrulmuş Kuruyemiş";
            U2.Tanım.Ad = "Kaju fıstığı";
            U2.Tanım.Fiyatı = 119;
            U2.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U2);

            U3.Tanım.UrunKodu = 003;
            U3.Tanım.Tanım = "Kavrulmuş Kuruyemiş";
            U3.Tanım.Ad = "Kavrulmuş Fıstık İçi";
            U3.Tanım.Fiyatı = 29;
            U3.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U3);

            U4.Tanım.UrunKodu = 004;
            U4.Tanım.Tanım = "Kurutulmuş Meyveler";
            U4.Tanım.Ad = "Besni Üzümü";
            U4.Tanım.Fiyatı = 29;
            U4.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U4);

            U5.Tanım.UrunKodu = 005;
            U5.Tanım.Tanım = "Kurutulmuş Meyveler";
            U5.Tanım.Ad = "Çekirdekli Siyah Erik Kurusu";
            U5.Tanım.Fiyatı = 20;
            U5.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U5);

            U6.Tanım.UrunKodu = 006;
            U6.Tanım.Tanım = "Kurutulmuş Meyveler";
            U6.Tanım.Ad = "Medine Hurması";
            U6.Tanım.Fiyatı = 100;
            U6.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U6);

            U7.Tanım.UrunKodu = 007;
            U7.Tanım.Tanım = "Kahve ve Çay Çeşitleri";
            U7.Tanım.Ad = "Dibek Kahvesi";
            U7.Tanım.Fiyatı = 25;
            U7.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U7);

            U8.Tanım.UrunKodu = 008;
            U8.Tanım.Tanım = "Kahve ve Çay Çeşitleri";
            U8.Tanım.Ad = "Osmanlı Kahvesi";
            U8.Tanım.Fiyatı = 35;
            U8.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U8);

            U9.Tanım.UrunKodu = 009;
            U9.Tanım.Tanım = "Kahve ve Çay Çeşitleri";
            U9.Tanım.Ad = "Bergamotlu Poşet Çay";
            U9.Tanım.Fiyatı = 23;
            U9.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U9);

            U10.Tanım.UrunKodu = 010;
            U10.Tanım.Tanım = "Hediyelik Ürünler";
            U10.Tanım.Ad = "Meyveli Çikolata";
            U10.Tanım.Fiyatı = 27;
            U10.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U10);

            U11.Tanım.UrunKodu = 011;
            U11.Tanım.Tanım = "Hediyelik Ürünler";
            U11.Tanım.Ad = "Karışık Lüks Çerez";
            U11.Tanım.Fiyatı = 105;
            U11.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U11);

            U12.Tanım.UrunKodu = 0012;
            U12.Tanım.Tanım = "Hediyelik Ürünler";
            U12.Tanım.Ad = "Leblebi Çeşileri";
            U12.Tanım.Fiyatı = 12;
            U12.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U12);

            U13.Tanım.UrunKodu = 013;
            U13.Tanım.Tanım = "Çikolata Ve Draje Şeker Çeşitleri";
            U13.Tanım.Ad = "Tablet Bitter Çikolata";
            U13.Tanım.Fiyatı = 14;
            U13.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U13);

            U14.Tanım.UrunKodu = 014;
            U14.Tanım.Tanım = "Çikolata Ve Draje Şeker Çeşitleri";
            U14.Tanım.Ad = "Cevizli Haşhaşlı Leblebi";
            U14.Tanım.Fiyatı = 20;
            U14.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U14);

            U15.Tanım.UrunKodu = 015;
            U5.Tanım.Tanım = "Çikolata Ve Draje Şeker Çeşitleri";
            U15.Tanım.Ad = "Yer Fıstığı Krokan";
            U15.Tanım.Fiyatı = 10;
            U15.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U15);

            U16.Tanım.UrunKodu = 016;
            U5.Tanım.Tanım = "İçecek Çeşitleri";
            U16.Tanım.Ad = "1lt Pepsi";
            U16.Tanım.Fiyatı = 7;
            U16.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U16);

            U17.Tanım.UrunKodu = 017;
            U5.Tanım.Tanım = "İçecek Çeşitleri";
            U17.Tanım.Ad = "2lt Coca Cola";
            U17.Tanım.Fiyatı = 10;
            U17.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U17);

            U18.Tanım.UrunKodu = 018;
            U5.Tanım.Tanım = "İçecek Çeşitleri";
            U18.Tanım.Ad = "Meysu Pomelo 1 lt";
            U18.Tanım.Fiyatı = 10;
            U18.Tanım.UrunAdet = 50;
            UrunlerListesi.Add(U18);
        }

    }
}
