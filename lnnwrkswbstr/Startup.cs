using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lnnwrkswbstr.Startup))]
namespace lnnwrkswbstr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
