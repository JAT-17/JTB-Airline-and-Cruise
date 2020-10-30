using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JTB_Airline_and_Cruise.Startup))]
namespace JTB_Airline_and_Cruise
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
