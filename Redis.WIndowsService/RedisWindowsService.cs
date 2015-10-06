using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Redis.WIndowsService
{
    public partial class RedisWindowsService : ServiceBase
    {
        private const string FilePath = @"E:\RedisServer\redis-server.exe";

        public RedisWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var pSI = new ProcessStartInfo(FilePath);
            using (var process = new Process())
            {
                if (!process.Start())
                    Environment.Exit(-1);
            }

        }

        protected override void OnStop()
        {
            base.OnStop();
        }
    }
}
