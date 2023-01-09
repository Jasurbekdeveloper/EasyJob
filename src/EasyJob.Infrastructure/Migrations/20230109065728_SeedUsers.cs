using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyJob.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Country", "PostalCode", "Region", "Street" },
                values: new object[] { new Guid("bc56836e-0345-4f01-a883-47f39e32e079"), "Uzbekistan", null, null, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AddressId", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PhoneNumber", "Role", "Salt", "UpdatedAt" },
                values: new object[] { new Guid("bc56836e-0345-4f01-a883-47f39e32e079"), new Guid("bc56836e-0345-4f01-a883-47f39e32e079"), new DateTime(2023, 1, 9, 6, 57, 28, 483, DateTimeKind.Utc).AddTicks(5692), "toxirjon@gmail.com", "Toxirjon", null, "12345", "931234567", 4, "ed5edc2d-5501-4a11-a3d9-fdf292b24151", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc56836e-0345-4f01-a883-47f39e32e079"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("bc56836e-0345-4f01-a883-47f39e32e079"));
        }
    }
}
