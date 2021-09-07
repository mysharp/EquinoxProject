using Equinox.UI.Web.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Equinox.UI.Web.Areas.Identity.IdentityHostingStartup))]
namespace Equinox.UI.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
            });
        }
    }
}