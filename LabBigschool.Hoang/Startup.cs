using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabBigschool.Hoang.Startup))]
namespace LabBigschool.Hoang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
