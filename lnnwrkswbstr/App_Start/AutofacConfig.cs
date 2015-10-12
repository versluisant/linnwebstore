using Autofac;
using Linnworks.Service.Cache;

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
                .InstancePerLifetimeScope();

            builder.Build();
        }
    }
}