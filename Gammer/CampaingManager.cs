using System;
using System.Collections.Generic;
using System.Text;

namespace Gammer
{
    class CampaingManager : ICampaingService
    {
        public void create(Campaing campaing)
        {
            Console.WriteLine("Kampanay oluştu");
        }

        public void delete(Campaing campaing)
        {
            Console.WriteLine("kampanaya silindi");
        }

        public void update(Campaing campaing)
        {
            Console.WriteLine("kampanaya güncellendi");
        }
    }
}
