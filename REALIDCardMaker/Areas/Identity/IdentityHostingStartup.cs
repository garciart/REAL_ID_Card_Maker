using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using REALIDCardMaker.Areas.Identity.Data;
using REALIDCardMaker.Models;

[assembly: HostingStartup(typeof(REALIDCardMaker.Areas.Identity.IdentityHostingStartup))]
namespace REALIDCardMaker.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<REALIDCardMakerContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("REALIDCardMakerContextConnection")));

                services.AddDefaultIdentity<REALIDCardMakerUser>()
                    .AddEntityFrameworkStores<REALIDCardMakerContext>();
            });
        }
    }
}