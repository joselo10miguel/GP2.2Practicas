using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalWeb2019.Startup))]
namespace PortalWeb2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
