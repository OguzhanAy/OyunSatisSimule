using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSimule
{
    class CampaignManager : ICampaign
    {
        public void Ekle(Campaign kampanya)
        {
            Console.WriteLine("Kampanya Adı:" + " " + kampanya.kampanyaAd + "\n" + "Detay:" + " " + kampanya.kampanyaDetay + " " + "EKLENDİ.....");
        }

        public void Guncelle(Campaign kampanya)
        {
            Console.WriteLine(kampanya.kampanyaAd + " " + "Adlı kampanya güncellendi;");
        }

        public void Sil(Campaign kampanya)
        {
            Console.WriteLine(kampanya.kampanyaAd + " " + "Adlı Kampanya silindi");
        }
    }
}
