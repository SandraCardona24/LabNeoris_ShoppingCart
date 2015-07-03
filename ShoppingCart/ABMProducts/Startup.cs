using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABMProducts.Startup))]
namespace ABMProducts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
