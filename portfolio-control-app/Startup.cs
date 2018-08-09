using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portfolio_control_app.Startup))]
namespace portfolio_control_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
