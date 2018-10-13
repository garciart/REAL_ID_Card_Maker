using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using REAL_ID_Card_Maker.Areas.Identity.Data;

namespace REAL_ID_Card_Maker.Models
{
    public class REAL_ID_Card_MakerContext : IdentityDbContext<REAL_ID_Card_MakerUser>
    {
        public REAL_ID_Card_MakerContext(DbContextOptions<REAL_ID_Card_MakerContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
