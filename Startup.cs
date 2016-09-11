using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvctest2.Startup))]
namespace mvctest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
