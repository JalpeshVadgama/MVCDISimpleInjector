using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDISimpleInjector.Startup))]
namespace MVCDISimpleInjector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
