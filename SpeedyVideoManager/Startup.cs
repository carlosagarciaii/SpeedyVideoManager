using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpeedyVideoManager.Startup))]
namespace SpeedyVideoManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
