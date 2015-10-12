using System;

namespace Linnworks.DAL.Models
{
    public class BlackListIp
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public DateTime Created { get; set; }
        public bool IsAlive { get; set; }
        public int Duration { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
