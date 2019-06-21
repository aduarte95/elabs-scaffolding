using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elabs.Startup))]
namespace Elabs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
