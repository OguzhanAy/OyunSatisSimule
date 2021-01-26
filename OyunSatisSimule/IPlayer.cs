using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSimule
{
    interface IPlayer
    {
        public void Ekle(Player oyuncu);
        public void Guncelle(Player oyuncu);
        public void Sil(Player oyuncu);
    }
}
