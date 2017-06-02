using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailUnsubscribe.Startup))]
namespace EmailUnsubscribe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
