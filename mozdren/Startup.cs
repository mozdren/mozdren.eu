using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mozdren.Startup))]
namespace mozdren
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
