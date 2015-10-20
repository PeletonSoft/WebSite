using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeletonWebApp.Startup))]
namespace PeletonWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
