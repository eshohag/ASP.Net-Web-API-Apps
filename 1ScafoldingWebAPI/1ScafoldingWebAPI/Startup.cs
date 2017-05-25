using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1ScafoldingWebAPI.Startup))]
namespace _1ScafoldingWebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
