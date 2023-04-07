using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
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
                values: new object[] { "c3bdd301-35d1-4114-b5e4-78d509b5607c", 0, "aea37ab2-e094-430e-a4f8-cf6f057dd221", null, "edzaryan@gmail.com", true, "Edgar", "Yeghiazaryan", true, null, "EDZARYAN@GMAIL.COM", "EDZARYAN@GMAIL.COM", "AQAAAAIAAYagAAAAEE0bcGEnzC/j5TL0/jEDsnSgV4z/pv1hlrmfmR/VqDXLfADbhYIW1pHX6/njIJ0AVA==", null, false, "9d5807a0-86fe-4a61-85f1-6c739241b150", false, "edzaryan@gmail.com" });

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
                    { 1, "Liam Moore", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1041), "Head First C# is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First C#", 681, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1063) },
                    { 2, "Mason Gonzalez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1068), "The C++ Programming Language is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The C++ Programming Language", 552, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1068) },
                    { 3, "Ava Taylor", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1070), "Beginning Git and GitHub is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Beginning Git and GitHub", 721, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1070) },
                    { 4, "Mariot Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1111), "JavaScript for Web Developers is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "JavaScript for Web Developers", 220, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1112) },
                    { 5, "Mariot Garcia", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1113), "Python (All-In-One) For Dummies is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Python (All-In-One) For Dummies", 723, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1114) },
                    { 6, "Olivia Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1122), "Head First Java is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First Java", 281, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1122) },
                    { 7, "Elijah Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1124), "Scala for the Impatient (Second Edition) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Scala for the Impatient (Second Edition)", 518, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1124) },
                    { 8, "Michael Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1125), "Learn PHP 8 is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Learn PHP 8", 208, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1126) },
                    { 9, "Emma Thompson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1150), "Kotlin In Action is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Kotlin In Action", 111, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1150) },
                    { 10, "Kathy Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1153), "Head First Swift is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Head First Swift", 662, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1153) },
                    { 11, "William Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3bb.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1155), "Emotional Intelligence is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Emotional Intelligence", 151, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1155) },
                    { 12, "Michael Jackson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f555.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1157), "Dark Psychology is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dark Psychology", 547, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1157) },
                    { 13, "Isabella Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f333.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1159), "Emotional Intelligence (Why It Can Matter More Than IQ) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Emotional Intelligence (Why It Can Matter More Than IQ)", 318, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1159) },
                    { 14, "Matt Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-hho4f4f706f3bb.webp", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1179), "The Emotional Intelligence workbook is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Emotional Intelligence workbook", 579, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1179) },
                    { 15, "Mia Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-7bf4f3f706f3fb.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1181), "Emotional Intelligence (for leadership) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Emotional Intelligence (for leadership)", 667, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1181) },
                    { 16, "James Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1183), "Take What You Need is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Take What You Need", 440, new DateTime(2023, 4, 7, 11, 44, 14, 873, DateTimeKind.Local).AddTicks(1183) }
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
                    { 64, 16, "X.jpeg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png" }
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
