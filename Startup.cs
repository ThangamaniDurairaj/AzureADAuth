using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureAD.Startup))]
namespace AzureAD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
