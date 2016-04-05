using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Projekt_WebbShop.Startup))]
namespace MVC_Projekt_WebbShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
