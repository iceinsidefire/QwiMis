using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using QwiMis.Models;

namespace QwiMis.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("QWI.Models.dbmodels.accountgroup", b =>
                {
                    b.Property<int>("accountgroupid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Id");

                    b.Property<string>("accountgroupname");

                    b.HasKey("accountgroupid");
                });

            modelBuilder.Entity("QWI.Models.dbmodels.accounttypes", b =>
                {
                    b.Property<int>("accounttypesid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accountgroupid");

                    b.Property<string>("accounttypename");

                    b.HasKey("accounttypesid");
                });

            modelBuilder.Entity("QWI.Models.dbmodels.chartofaccount", b =>
                {
                    b.Property<int>("chartofaccountid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("accountgroupid");

                    b.Property<string>("accountgroupname");

                    b.Property<string>("accounttypename");

                    b.Property<int>("accounttypesid");

                    b.Property<decimal>("balance");

                    b.Property<string>("chartofaccountname");

                    b.Property<bool>("isslave");

                    b.Property<int?>("masteraccountid");

                    b.Property<decimal>("openingbalance");

                    b.Property<Guid?>("transactionstransactionid");

                    b.HasKey("chartofaccountid");
                });

            modelBuilder.Entity("QWI.Models.dbmodels.transactions", b =>
                {
                    b.Property<Guid>("transactionid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("chartofaccountid");

                    b.Property<decimal?>("credit");

                    b.Property<decimal?>("debit");

                    b.Property<DateTime>("entrydate");

                    b.Property<int>("referencevalue");

                    b.Property<DateTime>("transactiondate");

                    b.Property<int>("transacttypeid");

                    b.HasKey("transactionid");
                });

            modelBuilder.Entity("QwiMis.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("QwiMis.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("QwiMis.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("QwiMis.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("QWI.Models.dbmodels.accounttypes", b =>
                {
                    b.HasOne("QWI.Models.dbmodels.accountgroup")
                        .WithMany()
                        .HasForeignKey("accountgroupid");
                });

            modelBuilder.Entity("QWI.Models.dbmodels.chartofaccount", b =>
                {
                    b.HasOne("QWI.Models.dbmodels.accountgroup")
                        .WithMany()
                        .HasForeignKey("accountgroupid");

                    b.HasOne("QWI.Models.dbmodels.accounttypes")
                        .WithMany()
                        .HasForeignKey("accounttypesid");

                    b.HasOne("QWI.Models.dbmodels.transactions")
                        .WithMany()
                        .HasForeignKey("transactionstransactionid");
                });
        }
    }
}
