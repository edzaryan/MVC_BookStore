using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c333b18-f26a-44e6-9c79-262aa1ebffb4", "EDZARYAN@GMAIL.COM", "EDZARYAN@GMAIL.COM", "AQAAAAIAAYagAAAAELTYUctMFaZQUWrlPhsn+CIlWCc2eJ7rg9lJurJ2Wi9EUbsVZS8IY5vkFWbJK0o66g==", "88d3b047-b57b-4f79-9e0c-cd7321981e4f" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1e10532-cc43-451f-a80f-2790d1d7225f", null, null, "AQAAAAIAAYagAAAAEGgPunjq+LvSejeuHuE/I89ABvF9hKhMElCQ0VHWmPoSYUn4maoMtGIKcV9xHUVdxA==", "0142e2fd-e93b-45e1-9edf-761e1c3b20ee" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6780), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6797), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6801), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6803), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6805), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6807), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6809), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6811), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 4, 3, 4, 21, 9, 795, DateTimeKind.Local).AddTicks(6813) });
        }
    }
}
