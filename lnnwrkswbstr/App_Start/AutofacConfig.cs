using Autofac;
using Autofac.Builder;
using Linnworks.Service.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lnnwrkswbstr.App_Start
{
    public class AutofacConfig
    {
        public static IContainer Container;
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CacheService>()
                .As<ICacheService>()
                .AsImplementedInterfaces()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.Build();
        }
    }
}