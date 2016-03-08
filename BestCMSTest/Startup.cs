using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BestCMSTest.Startup))]
namespace BestCMSTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
