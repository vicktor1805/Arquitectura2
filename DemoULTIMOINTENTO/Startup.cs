using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoULTIMOINTENTO.Startup))]
namespace DemoULTIMOINTENTO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
