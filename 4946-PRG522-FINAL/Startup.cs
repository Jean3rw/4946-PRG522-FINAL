using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_4946_PRG522_FINAL.Startup))]
namespace _4946_PRG522_FINAL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
