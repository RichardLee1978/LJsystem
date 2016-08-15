using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LJsystem.Startup))]
namespace LJsystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
