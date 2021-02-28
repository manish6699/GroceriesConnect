using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroceriesConnect.Startup))]
namespace GroceriesConnect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
