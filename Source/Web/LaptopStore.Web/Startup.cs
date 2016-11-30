using Microsoft.Owin;
using Ninject;
using Owin;
using System.Reflection;

[assembly: OwinStartupAttribute(typeof(LaptopStore.Web.Startup))]

namespace LaptopStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }

        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel;
        }
    }
}
