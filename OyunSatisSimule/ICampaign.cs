using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSimule
{
    interface ICampaign
    {
        public void Ekle(Campaign kampanya);
        public void Guncelle(Campaign kampanya);
        public void Sil(Campaign kampanya);
    }
}
