using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasterPageASPver3.Startup))]
namespace MasterPageASPver3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
