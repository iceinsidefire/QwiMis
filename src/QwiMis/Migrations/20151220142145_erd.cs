using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace QwiMis.Migrations
{
    public partial class erd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_accounttypes_accountgroup_accountgroupid", table: "accounttypes");
            migrationBuilder.DropForeignKey(name: "FK_chartofaccount_accountgroup_accountgroupid", table: "chartofaccount");
            migrationBuilder.DropForeignKey(name: "FK_chartofaccount_accounttypes_accounttypesid", table: "chartofaccount");
            migrationBuilder.CreateTable(
                name: "prickling",
                columns: table => new
                {
                    pricklingid = table.Column<Guid>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prickling", x => x.pricklingid);
                });
            migrationBuilder.CreateTable(
                name: "productcategory",
                columns: table => new
                {
                    productcategoryid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryname = table.Column<string>(nullable: true),
                    chartofaccountchartofaccountid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productcategory", x => x.productcategoryid);
                    table.ForeignKey(
                        name: "FK_productcategory_chartofaccount_chartofaccountchartofaccountid",
                        column: x => x.chartofaccountchartofaccountid,
                        principalTable: "chartofaccount",
                        principalColumn: "chartofaccountid",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "producttype",
                columns: table => new
                {
                    producttypeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    typename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producttype", x => x.producttypeid);
                });
            migrationBuilder.CreateTable(
                name: "gatein",
                columns: table => new
                {
                    gateinid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: false),
                    productcategoryproductcategoryid = table.Column<int>(nullable: true),
                    vehicle_number = table.Column<string>(nullable: true),
                    weight = table.Column<decimal>(nullable: false),
                    weightslipnumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gatein", x => x.gateinid);
                    table.ForeignKey(
                        name: "FK_gatein_productcategory_productcategoryproductcategoryid",
                        column: x => x.productcategoryproductcategoryid,
                        principalTable: "productcategory",
                        principalColumn: "productcategoryid",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    chartofaccountchartofaccountid = table.Column<int>(nullable: true),
                    productcategoryproductcategoryid = table.Column<int>(nullable: true),
                    productname = table.Column<string>(nullable: true),
                    producttypeproducttypeid = table.Column<int>(nullable: true),
                    size = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productid);
                    table.ForeignKey(
                        name: "FK_products_chartofaccount_chartofaccountchartofaccountid",
                        column: x => x.chartofaccountchartofaccountid,
                        principalTable: "chartofaccount",
                        principalColumn: "chartofaccountid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_productcategory_productcategoryproductcategoryid",
                        column: x => x.productcategoryproductcategoryid,
                        principalTable: "productcategory",
                        principalColumn: "productcategoryid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_producttype_producttypeproducttypeid",
                        column: x => x.producttypeproducttypeid,
                        principalTable: "producttype",
                        principalColumn: "producttypeid",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "coils_wirerod",
                columns: table => new
                {
                    coilnumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    coilweight = table.Column<decimal>(nullable: false),
                    gateingateinid = table.Column<int>(nullable: true),
                    productproductid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coils_wirerod", x => x.coilnumber);
                    table.ForeignKey(
                        name: "FK_coils_wirerod_gatein_gateingateinid",
                        column: x => x.gateingateinid,
                        principalTable: "gatein",
                        principalColumn: "gateinid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_coils_wirerod_products_productproductid",
                        column: x => x.productproductid,
                        principalTable: "products",
                        principalColumn: "productid",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "pricklingdetail",
                columns: table => new
                {
                    pricklingdetailid = table.Column<Guid>(nullable: false),
                    coilnumber = table.Column<int>(nullable: false),
                    pricklingpricklingid = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pricklingdetail", x => x.pricklingdetailid);
                    table.ForeignKey(
                        name: "FK_pricklingdetail_coils_wirerod_coilnumber",
                        column: x => x.coilnumber,
                        principalTable: "coils_wirerod",
                        principalColumn: "coilnumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pricklingdetail_prickling_pricklingpricklingid",
                        column: x => x.pricklingpricklingid,
                        principalTable: "prickling",
                        principalColumn: "pricklingid",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_accounttypes_accountgroup_accountgroupid",
                table: "accounttypes",
                column: "accountgroupid",
                principalTable: "accountgroup",
                principalColumn: "accountgroupid",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_chartofaccount_accountgroup_accountgroupid",
                table: "chartofaccount",
                column: "accountgroupid",
                principalTable: "accountgroup",
                principalColumn: "accountgroupid",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_chartofaccount_accounttypes_accounttypesid",
                table: "chartofaccount",
                column: "accounttypesid",
                principalTable: "accounttypes",
                principalColumn: "accounttypesid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_accounttypes_accountgroup_accountgroupid", table: "accounttypes");
            migrationBuilder.DropForeignKey(name: "FK_chartofaccount_accountgroup_accountgroupid", table: "chartofaccount");
            migrationBuilder.DropForeignKey(name: "FK_chartofaccount_accounttypes_accounttypesid", table: "chartofaccount");
            migrationBuilder.DropTable("pricklingdetail");
            migrationBuilder.DropTable("coils_wirerod");
            migrationBuilder.DropTable("prickling");
            migrationBuilder.DropTable("gatein");
            migrationBuilder.DropTable("products");
            migrationBuilder.DropTable("productcategory");
            migrationBuilder.DropTable("producttype");
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_accounttypes_accountgroup_accountgroupid",
                table: "accounttypes",
                column: "accountgroupid",
                principalTable: "accountgroup",
                principalColumn: "accountgroupid",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_chartofaccount_accountgroup_accountgroupid",
                table: "chartofaccount",
                column: "accountgroupid",
                principalTable: "accountgroup",
                principalColumn: "accountgroupid",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_chartofaccount_accounttypes_accounttypesid",
                table: "chartofaccount",
                column: "accounttypesid",
                principalTable: "accounttypes",
                principalColumn: "accounttypesid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
