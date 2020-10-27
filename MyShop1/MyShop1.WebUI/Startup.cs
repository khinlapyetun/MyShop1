using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop1.WebUI.Startup))]
namespace MyShop1.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
