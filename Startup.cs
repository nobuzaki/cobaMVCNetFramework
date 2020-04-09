using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CobaMVCNetFramework.Startup))]
namespace CobaMVCNetFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
