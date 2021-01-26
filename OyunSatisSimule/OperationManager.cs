using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSimule
{
    class OperationManager
    {
        public void Dogrula(List<IVerificationService> dogrulama)
        {
            foreach (var dogrulamaService in dogrulama)
            {
                dogrulamaService.Dogrula();
            }
        }

        public void Satis(Player oyuncu, Campaign kampanya)
        {
            Console.WriteLine(oyuncu.Ad + " " + "adlı oyuncuya" + " " + kampanya.kampanyaAd + " " + " kampanyası uygulanarak satış yapıldı");
        }

        public void Kampanyalar(List<Campaign> kampanyas)
        {
            foreach (var kampanya in kampanyas)
            {
                Console.WriteLine("Kampanya Adı:" + " " + kampanya.kampanyaAd + " " + "Detay:" + " " + kampanya.kampanyaDetay);                
            }
        }

    }
}
