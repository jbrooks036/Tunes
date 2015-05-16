using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tunes_MVC.Startup))]
namespace Tunes_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
