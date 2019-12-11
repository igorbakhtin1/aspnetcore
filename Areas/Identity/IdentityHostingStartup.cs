using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(IgorForum.Areas.Identity.IdentityHostingStartup))]
namespace IgorForum.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}