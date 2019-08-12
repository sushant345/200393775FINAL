using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200393775F.Startup))]
namespace _200393775F
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
