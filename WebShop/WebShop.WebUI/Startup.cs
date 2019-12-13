using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShop.WebUI.Startup))]
namespace WebShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
