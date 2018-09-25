using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaZyLaNa.Startup))]
namespace RaZyLaNa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
