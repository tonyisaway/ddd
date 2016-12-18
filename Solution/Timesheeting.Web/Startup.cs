using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Timesheeting.Web.Startup))]
namespace Timesheeting.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
