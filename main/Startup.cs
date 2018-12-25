using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(main.Startup))]
namespace main
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
