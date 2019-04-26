using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mymagasin.WebUI.Startup))]
namespace Mymagasin.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
