using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_33_CHENGMUNLENG_WSD_PA1.Startup))]
namespace _33_CHENGMUNLENG_WSD_PA1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
