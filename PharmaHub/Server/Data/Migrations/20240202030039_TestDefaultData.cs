using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmaHub.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "664008bd-18a6-42ce-a9ff-6f5c0f26bd35", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEO6oxgxFTh3gXDBOoHUtSNQXS2eJNzyU65oT4XjK4ik41qsOvoK3JfI2jICA9CRAng==", null, false, "32320051-cce7-4906-b1da-78a52cb84580", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(7821), new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(7853), new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "1 Boon Lay Road", "12345678", "System", new DateTime(2024, 2, 2, 11, 0, 38, 266, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 2, 2, 11, 0, 38, 266, DateTimeKind.Local).AddTicks(775), "joey@gmail.com", "Joey Lim", "System" },
                    { 2, "1 Pasir Ris Drive", "12345678", "System", new DateTime(2024, 2, 2, 11, 0, 38, 266, DateTimeKind.Local).AddTicks(779), new DateTime(2024, 2, 2, 11, 0, 38, 266, DateTimeKind.Local).AddTicks(780), "rwong@gmail.com", "Rachel Wong", "System" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Contact", "Country", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "12345678", "China", "System", new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(9770), new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(9775), "fevermed@gmail.com", "FeverMed", "System" },
                    { 2, "87654321", "Germany", "System", new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(9779), new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(9780), "biomed@gmail.com", "AntiBio", "System" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Contact", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "Position", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "12345678", "System", new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(9064), "joey@gmail.com", "Joey Lim", "Head Doctor", "System" },
                    { 2, "12345678", "System", new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(9071), new DateTime(2024, 2, 2, 11, 0, 38, 265, DateTimeKind.Local).AddTicks(9072), "rwong@gmail.com", "Rachel Wong", "Assistant Nurse", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 52, 16, 278, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 1, 14, 15, 52, 16, 278, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 14, 15, 52, 16, 278, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 1, 14, 15, 52, 16, 278, DateTimeKind.Local).AddTicks(1260) });
        }
    }
}
