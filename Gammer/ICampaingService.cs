using System;
using System.Collections.Generic;
using System.Text;

namespace Gammer
{
    interface ICampaingService
    {
        void create(Campaing campaing);
        void delete(Campaing campaing);
        void update(Campaing campaing);
    }
}
