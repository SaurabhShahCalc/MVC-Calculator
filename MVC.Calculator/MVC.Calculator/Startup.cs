using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC.Calculator.Startup))]
namespace MVC.Calculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
