using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beatleaderauthnet5.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Beatleaderauthnet5.Areas.Identity.Data
{
    public class Beatleaderauthnet5Context : IdentityDbContext<Beatleaderauthnet5User>
    {
        public Beatleaderauthnet5Context(DbContextOptions<Beatleaderauthnet5Context> options)
            : base(options)
        {
        }
        public DbSet<Beatleaderauthnet5.Models.Beatmap> Beatmap { get; set; }

        public DbSet<Beatleaderauthnet5.Models.Song> Song { get; set; }

        public DbSet<Beatleaderauthnet5.Models.Score> Score { get; set; }

        public DbSet<Beatleaderauthnet5.Models.Player> Player { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
