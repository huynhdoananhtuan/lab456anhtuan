using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tuận.Startup))]
namespace tuận
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
