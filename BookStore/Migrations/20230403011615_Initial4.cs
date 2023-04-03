using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86265ddc-8367-4a48-b622-9454c8ca43cf", "AQAAAAIAAYagAAAAEE6rJGUacAgx+n4aRH4lJ6+HRn54Hv40plHh7508DkF87bYEY/GrhySSZ4745XbkqQ==", "ba189444-184a-4ce3-8f32-f61d4db77a27" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3429), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3448), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3450), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3452), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3454), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3456), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3458), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3462), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3464), new DateTime(2023, 4, 3, 5, 16, 15, 514, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bc6f72c0-66aa-4ec9-adb3-fba947bd0014", "c3bdd301-35d1-4114-b5e4-78d509b5607c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6f72c0-66aa-4ec9-adb3-fba947bd0014");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc6f72c0-66aa-4ec9-adb3-fba947bd0014", "c3bdd301-35d1-4114-b5e4-78d509b5607c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc6f72c0-66aa-4ec9-adb3-fba947bd0014");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c333b18-f26a-44e6-9c79-262aa1ebffb4", "AQAAAAIAAYagAAAAELTYUctMFaZQUWrlPhsn+CIlWCc2eJ7rg9lJurJ2Wi9EUbsVZS8IY5vkFWbJK0o66g==", "88d3b047-b57b-4f79-9e0c-cd7321981e4f" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3697), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3717), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3719), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3721), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3723), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3725), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3727), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3730), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3732), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3734), new DateTime(2023, 4, 3, 4, 23, 39, 954, DateTimeKind.Local).AddTicks(3734) });
        }
    }
}
