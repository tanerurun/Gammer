using System;
using System.Collections.Generic;
using System.Text;
using Gammer;

namespace Gammer
{
    class TCKNCheck : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.tckn), gamer.name.ToUpper(), gamer.lastName.ToUpper(), gamer.id);
        }
    }

    internal class KPSPublicSoapClient
    {
        internal bool TCKimlikNoDogrula(long v1, string v2, string v3, int id)
        {
            throw new NotImplementedException();
        }
    }
}
