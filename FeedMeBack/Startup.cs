using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FeedMeBack.Startup))]
namespace FeedMeBack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
