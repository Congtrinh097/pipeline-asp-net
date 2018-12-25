using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiplineASPNET.Startup))]
namespace PiplineASPNET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
