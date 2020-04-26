using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_101.Startup))]
namespace MVC_101
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
