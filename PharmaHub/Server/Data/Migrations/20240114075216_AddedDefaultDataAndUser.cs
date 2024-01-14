using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmaHub.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Name", "ProductId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 14, 15, 52, 16, 278, DateTimeKind.Local).AddTicks(1243), new DateTime(2024, 1, 14, 15, 52, 16, 278, DateTimeKind.Local).AddTicks(1256), "For Bacterial Infections", "Antibiotics", null, "System" },
                    { 2, "System", new DateTime(2024, 1, 14, 15, 52, 16, 278, DateTimeKind.Local).AddTicks(1259), new DateTime(2024, 1, 14, 15, 52, 16, 278, DateTimeKind.Local).AddTicks(1260), "For Fungal Infections", "Antifungals", null, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
