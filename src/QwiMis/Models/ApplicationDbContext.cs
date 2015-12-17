using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using QWI.Models.dbmodels;

namespace QwiMis.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
     //   protected override void OnModelCreating(ModelBuilder builder)
       // {
            //base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


        //}
        public DbSet<accountgroup> accountgroup { get; set; }
        public DbSet<accounttypes> accounttypes { get; set; }
        public DbSet<chartofaccount> chartofaccount { get; set; }
        public DbSet<transactions> transactions { get; set; }
    }
}
