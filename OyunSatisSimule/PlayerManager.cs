using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSimule
{
    class PlayerManager : IPlayer
    {
        public void Ekle(Player oyuncu)
        {
            Console.WriteLine("Oyuncu eklendi");
        }

        public void Guncelle(Player oyuncu)
        {
            Console.WriteLine("Oyuncu güncellendi");
        }

        public void Sil(Player oyuncu)
        {
            Console.WriteLine("Oyuncu silindi");
        }
    }
}
