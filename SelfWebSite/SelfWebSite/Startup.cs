using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelfWebSite.Startup))]
namespace SelfWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
