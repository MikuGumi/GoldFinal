using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoldFinal.Startup))]
namespace GoldFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
