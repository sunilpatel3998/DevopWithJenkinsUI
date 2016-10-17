using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevopWithJenkinsUI.Startup))]
namespace DevopWithJenkinsUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
