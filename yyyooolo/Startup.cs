using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yyyooolo.Startup))]
namespace yyyooolo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
