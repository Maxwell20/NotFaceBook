using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotFaceBook.Startup))]
namespace NotFaceBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
