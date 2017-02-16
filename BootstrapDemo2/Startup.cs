using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapDemo2.Startup))]
namespace BootstrapDemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
