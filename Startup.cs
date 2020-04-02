using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataAnnotation.Startup))]
namespace DataAnnotation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
