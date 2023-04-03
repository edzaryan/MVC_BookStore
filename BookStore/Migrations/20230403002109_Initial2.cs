using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1e10532-cc43-451f-a80f-2790d1d7225f", true, "AQAAAAIAAYagAAAAEGgPunjq+LvSejeuHuE/I89ABvF9hKhMElCQ0VHWmPoSYUn4maoMtGIKcV9xHUVdxA==", "0142e2fd-e93b-45e1-9edf-761e1c3b20ee" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aadfaae9-f553-46f8-97d7-401daf4417b3", false, "AQAAAAIAAYagAAAAEBmJrZtwuu3HqSxfcN7lPVvDD7aD9+g5hwCLOcaAkriNoRzFjcd7JlNpTtOSzAYdQQ==", "d1d54deb-6417-4573-b221-9281d5551007" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2476), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2491), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2494), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2496), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2498), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2500), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2502), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2504), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 4, 3, 4, 13, 16, 225, DateTimeKind.Local).AddTicks(2509) });
        }
    }
}
