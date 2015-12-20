using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace QwiMis.Migrations
{
    public partial class _4th : Migration
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
            migrationBuilder.DropForeignKey(name: "FK_pricklingdetail_coils_wirerod_coilnumber", table: "pricklingdetail");
            migrationBuilder.DropForeignKey(name: "FK_products_productcategory_productcategoryproductcategoryid", table: "products");
            migrationBuilder.DropForeignKey(name: "FK_products_producttype_producttypeproducttypeid", table: "products");
            migrationBuilder.DropColumn(name: "productcategoryproductcategoryid", table: "products");
            migrationBuilder.DropColumn(name: "producttypeproducttypeid", table: "products");
            migrationBuilder.AddColumn<int>(
                name: "productcategoryid",
                table: "products",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<int>(
                name: "producttypeid",
                table: "products",
                nullable: false,
                defaultValue: 0);
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
                onDelete: ReferentialAction.NoAction);
            migrationBuilder.AddForeignKey(
                name: "FK_pricklingdetail_coils_wirerod_coilnumber",
                table: "pricklingdetail",
                column: "coilnumber",
                principalTable: "coils_wirerod",
                principalColumn: "coilnumber",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_products_productcategory_productcategoryid",
                table: "products",
                column: "productcategoryid",
                principalTable: "productcategory",
                principalColumn: "productcategoryid",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_products_producttype_producttypeid",
                table: "products",
                column: "producttypeid",
                principalTable: "producttype",
                principalColumn: "producttypeid",
                onDelete: ReferentialAction.Cascade);
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
            migrationBuilder.DropForeignKey(name: "FK_pricklingdetail_coils_wirerod_coilnumber", table: "pricklingdetail");
            migrationBuilder.DropForeignKey(name: "FK_products_productcategory_productcategoryid", table: "products");
            migrationBuilder.DropForeignKey(name: "FK_products_producttype_producttypeid", table: "products");
            migrationBuilder.DropColumn(name: "productcategoryid", table: "products");
            migrationBuilder.DropColumn(name: "producttypeid", table: "products");
            migrationBuilder.AddColumn<int>(
                name: "productcategoryproductcategoryid",
                table: "products",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "producttypeproducttypeid",
                table: "products",
                nullable: true);
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
            migrationBuilder.AddForeignKey(
                name: "FK_pricklingdetail_coils_wirerod_coilnumber",
                table: "pricklingdetail",
                column: "coilnumber",
                principalTable: "coils_wirerod",
                principalColumn: "coilnumber",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_products_productcategory_productcategoryproductcategoryid",
                table: "products",
                column: "productcategoryproductcategoryid",
                principalTable: "productcategory",
                principalColumn: "productcategoryid",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_products_producttype_producttypeproducttypeid",
                table: "products",
                column: "producttypeproducttypeid",
                principalTable: "producttype",
                principalColumn: "producttypeid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
