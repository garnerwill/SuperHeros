using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperHerosapp.Startup))]
namespace SuperHerosapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
