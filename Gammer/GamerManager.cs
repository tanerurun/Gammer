using System;
using System.Collections.Generic;
using System.Text;

namespace Gammer
{
    class GamerManager : IGamerService
    {
        public void add(Gamer gamer)
        {
            Console.WriteLine("oyuncu eklendi");
        }

        public void delete(Gamer gamer)
        {
            Console.WriteLine("oyuncu silindi");
        }

        public void remove(Gamer gamer)
        {
            Console.WriteLine("oyuncu güncellendi");
        }
    }
}
