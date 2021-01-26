using System;
using System.Collections.Generic;

namespace OyunSatisSimule
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu ekleme
            Player oyuncu = new Player() { Ad = "Oğuzhan", Soyad = "Ay", DogumYıl = "1998", TcKimlik = "0010000" };
            Player oyuncu2 = new Player() { Ad = "Serhat", Soyad = "Ay", DogumYıl = "1992", TcKimlik = "0322000" };
            Player oyuncu3 = new Player() { Ad = "Ahmet", Soyad = "Güler", DogumYıl = "1997", TcKimlik = "0033004" };
            Player oyuncu4 = new Player() { Ad = "Emre ", Soyad = "Cengiz", DogumYıl = "1995", TcKimlik = "0455000" };

            //Kamanya Ekleme
            Campaign k = new Campaign() { kampanyaAd = "%25 indirim", kampanyaSure = "02.03.2021", kampanyaDetay = "2. oyun da %25 indirim" };
            Campaign k2 = new Campaign() { kampanyaAd = "%10 indirim", kampanyaSure = "02.02.2021", kampanyaDetay = "İlk  oyun alımında %10 indirim" };
            Campaign k3 = new Campaign() { kampanyaAd = "5.oyun  bedava", kampanyaSure = "05.03.2021", kampanyaDetay = "4 oyun alana 5.oyun  bedava" };
            Campaign k4 = new Campaign() { kampanyaAd = " %5 indirim", kampanyaSure = "02.05.2021", kampanyaDetay = "50 tl ve üzeri oyunlarda %5 indirim" };


            //Kampanya ekleme silme güncelleme
            CampaignManager kampanyaManager = new CampaignManager();

            Console.WriteLine("--------------------------------------------------KAMPANYA İŞLEMLERİ----------------------------------------------------");
            kampanyaManager.Ekle(k);
            Console.WriteLine("");
            kampanyaManager.Sil(k2);
            Console.WriteLine("");
            kampanyaManager.Guncelle(k3);
            Console.WriteLine("");

            //oyuncu ekleme silme güncellme
            PlayerManager oyuncuManager = new PlayerManager();

            Console.WriteLine("OYUNCU İŞLEMLERİ");
            oyuncuManager.Ekle(oyuncu3);
            oyuncuManager.Sil(oyuncu2);
            oyuncuManager.Guncelle(oyuncu3);


            IVerificationService edevletDogrulama = new EdevletVerification();
            IVerificationService sifreDogrulama = new PasswordVerification();
            OperationManager islemlerManager = new OperationManager();


            //dogrulama e devlet ile mi şifre ile mi yada her ikisi
            List<IVerificationService> dogrulamaServices = new List<IVerificationService>() { edevletDogrulama };

            //kampanyaları listelede tutma
            List<Campaign> kampanya = new List<Campaign>() { k, k2, k3, k4 };

            Console.WriteLine("İŞLEMLER");
            islemlerManager.Satis(oyuncu, k2);
            Console.WriteLine(" ");
            islemlerManager.Dogrula(dogrulamaServices);


            Console.WriteLine("KAMPANYALAR");

            islemlerManager.Kampanyalar(kampanya);
        }
    }
}
