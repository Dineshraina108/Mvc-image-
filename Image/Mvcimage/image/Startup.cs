using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(image.Startup))]
namespace image
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
