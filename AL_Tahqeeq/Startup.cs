using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AL_Tahqeeq.Startup))]
namespace AL_Tahqeeq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
