using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class RoleMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0256850f-483d-43e2-b4e6-ae8bb1d13bfc", null, "manager", "manager" },
                    { "797df3eb-145a-47b8-8ba7-51243a2a3260", null, "user", "user" },
                    { "f37047ff-754d-4274-8776-a8dff4b0e353", null, "admin", "admin" },
                    { "fe69aa10-a77d-46a5-a836-c432583da4ee", null, "doctor", "doctor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0256850f-483d-43e2-b4e6-ae8bb1d13bfc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "797df3eb-145a-47b8-8ba7-51243a2a3260");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f37047ff-754d-4274-8776-a8dff4b0e353");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe69aa10-a77d-46a5-a836-c432583da4ee");
        }
    }
}
