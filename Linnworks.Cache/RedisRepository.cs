using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linnworks.Cache
{
    public class RedisRepository
    {
        public static ConnectionMultiplexer _redis;
        public static IDatabase _db;
        public static IServer _server;
        public bool Connect()
        {
            //TODO move to config
            _redis = ConnectionMultiplexer.Connect("localhost");
            _server = _redis.GetServer("localhost:6379");
            _db = _redis.GetDatabase();
            return _db != null;
        }

        public bool AddIps(IEnumerable<KeyValuePair<string, DateTime>> ips)
        {
            foreach (var ip in ips)
            {
                _db.StringSet(ip.Key, "");
                _db.KeyExpireAsync(ip.Key, ip.Value, CommandFlags.FireAndForget);
            }
            return true;
        }

        public IEnumerable<string> GetKeys()
        {
            return _server.Keys().Select(x => x.ToString());
        }
    }
}
