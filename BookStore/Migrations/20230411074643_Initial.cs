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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
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
                    TotalPage = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookPdfFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    LanguageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
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
                values: new object[] { "c3bdd301-35d1-4114-b5e4-78d509b5607c", 0, "d90444a4-3cb7-43b4-8ff7-d3133757cf8c", null, "edzaryan@gmail.com", true, "Edgar", "Yeghiazaryan", true, null, "EDZARYAN@GMAIL.COM", "EDZARYAN@GMAIL.COM", "AQAAAAIAAYagAAAAEItBgxphhz4kY+I9OrkNEg/dYYQpINyOheL1SRrROjTjdMH4LZZF1XZqt3WbS4BOCw==", null, false, "8122c88e-c305-4834-aa02-10b2fb908111", false, "edzaryan@gmail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Programming" },
                    { 2, "Traillers" },
                    { 3, "Kids" },
                    { 4, "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "Russian" },
                    { 3, "German" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookPdfFileUrl", "CategoryId", "CoverImageUrl", "CreatedOn", "Description", "LanguageId", "Title", "TotalPage", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Bridger Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6149), "Head First C# is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First C#", 164, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6166) },
                    { 2, "Bjarne Thompson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6175), "The C++ Programming Language is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The C++ Programming Language", 381, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6175) },
                    { 3, "Kathy Brown", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6178), "Beginning Git and GitHub is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Beginning Git and GitHub", 521, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6178) },
                    { 4, "Noah Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6182), "JavaScript for Web Developers is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "JavaScript for Web Developers", 415, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6182) },
                    { 5, "Zyair Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6185), "Python (All-In-One) For Dummies is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Python (All-In-One) For Dummies", 743, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6185) },
                    { 6, "Ethan Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6251), "Head First Java is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First Java", 394, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6251) },
                    { 7, "Mac Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6255), "Scala for the Impatient (Second Edition) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Scala for the Impatient (Second Edition)", 296, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6255) },
                    { 8, "Kathy Garcia", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6257), "Learn PHP 8 is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Learn PHP 8", 724, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6257) },
                    { 9, "Mia Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6261), "Kotlin In Action is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Kotlin In Action", 173, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6261) },
                    { 10, "Wylder Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6267), "Head First Swift is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Head First Swift", 737, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6267) },
                    { 11, "Olivia Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3bb.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6327), "Emotional Intelligence is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Emotional Intelligence", 589, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6327) },
                    { 12, "Abigail Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f555.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6329), "Dark Psychology is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dark Psychology", 533, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6330) },
                    { 13, "Alexander Cullen", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f333.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6332), "Emotional Intelligence (Why It Can Matter More Than IQ) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Emotional Intelligence (Why It Can Matter More Than IQ)", 353, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6333) },
                    { 14, "Sophia Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-hho4f4f706f3bb.webp", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6336), "The Emotional Intelligence workbook is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Emotional Intelligence workbook", 697, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6336) },
                    { 15, "Eliam Garcia", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-7bf4f3f706f3fb.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6339), "Emotional Intelligence (for leadership) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Emotional Intelligence (for leadership)", 298, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6339) },
                    { 16, "Jiraiya Taylor", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6379), "Take What You Need is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Take What You Need", 573, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6379) },
                    { 17, "Alexander Gonzalez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6381), "A Reason For Marriage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "A Reason For Marriage", 142, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6381) },
                    { 18, "Bjarne Johnson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6387), "Stormy Surrender is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Stormy Surrender", 743, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6387) },
                    { 19, "Camilo Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd088wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6391), "In Graywolf's Hands (The Bachelors Of Blair Memorial) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "In Graywolf's Hands (The Bachelors Of Blair Memorial)", 619, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6391) },
                    { 20, "Elio Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079wwcvbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6393), "Maximum Ride Forever is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Maximum Ride Forever", 390, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6393) },
                    { 21, "Mac Johnson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9ee8-ddd079wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6412), "The Lost Wife is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Lost Wife", 675, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6413) },
                    { 22, "Banks Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6414), "The Forced Bride is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Forced Bride", 764, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6415) },
                    { 23, "Emma Cullen", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6416), "A Lady Betrayed is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "A Lady Betrayed", 721, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6417) },
                    { 24, "Bjarne Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\4ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6419), "Winning the Highlander's Heart is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Winning the Highlander's Heart", 364, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6419) },
                    { 25, "Onyx Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\5ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6426), "Alaska Skies is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Alaska Skies", 385, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6427) },
                    { 26, "John Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\6ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6484), "Hungry for More is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Hungry for More", 735, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6484) },
                    { 27, "Charlotte Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\7ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6486), "Gem of a Girl is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Gem of a Girl", 571, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6487) },
                    { 28, "Ozzy White", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\8ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6488), "Surrender to the Fury is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Surrender to the Fury", 540, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6489) },
                    { 29, "Kylian Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\9ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6490), "Leave Yesterday Behind is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Leave Yesterday Behind", 353, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6491) },
                    { 30, "Matt Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\99fc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6493), "The Lion's Bride is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Lion's Bride", 563, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6494) },
                    { 31, "Bridger Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\77fc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6554), "Villa In The Sun is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Villa In The Sun", 772, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6555) },
                    { 32, "Mac Casey", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6557), "Lover's Touch is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Lover's Touch", 625, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6557) },
                    { 33, "Matt Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1111.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6559), "Never A Lady is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Never A Lady", 535, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6559) },
                    { 34, "Banks Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1112.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6561), "A Reason For Marriage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "A Reason For Marriage", 694, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6562) },
                    { 35, "Amiri Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1113.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6564), "The Siren is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Siren", 599, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6564) },
                    { 36, "Camilo Casey", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1114.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6623), "Twice Her Husband (Silhouette Special Edition) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Twice Her Husband (Silhouette Special Edition)", 789, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6623) },
                    { 37, "William Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1115.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6626), "The Blind - Date Bride (The Australians) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Blind - Date Bride (The Australians)", 462, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6626) },
                    { 38, "Bridger Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1116.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6627), "Only Love is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Only Love", 192, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6628) },
                    { 39, "Koen Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1117.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6629), "Christmas at Lilac Cottage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Christmas at Lilac Cottage", 550, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6630) },
                    { 40, "Emily Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1118.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6631), "Once Upon A Scandal (Once Upon Scandal) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Once Upon A Scandal (Once Upon Scandal)", 397, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6632) },
                    { 41, "Jacob Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1119.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6743), "Wild Jasmine is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Wild Jasmine", 141, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6743) },
                    { 42, "Olivia Wilson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1110.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6745), "Promise Of A Family is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Promise Of A Family", 705, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6746) },
                    { 43, "Zyair Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11d1.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6747), "Happy Christmas Love Mills Boon Helen Bianchin Et Al is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Happy Christmas Love Mills Boon Helen Bianchin Et Al", 523, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6747) },
                    { 44, "Onyx Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1a12.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6749), "Sister to Meryl is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Sister to Meryl", 334, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6749) },
                    { 45, "Michael Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6751), "Stellar Attraction is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Stellar Attraction", 645, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6751) },
                    { 46, "Emily Thompson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6752), "The wife he couldn't forget / Seduced by the CEO is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The wife he couldn't forget / Seduced by the CEO", 622, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6753) },
                    { 47, "Evander Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6772), "Match For Mom is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Match For Mom", 304, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6773) },
                    { 48, "Ethan Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6775), "Lucianna is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Lucianna", 295, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6775) },
                    { 49, "Camilo Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6777), "Hidden mistress, public wife is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Hidden mistress, public wife", 556, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6777) },
                    { 50, "Matt Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-aa01-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6779), "Dance of Death is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Dance of Death", 596, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6779) },
                    { 51, "Camilo White", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa02-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6781), "Bears, bears, bears is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Bears, bears, bears", 442, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6781) },
                    { 52, "Bjarne Garcia", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-aa03-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6801), "Mockingjay is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Mockingjay", 596, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6801) },
                    { 53, "James Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa04-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6803), "Larklight is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Larklight", 517, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6803) },
                    { 54, "Kylian Moore", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa05-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6806), "Flat Stanley on ice is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Flat Stanley on ice", 417, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6806) },
                    { 55, "Mariot Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa06-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6807), "Taran Wanderer (The Chronicles of Prydain) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Taran Wanderer (The Chronicles of Prydain)", 212, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6808) },
                    { 56, "Abigail White", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa07-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6809), "Big Nate is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Big Nate", 265, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6810) },
                    { 57, "Ethan Wilson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa08-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6870), "In a Glass Grimmly is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "In a Glass Grimmly", 215, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6870) },
                    { 58, "Ava Gonzalez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa09-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6872), "Nate the Great Talks Turkey is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Nate the Great Talks Turkey", 651, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6872) },
                    { 59, "Ethan Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa10-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6874), "Thea Stilton And The Great Tulip Heist is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Thea Stilton And The Great Tulip Heist", 316, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6874) },
                    { 60, "Kylian Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa11-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6876), "Harry Potter and the Philosopher's Stone is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Harry Potter and the Philosopher's Stone", 288, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6876) },
                    { 61, "Abigail Casey", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa12-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6879), "The Book Thief is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Book Thief", 638, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6879) },
                    { 62, "Mason Clark", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa13-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6936), "Cue for Treason is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Cue for Treason", 139, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6936) },
                    { 63, "Emma Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b614-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6938), "The House of Hades is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The House of Hades", 267, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6938) },
                    { 64, "Onyx Lopez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b615-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6940), "Dangerous pumpkins is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dangerous pumpkins", 695, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6940) },
                    { 65, "Isabella Thompson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b616-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6942), "Danger at the Landings is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Danger at the Landings", 434, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6942) },
                    { 66, "Madison Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b617-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6947), "Battle of the Bots is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Battle of the Bots", 676, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(6947) },
                    { 67, "Kylian Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b618-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7005), "Prise d'otages à Disneyland is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Prise d'otages à Disneyland", 321, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7005) },
                    { 68, "Eliam Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b619-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7008), "Games Magazine Presents the Kids' Giant Book of Games is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Games Magazine Presents the Kids' Giant Book of Games", 688, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7008) },
                    { 69, "Elijah Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b620-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7010), "Lucy and the Wolf in Sheep's Clothing (A Young Lion Storybook) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Lucy and the Wolf in Sheep's Clothing (A Young Lion Storybook)", 570, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7010) },
                    { 70, "Eliam Thompson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b621-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7012), "Atlantis quest is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Atlantis quest", 589, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7012) },
                    { 71, "Ozzy Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b622-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7014), "The Way (Darby Creek Exceptional Titles) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Way (Darby Creek Exceptional Titles)", 272, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7014) },
                    { 72, "Mia Wilson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b623-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7073), "The voice and the pendant is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The voice and the pendant", 357, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7073) },
                    { 73, "Mia Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b624-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7075), "Hattie Marshall and the dangerous fire is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Hattie Marshall and the dangerous fire", 501, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7075) },
                    { 74, "Alexander Cullen", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7077), "Henry and the hand-me-downs is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Henry and the hand-me-downs", 170, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7077) },
                    { 75, "Charlotte Garcia", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w01c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7079), "The eyes of darkness is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The eyes of darkness", 109, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7080) },
                    { 76, "Loyal Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w02c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7081), "IT is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "IT", 444, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7082) },
                    { 77, "Abigail Davis", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w03c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7169), "The Shining is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Shining", 359, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7170) },
                    { 78, "Emma Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w04c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7171), "Cell is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Cell", 280, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7172) },
                    { 79, "Liam Davis", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w05c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7174), "RED STORM RISING is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "RED STORM RISING", 521, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7174) },
                    { 80, "Onyx Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w06c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7175), "Insomnia is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Insomnia", 661, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7176) },
                    { 81, "Jiraiya Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w07c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7177), "Pet Sematary is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Pet Sematary", 456, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7178) },
                    { 82, "Wylder Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w08c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7217), "Black wind is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Black wind", 720, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7218) },
                    { 83, "Michael Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w09c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7220), "The Bachman Books is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Bachman Books", 614, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7220) },
                    { 84, "Amiri White", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w10c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7222), "Just After Sunset is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Just After Sunset", 449, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7222) },
                    { 85, "Gian Sanchez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w11c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7224), "Carrie is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Carrie", 367, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7224) },
                    { 86, "Eliam Williams", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w12c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7226), "Under the Dome is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Under the Dome", 255, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7226) },
                    { 87, "Zyair Davis", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w13c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7287), "The bear and the dragon is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The bear and the dragon", 630, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7287) },
                    { 88, "Onyx Brown", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w14c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7288), "Dark Justice is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dark Justice", 642, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7289) },
                    { 89, "Liam Thompson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w15c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7290), "The good guy is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The good guy", 121, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7291) },
                    { 90, "Colter Moore", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w16c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7292), "Executive Orders is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Executive Orders", 764, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7293) },
                    { 91, "Eliam Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w17c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7294), "Treasure is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Treasure", 424, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7294) },
                    { 92, "Olivia Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w18c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7314), "The Green Mile is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Green Mile", 434, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7314) },
                    { 93, "Jiraiya White", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w19c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7316), "Different Seasons is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Different Seasons", 217, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7316) },
                    { 94, "Noah Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w20c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7318), "Debt of Honor is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Debt of Honor", 601, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7318) },
                    { 95, "Sophia Smith", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w21c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7320), "Atlantis Found is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Atlantis Found", 218, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7320) },
                    { 96, "Kylian Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w22c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7322), "Wolves of the Calla is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Wolves of the Calla", 292, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7322) },
                    { 97, "Elijah Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w23c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7324), "Red rabbit is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Red rabbit", 439, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7324) },
                    { 98, "Emma Taylor", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w24c11b7.jpg", new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7392), "The Dark Tower is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Dark Tower", 338, new DateTime(2023, 4, 11, 11, 46, 43, 190, DateTimeKind.Local).AddTicks(7392) }
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
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

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
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
