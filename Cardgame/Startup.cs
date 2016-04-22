using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cardgame.Startup))]
namespace Cardgame
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
