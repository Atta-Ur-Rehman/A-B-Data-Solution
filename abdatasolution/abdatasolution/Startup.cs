using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(abdatasolution.Startup))]
namespace abdatasolution
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
