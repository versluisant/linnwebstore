using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Linnworks.Service.Cache
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CacheService : ICacheService
    {
        public bool PostData(IP ip)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IP> GetIps()
        {
            throw new NotImplementedException();
        }

        public bool UpdateIps(IEnumerable<IP> ips)
        {
            throw new NotImplementedException();
        }

        public bool CheckForBlockedIp(string ip)
        {
            throw new NotImplementedException();
        }
    }
}
