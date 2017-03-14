using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TripProj.Startup))]
namespace TripProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
