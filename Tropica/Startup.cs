using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tropica.Startup))]
namespace Tropica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
