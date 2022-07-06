using System;
using Beatleaderauthnet5.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Beatleaderauthnet5.Areas.Identity.IdentityHostingStartup))]
namespace Beatleaderauthnet5.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Beatleaderauthnet5Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Beatleaderauthnet5ContextConnection")));

                services.AddDefaultIdentity<Beatleaderauthnet5User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Beatleaderauthnet5Context>();
            });
        }
    }
}