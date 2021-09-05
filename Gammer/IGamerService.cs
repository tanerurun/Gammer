using System;
using System.Collections.Generic;
using System.Text;

namespace Gammer
{
    interface IGamerService
    {
        void add(Gamer gamer);
        void remove(Gamer gamer);   
        void delete(Gamer gamer);
    }
}
