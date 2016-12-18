using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeSheets.Web.Startup))]
namespace TimeSheets.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
