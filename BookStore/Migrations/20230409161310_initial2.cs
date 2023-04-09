using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bc6f72c0-66aa-4ec9-adb3-fba947bd0014", "1", "Admin", "ADMIN" },
                    { "ff6f72c0-66aa-4ec9-adb3-fba947bd0014", "2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c3bdd301-35d1-4114-b5e4-78d509b5607c", 0, "d9647819-fcca-435b-a82a-79ced94218e7", null, "edzaryan@gmail.com", true, "Edgar", "Yeghiazaryan", true, null, "EDZARYAN@GMAIL.COM", "EDZARYAN@GMAIL.COM", "AQAAAAIAAYagAAAAEGZs3xTXJEpQBrpeXPwwrxLS+iQV5Ha+aTIr2zgLaE/L3Cbgf+viQfP1H53QClaUaQ==", null, false, "02846ca8-42e2-4362-87db-18b464f95d31", false, "edzaryan@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc6f72c0-66aa-4ec9-adb3-fba947bd0014");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6f72c0-66aa-4ec9-adb3-fba947bd0014");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c");
        }
    }
}
