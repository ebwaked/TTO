using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTO.Startup))]
namespace TTO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
