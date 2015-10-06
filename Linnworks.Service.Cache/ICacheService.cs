using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Linnworks.Service.Cache
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICacheService
    {
        [OperationContract]
        bool PostData(IP ip);

        [OperationContract]
        IEnumerable<IP> GetIps();

        [OperationContract]
        bool UpdateIps(IEnumerable<IP> ips);

        [OperationContract]
        bool CheckForBlockedIp(string ip);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Linnworks.Service.Cache.ContractType".
    [DataContract]
    public class IP
    {
        [DataMember]
        public int Id {get; set;}
        
        [DataMember]
        public string Ip { get; set; }

        [DataMember]
        [Description("Amount of days")]
        public int Duration { get; set; }

        [DataMember]
        public DateTime EndDate { get; set; }
    }
}
