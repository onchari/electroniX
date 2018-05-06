using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(electroniX.Startup))]
namespace electroniX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
