using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebArchives.Startup))]
namespace WebArchives
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
        
       
}
}
