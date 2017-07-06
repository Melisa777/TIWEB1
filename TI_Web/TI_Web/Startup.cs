using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TI_Web.Startup))]
namespace TI_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
