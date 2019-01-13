using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewMusic.Startup))]
namespace NewMusic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
