using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPage = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookPdfFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGalleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGalleries_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                values: new object[] { "c3bdd301-35d1-4114-b5e4-78d509b5607c", 0, "097018af-c01b-429d-b8ba-6f1cb2a5899d", null, "edzaryan@gmail.com", true, "Edgar", "Yeghiazaryan", true, null, "EDZARYAN@GMAIL.COM", "EDZARYAN@GMAIL.COM", "AQAAAAIAAYagAAAAEM5r+R6/mG12umeywdQyVJlviZ7AHKJAUOei7tRpMDwmoFzsNc8TJo/TwB61QU9hWQ==", null, false, "b08e07f5-f38c-4567-86e9-ce07fe823775", false, "edzaryan@gmail.com" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "German" },
                    { 3, "Russian" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bc6f72c0-66aa-4ec9-adb3-fba947bd0014", "c3bdd301-35d1-4114-b5e4-78d509b5607c" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookPdfFileUrl", "Category", "CoverImageUrl", "CreatedOn", "Description", "LanguageId", "Title", "TotalPage", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Emily Perez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3121), "Head First C# is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First C#", 703, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3144) },
                    { 2, "Madison Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3152), "The C++ Programming Language is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The C++ Programming Language", 766, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3152) },
                    { 3, "Alexander Garcia", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3156), "Beginning Git and GitHub is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Beginning Git and GitHub", 228, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3156) },
                    { 4, "Ethan Taylor", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3161), "JavaScript for Web Developers is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "JavaScript for Web Developers", 229, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3161) },
                    { 5, "Mac Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3221), "Python (All-In-One) For Dummies is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Python (All-In-One) For Dummies", 319, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3222) },
                    { 6, "Alexander Lopez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3232), "Head First Java is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First Java", 579, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3233) },
                    { 7, "Khai Perez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3235), "Scala for the Impatient (Second Edition) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Scala for the Impatient (Second Edition)", 452, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3235) },
                    { 8, "Evander Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3237), "Learn PHP 8 is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Learn PHP 8", 536, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3237) },
                    { 9, "Koen Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3239), "Kotlin In Action is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Kotlin In Action", 327, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3240) },
                    { 10, "Mia Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3266), "Head First Swift is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First Swift", 404, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3267) },
                    { 11, "Khai Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3bb.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3269), "Emotional Intelligence is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Emotional Intelligence", 170, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3270) },
                    { 12, "Alexander Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f555.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3272), "Dark Psychology is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dark Psychology", 279, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3272) },
                    { 13, "Madison Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f333.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3275), "Emotional Intelligence (Why It Can Matter More Than IQ) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Emotional Intelligence (Why It Can Matter More Than IQ)", 145, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3275) },
                    { 14, "James Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-hho4f4f706f3bb.webp", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3277), "The Emotional Intelligence workbook is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Emotional Intelligence workbook", 419, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3278) },
                    { 15, "Liam Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-7bf4f3f706f3fb.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3308), "Emotional Intelligence (for leadership) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Emotional Intelligence (for leadership)", 589, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3308) },
                    { 16, "Sophia Davis", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3310), "Take What You Need is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Take What You Need", 517, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3310) },
                    { 17, "Madison Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3312), "A Reason For Marriage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "A Reason For Marriage", 191, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3313) },
                    { 18, "Charlotte Taylor", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3316), "Stormy Surrender is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Stormy Surrender", 587, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3316) },
                    { 19, "Elio Moore", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd088wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3319), "In Graywolf's Hands (The Bachelors Of Blair Memorial) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "In Graywolf's Hands (The Bachelors Of Blair Memorial)", 543, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3319) },
                    { 20, "Elijah Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079wwcvbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3343), "Maximum Ride Forever is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Maximum Ride Forever", 137, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3344) },
                    { 21, "Kylian Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9ee8-ddd079wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3345), "The Lost Wife is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Lost Wife", 281, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3346) },
                    { 22, "Elio Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3347), "The Forced Bride is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Forced Bride", 498, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3348) },
                    { 23, "Isabella Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3350), "A Lady Betrayed is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "A Lady Betrayed", 491, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3350) },
                    { 24, "Alexander Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\4ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3352), "Winning the Highlander's Heart is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Winning the Highlander's Heart", 376, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3352) },
                    { 25, "Evander Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\5ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3354), "Alaska Skies is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Alaska Skies", 626, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3355) },
                    { 26, "Eliam Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\6ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3420), "Hungry for More is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Hungry for More", 257, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3420) },
                    { 27, "Sophia Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\7ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3422), "Gem of a Girl is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Gem of a Girl", 401, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3423) },
                    { 28, "Camilo Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\8ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3425), "Surrender to the Fury is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Surrender to the Fury", 545, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3426) },
                    { 29, "Matt Brown", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\9ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3428), "Leave Yesterday Behind is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Leave Yesterday Behind", 451, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3429) },
                    { 30, "Elio Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\99fc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3430), "The Lion's Bride is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Lion's Bride", 688, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3431) },
                    { 31, "Bridger Casey", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\77fc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3458), "Villa In The Sun is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Villa In The Sun", 419, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3458) },
                    { 32, "Onyx Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3460), "Lover's Touch is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Lover's Touch", 576, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3460) },
                    { 33, "Ozzy Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1111.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3462), "Never A Lady is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Never A Lady", 419, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3462) },
                    { 34, "Jiraiya Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1112.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3467), "A Reason For Marriage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "A Reason For Marriage", 684, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3467) },
                    { 35, "Ethan Davis", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1113.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3469), "The Siren is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Siren", 358, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3469) },
                    { 36, "Ozzy Lopez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1114.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3494), "Twice Her Husband (Silhouette Special Edition) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Twice Her Husband (Silhouette Special Edition)", 590, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3495) },
                    { 37, "Abigail Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1115.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3496), "The Blind - Date Bride (The Australians) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Blind - Date Bride (The Australians)", 237, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3497) },
                    { 38, "Mia Lopez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1116.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3498), "Only Love is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Only Love", 300, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3499) },
                    { 39, "Mia Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1117.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3501), "Christmas at Lilac Cottage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Christmas at Lilac Cottage", 164, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3501) },
                    { 40, "Koen Davis", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1118.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3503), "Once Upon A Scandal (Once Upon Scandal) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Once Upon A Scandal (Once Upon Scandal)", 407, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3503) },
                    { 41, "Charlotte Brown", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1119.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3532), "Wild Jasmine is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Wild Jasmine", 765, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3532) },
                    { 42, "Amiri Johnson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1110.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3534), "Promise Of A Family is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Promise Of A Family", 105, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3534) },
                    { 43, "Emma Clark", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11d1.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3536), "Happy Christmas Love Mills Boon Helen Bianchin Et Al is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Happy Christmas Love Mills Boon Helen Bianchin Et Al", 468, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3537) },
                    { 44, "Alexander Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1a12.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3539), "Sister to Meryl is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Sister to Meryl", 101, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3540) },
                    { 45, "Bjarne Brown", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3542), "Stellar Attraction is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Stellar Attraction", 251, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3542) },
                    { 46, "John Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3566), "The wife he couldn't forget / Seduced by the CEO is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The wife he couldn't forget / Seduced by the CEO", 463, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3567) },
                    { 47, "Ozzy Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3569), "Match For Mom is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Match For Mom", 238, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3569) },
                    { 48, "Andrew Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3571), "Lucianna is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Lucianna", 394, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3571) },
                    { 49, "Ethan Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3573), "Hidden mistress, public wife is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Hidden mistress, public wife", 469, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3573) },
                    { 50, "Kathy Thompson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa01-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3574), "Dance of Death is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dance of Death", 428, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3575) },
                    { 51, "Michael Cullen", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa02-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3598), "Bears, bears, bears is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Bears, bears, bears", 325, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3599) },
                    { 52, "Alexander Jackson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa03-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3601), "Mockingjay is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Mockingjay", 762, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3601) },
                    { 53, "Jiraiya Perez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa04-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3603), "Larklight is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Larklight", 489, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3603) },
                    { 54, "Mariot Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa05-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3605), "Flat Stanley on ice is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Flat Stanley on ice", 386, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3605) },
                    { 55, "Zyair Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa06-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3607), "Taran Wanderer (The Chronicles of Prydain) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Taran Wanderer (The Chronicles of Prydain)", 561, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3607) },
                    { 56, "Olivia Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa07-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3609), "Big Nate is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Big Nate", 136, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3609) },
                    { 57, "Kylian Casey", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa08-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3633), "In a Glass Grimmly is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "In a Glass Grimmly", 406, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3634) },
                    { 58, "Elijah Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa09-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3636), "Nate the Great Talks Turkey is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Nate the Great Talks Turkey", 636, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3636) },
                    { 59, "Elijah Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa10-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3638), "Thea Stilton And The Great Tulip Heist is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Thea Stilton And The Great Tulip Heist", 714, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3638) },
                    { 60, "Ava Duff", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa11-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3640), "Harry Potter and the Philosopher's Stone is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Harry Potter and the Philosopher's Stone", 224, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3640) },
                    { 61, "Eliam Lopez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa12-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3642), "The Book Thief is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Book Thief", 318, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3642) },
                    { 62, "Matt Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-aa13-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3666), "Cue for Treason is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Cue for Treason", 742, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3666) },
                    { 63, "Isabella Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b614-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3668), "The House of Hades is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The House of Hades", 263, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3668) },
                    { 64, "Khai Sanchez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b615-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3670), "Dangerous pumpkins is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Dangerous pumpkins", 200, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3670) },
                    { 65, "Eliam White", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b616-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3672), "Danger at the Landings is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Danger at the Landings", 562, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3672) },
                    { 66, "Jiraiya Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b617-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3703), "Battle of the Bots is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Battle of the Bots", 769, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3703) },
                    { 67, "Koen Lopez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b618-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3705), "Prise d'otages à Disneyland is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Prise d'otages à Disneyland", 521, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3705) },
                    { 68, "Eliam Perez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b619-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3707), "Games Magazine Presents the Kids' Giant Book of Games is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Games Magazine Presents the Kids' Giant Book of Games", 563, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3707) },
                    { 69, "Colter Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b620-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3709), "Lucy and the Wolf in Sheep's Clothing (A Young Lion Storybook) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Lucy and the Wolf in Sheep's Clothing (A Young Lion Storybook)", 609, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3710) },
                    { 70, "Bjarne Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b621-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3711), "Atlantis quest is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Atlantis quest", 639, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3712) },
                    { 71, "Elijah Williams", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b622-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3714), "The Way (Darby Creek Exceptional Titles) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Way (Darby Creek Exceptional Titles)", 174, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3714) },
                    { 72, "Ozzy Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b623-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3750), "The voice and the pendant is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The voice and the pendant", 383, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3750) },
                    { 73, "Loyal Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b624-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3752), "Hattie Marshall and the dangerous fire is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Hattie Marshall and the dangerous fire", 511, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3752) },
                    { 74, "Olivia Gonzalez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3754), "Henry and the hand-me-downs is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Henry and the hand-me-downs", 313, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3754) },
                    { 75, "William Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w01c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3755), "The eyes of darkness is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The eyes of darkness", 171, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3756) },
                    { 76, "Ozzy Cullen", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w02c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3757), "IT is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "IT", 385, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3758) },
                    { 77, "Noah Cullen", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w03c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3783), "The Shining is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Shining", 757, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3783) },
                    { 78, "Evander Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w04c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3785), "Cell is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Cell", 739, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3785) },
                    { 79, "Khai Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w05c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3787), "RED STORM RISING is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "RED STORM RISING", 409, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3787) },
                    { 80, "Evander Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w06c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3788), "Insomnia is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Insomnia", 557, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3789) },
                    { 81, "Noah Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w07c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3790), "Pet Sematary is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Pet Sematary", 242, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3791) },
                    { 82, "Madison Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w08c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3814), "Black wind is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Black wind", 317, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3814) },
                    { 83, "Zyair Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w09c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3816), "The Bachman Books is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Bachman Books", 292, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3816) },
                    { 84, "Mac Jackson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w10c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3818), "Just After Sunset is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Just After Sunset", 296, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3819) },
                    { 85, "Bridger Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w11c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3820), "Carrie is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Carrie", 594, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3821) },
                    { 86, "Mac Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w12c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3822), "Under the Dome is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Under the Dome", 704, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3823) },
                    { 87, "Andrew Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w13c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3849), "The bear and the dragon is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The bear and the dragon", 607, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3849) },
                    { 88, "Elio Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w14c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3851), "Dark Justice is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dark Justice", 461, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3851) },
                    { 89, "Noah Johnson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w15c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3853), "The good guy is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The good guy", 662, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3853) },
                    { 90, "Charlotte Casey", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w16c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3855), "Executive Orders is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Executive Orders", 384, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3855) },
                    { 91, "William Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w17c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3857), "Treasure is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Treasure", 433, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3857) },
                    { 92, "Elijah Brown", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w18c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3859), "The Green Mile is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Green Mile", 295, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3859) },
                    { 93, "Andrew Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w19c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3884), "Different Seasons is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Different Seasons", 157, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3884) },
                    { 94, "Amiri Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w20c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3886), "Debt of Honor is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Debt of Honor", 417, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3886) },
                    { 95, "Abigail Davis", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w21c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3888), "Atlantis Found is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Atlantis Found", 736, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3888) },
                    { 96, "Gian Taylor", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w22c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3890), "Wolves of the Calla is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Wolves of the Calla", 756, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3890) },
                    { 97, "Mac Clark", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w23c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3892), "Red rabbit is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Red rabbit", 272, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3892) },
                    { 98, "Andrew Cullen", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w24c11b7.jpg", new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3936), "The Dark Tower is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Dark Tower", 679, new DateTime(2023, 4, 9, 8, 33, 40, 105, DateTimeKind.Local).AddTicks(3936) }
                });

            migrationBuilder.InsertData(
                table: "BookGalleries",
                columns: new[] { "Id", "BookId", "Name", "URL" },
                values: new object[,]
                {
                    { 1, 1, "X.jpeg", "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png" },
                    { 2, 1, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 3, 1, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 4, 1, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 5, 2, "X.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg" },
                    { 6, 2, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 7, 2, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 8, 2, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 9, 3, "X.jpeg", "\\files\\books\\coverImages\\fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg" },
                    { 10, 3, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 11, 3, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 12, 3, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 13, 4, "X.jpeg", "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg" },
                    { 14, 4, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 15, 4, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 16, 4, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 17, 5, "X.jpeg", "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg" },
                    { 18, 5, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 19, 5, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 20, 5, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 21, 6, "X.jpeg", "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg" },
                    { 22, 6, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 23, 6, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 24, 6, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 25, 7, "X.jpeg", "\\files\\books\\coverImages\\01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg" },
                    { 26, 7, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 27, 7, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 28, 7, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 29, 8, "X.jpeg", "\\files\\books\\coverImages\\87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg" },
                    { 30, 8, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 31, 8, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 32, 8, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 33, 9, "X.jpeg", "\\files\\books\\coverImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg" },
                    { 34, 9, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 35, 9, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 36, 9, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 37, 10, "X.jpeg", "\\files\\books\\coverImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.jpg" },
                    { 38, 10, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 39, 10, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 40, 10, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 41, 11, "X.jpeg", "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3bb.jpg" },
                    { 42, 11, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 43, 11, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 44, 11, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 45, 12, "X.jpeg", "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f555.jpg" },
                    { 46, 12, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 47, 12, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 48, 12, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 49, 13, "X.jpeg", "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f333.jpg" },
                    { 50, 13, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 51, 13, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 52, 13, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 53, 14, "X.jpeg", "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-hho4f4f706f3bb.webp" },
                    { 54, 14, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 55, 14, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 56, 14, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 57, 15, "X.jpeg", "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-7bf4f3f706f3fb.jpg" },
                    { 58, 15, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 59, 15, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 60, 15, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 61, 16, "X.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbb_1.jpg" },
                    { 62, 16, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 63, 16, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 64, 16, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 65, 17, "X.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbbdd.jpg" },
                    { 66, 17, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 67, 17, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 68, 17, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 69, 18, "X.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079wwwcbbdd.jpg" },
                    { 70, 18, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 71, 18, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 72, 18, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 73, 19, "X.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd088wwwcbbdd.jpg" },
                    { 74, 19, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 75, 19, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 76, 19, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 77, 20, "X.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079wwcvbbdd.jpg" },
                    { 78, 20, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 79, 20, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 80, 20, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 81, 21, "X.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9ee8-ddd079wwwcbbdd.jpg" },
                    { 82, 21, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 83, 21, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 84, 21, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 85, 22, "X.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 86, 22, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 87, 22, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 88, 22, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 89, 23, "X.jpeg", "\\files\\books\\coverImages\\fffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 90, 23, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 91, 23, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 92, 23, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 93, 24, "X.jpeg", "\\files\\books\\coverImages\\4ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 94, 24, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 95, 24, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 96, 24, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 97, 25, "X.jpeg", "\\files\\books\\coverImages\\5ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 98, 25, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 99, 25, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 100, 25, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 101, 26, "X.jpeg", "\\files\\books\\coverImages\\6ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 102, 26, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 103, 26, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 104, 26, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 105, 27, "X.jpeg", "\\files\\books\\coverImages\\7ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 106, 27, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 107, 27, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 108, 27, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 109, 28, "X.jpeg", "\\files\\books\\coverImages\\8ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 110, 28, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 111, 28, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 112, 28, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 113, 29, "X.jpeg", "\\files\\books\\coverImages\\9ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 114, 29, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 115, 29, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 116, 29, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 117, 30, "X.jpeg", "\\files\\books\\coverImages\\99fc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 118, 30, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 119, 30, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 120, 30, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 121, 31, "X.jpeg", "\\files\\books\\coverImages\\77fc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 122, 31, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 123, 31, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 124, 31, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 125, 32, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg" },
                    { 126, 32, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 127, 32, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 128, 32, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 129, 33, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1111.jpg" },
                    { 130, 33, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 131, 33, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 132, 33, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 133, 34, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1112.jpg" },
                    { 134, 34, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 135, 34, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 136, 34, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 137, 35, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1113.jpg" },
                    { 138, 35, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 139, 35, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 140, 35, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 141, 36, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1114.jpg" },
                    { 142, 36, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 143, 36, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 144, 36, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 145, 37, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1115.jpg" },
                    { 146, 37, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 147, 37, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 148, 37, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 149, 38, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1116.jpg" },
                    { 150, 38, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 151, 38, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 152, 38, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 153, 39, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1117.jpg" },
                    { 154, 39, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 155, 39, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 156, 39, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 157, 40, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1118.jpg" },
                    { 158, 40, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 159, 40, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 160, 40, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 161, 41, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1119.jpg" },
                    { 162, 41, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 163, 41, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 164, 41, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 165, 42, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1110.jpg" },
                    { 166, 42, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 167, 42, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 168, 42, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 169, 43, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11d1.jpg" },
                    { 170, 43, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 171, 43, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 172, 43, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 173, 44, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1a12.jpg" },
                    { 174, 44, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 175, 44, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 176, 44, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 177, 45, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b3.jpg" },
                    { 178, 45, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 179, 45, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 180, 45, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 181, 46, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b4.jpg" },
                    { 182, 46, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 183, 46, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 184, 46, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 185, 47, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b5.jpg" },
                    { 186, 47, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 187, 47, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 188, 47, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 189, 48, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b6.jpg" },
                    { 190, 48, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 191, 48, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 192, 48, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 193, 49, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b7.jpg" },
                    { 194, 49, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 195, 49, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 196, 49, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 197, 50, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa01-4cbe-9ee8-ddd111wwwc11b3.jpg" },
                    { 198, 50, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 199, 50, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 200, 50, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 201, 51, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa02-4cbe-9ee8-ddd111wwwc11b4.jpg" },
                    { 202, 51, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 203, 51, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 204, 51, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 205, 52, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa03-4cbe-9ee8-ddd111wwwc11b5.jpg" },
                    { 206, 52, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 207, 52, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 208, 52, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 209, 53, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa04-4cbe-9ee8-ddd111wwwc11b6.jpg" },
                    { 210, 53, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 211, 53, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 212, 53, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 213, 54, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa05-4cbe-9ee8-ddd111wwwc11b7.jpg" },
                    { 214, 54, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 215, 54, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 216, 54, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 217, 55, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa06-4cbe-9ee8-ddd111wwwc11b3.jpg" },
                    { 218, 55, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 219, 55, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 220, 55, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 221, 56, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa07-4cbe-9ee8-ddd111wwwc11b4.jpg" },
                    { 222, 56, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 223, 56, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 224, 56, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 225, 57, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa08-4cbe-9ee8-ddd111wwwc11b5.jpg" },
                    { 226, 57, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 227, 57, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 228, 57, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 229, 58, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa09-4cbe-9ee8-ddd111wwwc11b6.jpg" },
                    { 230, 58, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 231, 58, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 232, 58, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 233, 59, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa10-4cbe-9ee8-ddd111wwwc11b7.jpg" },
                    { 234, 59, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 235, 59, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 236, 59, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 237, 60, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa11-4cbe-9ee8-ddd111wwwc11b3.jpg" },
                    { 238, 60, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 239, 60, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 240, 60, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 241, 61, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa12-4cbe-9ee8-ddd111wwwc11b4.jpg" },
                    { 242, 61, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 243, 61, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 244, 61, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 245, 62, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-aa13-4cbe-9ee8-ddd111wwwc11b5.jpg" },
                    { 246, 62, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 247, 62, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 248, 62, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 249, 63, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b614-4cbe-9ee8-ddd111wwwc11b6.jpg" },
                    { 250, 63, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 251, 63, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 252, 63, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 253, 64, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b615-4cbe-9ee8-ddd111wwwc11b7.jpg" },
                    { 254, 64, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 255, 64, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 256, 64, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 257, 65, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b616-4cbe-9ee8-ddd111wwwc11b3.jpg" },
                    { 258, 65, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 259, 65, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 260, 65, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 261, 66, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b617-4cbe-9ee8-ddd111wwwc11b4.jpg" },
                    { 262, 66, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 263, 66, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 264, 66, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 265, 67, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b618-4cbe-9ee8-ddd111wwwc11b5.jpg" },
                    { 266, 67, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 267, 67, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 268, 67, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 269, 68, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b619-4cbe-9ee8-ddd111wwwc11b6.jpg" },
                    { 270, 68, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 271, 68, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 272, 68, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 273, 69, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b620-4cbe-9ee8-ddd111wwwc11b7.jpg" },
                    { 274, 69, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 275, 69, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 276, 69, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 277, 70, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b621-4cbe-9ee8-ddd111wwwc11b3.jpg" },
                    { 278, 70, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 279, 70, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 280, 70, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 281, 71, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b622-4cbe-9ee8-ddd111wwwc11b4.jpg" },
                    { 282, 71, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 283, 71, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 284, 71, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 285, 72, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b623-4cbe-9ee8-ddd111wwwc11b5.jpg" },
                    { 286, 72, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 287, 72, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 288, 72, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 289, 73, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b624-4cbe-9ee8-ddd111wwwc11b6.jpg" },
                    { 290, 73, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 291, 73, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 292, 73, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 293, 74, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111wwwc11b7.jpg" },
                    { 294, 74, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 295, 74, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 296, 74, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 297, 75, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w01c11b7.jpg" },
                    { 298, 75, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 299, 75, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 300, 75, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 301, 76, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w02c11b7.jpg" },
                    { 302, 76, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 303, 76, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 304, 76, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 305, 77, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w03c11b7.jpg" },
                    { 306, 77, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 307, 77, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 308, 77, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 309, 78, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w04c11b7.jpg" },
                    { 310, 78, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 311, 78, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 312, 78, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 313, 79, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w05c11b7.jpg" },
                    { 314, 79, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 315, 79, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 316, 79, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 317, 80, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w06c11b7.jpg" },
                    { 318, 80, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 319, 80, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 320, 80, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 321, 81, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w07c11b7.jpg" },
                    { 322, 81, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 323, 81, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 324, 81, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 325, 82, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w08c11b7.jpg" },
                    { 326, 82, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 327, 82, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 328, 82, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 329, 83, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w09c11b7.jpg" },
                    { 330, 83, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 331, 83, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 332, 83, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 333, 84, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w10c11b7.jpg" },
                    { 334, 84, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 335, 84, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 336, 84, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 337, 85, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w11c11b7.jpg" },
                    { 338, 85, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 339, 85, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 340, 85, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 341, 86, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w12c11b7.jpg" },
                    { 342, 86, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 343, 86, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 344, 86, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 345, 87, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w13c11b7.jpg" },
                    { 346, 87, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 347, 87, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 348, 87, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 349, 88, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w14c11b7.jpg" },
                    { 350, 88, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 351, 88, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 352, 88, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 353, 89, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w15c11b7.jpg" },
                    { 354, 89, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 355, 89, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 356, 89, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 357, 90, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w16c11b7.jpg" },
                    { 358, 90, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 359, 90, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 360, 90, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 361, 91, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w17c11b7.jpg" },
                    { 362, 91, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 363, 91, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 364, 91, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 365, 92, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w18c11b7.jpg" },
                    { 366, 92, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 367, 92, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 368, 92, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 369, 93, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w19c11b7.jpg" },
                    { 370, 93, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 371, 93, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 372, 93, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 373, 94, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w20c11b7.jpg" },
                    { 374, 94, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 375, 94, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 376, 94, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 377, 95, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w21c11b7.jpg" },
                    { 378, 95, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 379, 95, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 380, 95, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 381, 96, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w22c11b7.jpg" },
                    { 382, 96, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 383, 96, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 384, 96, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 385, 97, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w23c11b7.jpg" },
                    { 386, 97, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 387, 97, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 388, 97, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" },
                    { 389, 98, "X.jpeg", "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w24c11b7.jpg" },
                    { 390, 98, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 391, 98, "X.jpeg", "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png" },
                    { 392, 98, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookGalleries_BookId",
                table: "BookGalleries",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LanguageId",
                table: "Books",
                column: "LanguageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookGalleries");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
