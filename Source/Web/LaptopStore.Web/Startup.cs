using Microsoft.Owin;

using Owin;

[assembly: OwinStartupAttribute(typeof(LaptopStore.Web.Startup))]

namespace LaptopStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
