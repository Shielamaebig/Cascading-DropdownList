using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cascading_DropdownList.Startup))]
namespace Cascading_DropdownList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
