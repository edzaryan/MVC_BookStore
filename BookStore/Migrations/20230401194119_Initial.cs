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
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "German" },
                    { 3, "Russian" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookPdfFileUrl", "Category", "CoverImageUrl", "CreatedOn", "Description", "LanguageId", "Title", "TotalPage", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Andrew Stellman", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", null, "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6352), "Head First C# is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Head First C#", 194, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6370) },
                    { 2, "Bjarne Straustrup", "\\files\\books\\bookPdfFiles\\29eac4b2-b4bb-495c-b3c4-f5c01768e81f_11.pdf", null, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6372), "The new C++11 standard allows programmers to express ideas more clearly, simply, and directly, and to write faster, more efficient code. Bjarne Stroustrup, the designer and original implementer of C++, has reorganized, extended, and completely rewritten his definitive reference and tutorial for programmers who want to use C++ most effectively.", 1, "The C++ Programming Language", 1366, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6373) },
                    { 3, "Mariot Tsitoara", "\\files\\books\\bookPdfFiles\\01b97c2c-7062-478e-b0e9-8b117cc10fbe_Beginning_Git_and_GitHub_(2020).pdf", null, "\\files\\books\\coverImages\\fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6375), "Divided into three parts – Version Control, Project Management and Teamwork – this book reveals what waits for you in the real world and how to resolve the problems you may run into. Once past the basics of Git, you'll see how to manage a software project, and finally how to utilize Git and GithHub to work effectively as a team.", 1, "Beginning Git and GitHub", 294, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6375) },
                    { 4, "Matt Frisbie", "\\files\\books\\bookPdfFiles\\7c64fba0-1b7a-46bc-9403-a759bcbf23ea_Beginning_Git_and_GitHub_(2020).pdf", null, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6377), "Professional JavaScript for Web Developers is the essential guide to next-level JavaScript development. At 1,200 pages, this book is the most comprehensive JavaScript reference available anywhere. Written for intermediate-to-advanced programmers, this book jumps right into the technical details to help you clean up your code and become a more sophisticated JavaScript developer. ", 1, "JavaScript for Web Developers", 964, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6377) },
                    { 5, "John C. Shovic", "\\files\\books\\bookPdfFiles\\a8a0c944-d076-436d-8980-e8d228482a47_Python_All-In-One_for_Dummies.pdf", null, "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6379), "This book is a reference manual to guide you through the process of learning\r\nPython and how to use it in modern computer applications, such as data science,\r\nartificial intelligence, physical computing, and robotics. If you’re looking to learn\r\na little about a lot of exciting things, this is the book for you. It gives you an introduction to the topics that you’ll need to explore more deeply.", 1, "Python (All-In-One) For Dummies", 723, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6379) },
                    { 6, "Kathy Sierra", "\\files\\books\\bookPdfFiles\\59b685ea-9a6a-4bf5-be00-35d2e884f6ed_Head_First_Java_Second_Edition.pdf", null, "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6381), "Head First Java is a complete learning experience in Java and object-oriented programming. With this book, you'll learn the Java language with a unique method that goes beyond how-to manuals and helps you become a great programmer. Through puzzles, mysteries, and soul-searching interviews with famous Java objects, you'll quickly get up to speed on Java's fundamentals and advanced topics including lambdas, streams, generics, threading, networking, and the dreaded desktop GUI.", 1, "Head First Java", 722, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6381) },
                    { 7, "Cay S. Horstmann", "\\files\\books\\bookPdfFiles\\6dbbb0b0-59ec-4820-9422-e4df9a3241c8_Scala for the Impatient, 2nd Edition.pdf", null, "\\files\\books\\coverImages\\01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6383), "Interest in the Scala programming language continues to grow for many reasons. Scala embraces the functional programming style without abandoning the object-oriented paradigm, and it allows you to write programs more concisely than in Java. Because Scala runs on the JVM, it can access any Java library and is interoperable with familiar Java frameworks. Scala also makes it easier to leverage the full power of concurrency.", 1, "Scala for the Impatient (Second Edition)", 385, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6383) },
                    { 8, "Steve Prettyman", "\\files\\books\\bookPdfFiles\\1557c693-f85a-4d23-bfeb-d73933b698c8_Learn_PHP_8_2nd_Edition_(2020).pdf", null, "\\files\\books\\coverImages\\87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6385), "Write solid, secure, object-oriented code in the new PHP 8. In this book you will create a complete three-tier application using a natural process of building and testing modules within each tier. This practical approach teaches you about app development and introduces PHP features when they are actually needed rather than providing you with abstract theory and contrived examples.", 1, "Learn PHP 8", 422, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6387) },
                    { 9, "Dmitry Jemerov", "\\files\\books\\bookPdfFiles\\bcd7faf8-e2c0-4f64-895a-c26c00acdd14_Kotlin_in_Action_(2017).pdf", null, "\\files\\books\\coverImages\\a224595a-1dbf-4240-992e-859f6a287cfa_1.jpg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6389), "Kotllyn became interested in Android as an official language. This book is a kind of official book written by developers of Comlin compilers in JetBrain who developed the language. The greatest feature of the Kohlin language is its practicality. This book was also used to emphasize practicality. Introduce Kotllyns fundamentals and explain the contents of higher order functions, object orientation, and generics.", 1, "Kotlin In Action", 363, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6389) },
                    { 10, "Paris Buttfield-Addison", "\\files\\books\\bookPdfFiles\\5c399598-3a58-4efd-b67c-a4f55303ffcf_Paris_Buttfield-Addison_Jon_Manning_-_Head_First_Swift_2022.pdf", null, "\\files\\books\\coverImages\\e021b60d-5c7c-4a59-96d3-32bcf10bccb2_1491922850.01._SCLZZZZZZZ_SX500_.jpg", new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6391), "Swift is best known as Apple's programming language of choice for developing apps on iOS, iPadOS, macOS, watchOS, and tvOS. But it's far more versatile than that. Open source Swift is also gaining ground as a language for systems programming and server-side code, and it runs on Linux and Windows. So where do you start? With Head First Swift, you'll explore from the ground ", 1, "Head First Swift", 722, new DateTime(2023, 4, 1, 23, 41, 19, 204, DateTimeKind.Local).AddTicks(6391) }
                });

            migrationBuilder.InsertData(
                table: "BookGalleries",
                columns: new[] { "Id", "BookId", "Name", "URL" },
                values: new object[,]
                {
                    { 1, 1, "5.jpeg", "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png" },
                    { 2, 1, "2.jpg", "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4edc_2.jpg" },
                    { 3, 1, "3.png", "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png" },
                    { 4, 1, "4.jpeg", "\\files\\books\\galleryImages\\8a053ea6-0e24-4347-a98c-5cc61f432c23_4.jpeg" },
                    { 5, 2, "4.jpeg", "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg" },
                    { 6, 2, "2.jpg", "\\files\\books\\galleryImages\\c04c92d7-e7cc-4a1e-bd1f-14db83cc9520_2.jpg" },
                    { 7, 2, "3.png", "\\files\\books\\galleryImages\\585eb055-1a37-4e0f-9706-47c99c544370_3.jpg" },
                    { 8, 2, "4.jpeg", "\\files\\books\\galleryImages\\535e6d66-6017-415a-8d1d-caf963b59f67_4.jpg" },
                    { 9, 3, "2.jpg", "\\files\\books\\coverImages\\1a059024-fb6e-410d-85db-963ba3f455b4_1.jpg" },
                    { 10, 3, "2.jpg", "\\files\\books\\galleryImages\\aaacf5f4-0b5d-4739-a44d-890065632f28_2.jpg" },
                    { 11, 3, "3.jpeg", "\\files\\books\\galleryImages\\f9015d77-3237-45d5-944b-ac864e9b15b6_3.jpeg" },
                    { 12, 3, "4.jpeg", "\\files\\books\\galleryImages\\6383ad9a-09eb-41dd-9e8a-02fbc7bd5ff9_4.jpeg" },
                    { 13, 4, "2.jpg", "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg" },
                    { 14, 4, "2.jpg", "\\files\\books\\galleryImages\\2a12c3b8-9cf9-4d90-b8b7-720daf74adf8_2.jpg" },
                    { 15, 4, "3.jpeg", "\\files\\books\\galleryImages\\48d42e20-5ef0-43a6-9361-39e4083ffe04_3.jpeg" },
                    { 16, 4, "4.jpeg", "\\files\\books\\galleryImages\\9a2c740e-3bfa-463e-9e31-35294a695aba_4.jpeg" },
                    { 17, 5, "2.jpg", "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg" },
                    { 18, 5, "2.jpg", "\\files\\books\\galleryImages\\aed2fbf7-5c53-41ef-8c65-7c0bb0210cd1_2.jpg" },
                    { 19, 5, "3.jpeg", "\\files\\books\\galleryImages\\b147163d-b9e6-4e5d-bc26-6f347300f547_3.jpeg" },
                    { 20, 5, "4.jpeg", "\\files\\books\\galleryImages\\3287bb6c-d76a-4e39-9baa-59ebdc8665f1_4.jpeg" },
                    { 21, 6, "2.jpg", "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg" },
                    { 22, 6, "2.jpg", "\\files\\books\\galleryImages\\af854ea4-84b7-4217-993b-49ac92492974_2.jpg" },
                    { 23, 6, "3.jpeg", "\\files\\books\\galleryImages\\470046f5-b2bc-4e17-834b-33624f300efd_3.jpeg" },
                    { 24, 6, "4.jpeg", "\\files\\books\\galleryImages\\874c31e5-93d3-4c89-80e9-ac0fa9cdbd1a_4.jpeg" },
                    { 25, 7, "1.jpeg", "\\files\\books\\galleryImages\\f2954d2c-94e0-4b0a-adce-058ed70d5b32_1.jpg" },
                    { 26, 7, "2.jpeg", "\\files\\books\\galleryImages\\a3d7d206-f541-4c90-8fb9-5320d572ef20_2.jpg" },
                    { 27, 7, "3.jpeg", "\\files\\books\\galleryImages\\968128e9-574e-4318-a582-53964dcafcd6_3.jpeg" },
                    { 28, 7, "4.jpeg", "\\files\\books\\galleryImages\\7ec06f14-5f08-419f-9900-ebaf7db8ceb1_4.jpeg" },
                    { 29, 8, "1.jpg", "\\files\\books\\galleryImages\\6004d2f5-8fc5-4fbc-8c63-c82367c9cb31_1.jpg" },
                    { 30, 8, "2.jpg", "\\files\\books\\galleryImages\\3287bb6c-d76a-4e39-9baa-59ebdc8665f1_4.jpeg" },
                    { 31, 8, "3.jpeg", "\\files\\books\\galleryImages\\470046f5-b2bc-4e17-834b-33624f300efd_3.jpeg" },
                    { 32, 8, "4.jpeg", "\\files\\books\\galleryImages\\edbe5e93-1536-48ca-8b44-846fd4b490ab_2.jpg" },
                    { 33, 9, "1.jpg", "\\files\\books\\galleryImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg" },
                    { 34, 9, "2.jpg", "\\files\\books\\galleryImages\\2c7328fe-1974-47af-a82f-ae25cf60e206_4.jpeg" },
                    { 35, 9, "3.jpeg", "\\files\\books\\galleryImages\\af854ea4-84b7-4217-993b-49ac92492974_2.jpg" },
                    { 36, 9, "4.jpeg", "\\files\\books\\galleryImages\\9a1b90d9-6a61-45d9-b015-dff9af9f2051_2.jpg" },
                    { 37, 10, "1.jpg", "\\files\\books\\galleryImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.webp" },
                    { 38, 10, "2.jpg", "\\files\\books\\galleryImages\\8a053ea6-0e24-4347-a98c-5cc61f432c23_4.jpeg" },
                    { 39, 10, "3.jpeg", "\\files\\books\\galleryImages\\535e6d66-6017-415a-8d1d-caf963b59f67_4.jpg" },
                    { 40, 10, "4.jpeg", "\\files\\books\\galleryImages\\23194214-9443-468c-8fbc-ccb417b7a204_3.webp" }
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
