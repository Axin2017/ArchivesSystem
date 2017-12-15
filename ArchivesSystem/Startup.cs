using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArchivesSystem.Startup))]
namespace ArchivesSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
