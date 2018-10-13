using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using REAL_ID_Card_Maker.Areas.Identity.Data;
using REAL_ID_Card_Maker.Models;

[assembly: HostingStartup(typeof(REAL_ID_Card_Maker.Areas.Identity.IdentityHostingStartup))]
namespace REAL_ID_Card_Maker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<REAL_ID_Card_MakerContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("REAL_ID_Card_MakerContextConnection")));

                services.AddDefaultIdentity<REAL_ID_Card_MakerUser>()
                    .AddEntityFrameworkStores<REAL_ID_Card_MakerContext>();
            });
        }
    }
}