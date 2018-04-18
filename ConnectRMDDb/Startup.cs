using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectRMDDb.Startup))]
namespace ConnectRMDDb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
