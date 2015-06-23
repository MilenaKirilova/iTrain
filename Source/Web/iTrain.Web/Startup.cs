using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iTrain.Web.Startup))]
namespace iTrain.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
