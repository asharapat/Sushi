using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task12.Startup))]
namespace Task12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
