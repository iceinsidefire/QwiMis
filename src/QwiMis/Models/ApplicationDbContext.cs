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

        public virtual DbSet<accountgroup> accountgroup { get; set; }
        public virtual DbSet<accounttypes> accounttypes { get; set; }
        public virtual DbSet<chartofaccount> chartofaccount { get; set; }
        public virtual DbSet<transactions> transactions { get; set; }
        public virtual DbSet<productcategory> productcategory { get; set; }
        public virtual DbSet<producttype> producttype { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<coils_wirerod> coils_wirerod { get; set; }
        public virtual DbSet<gatein> gatein { get; set; }
        public virtual DbSet<prickling> prickling { get; set; }
        public virtual DbSet<pricklingdetail> pricklingdetail { get; set; }
    }
}