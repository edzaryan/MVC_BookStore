using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8156a559-8119-4898-bb4e-2f5df856f9e7", "AQAAAAIAAYagAAAAEGz36lpIE0bjfsZjUE0PHbdcTkHPmKvJrQZ0yuknPkjhvYmdcXe0R9B2yoOI754c7g==", "14c92f6d-92e1-4549-bdca-ade73e4446aa" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "BookPdfFileUrl", "CategoryId", "CoverImageUrl", "CreatedOn", "Description", "LanguageId", "Title", "TotalPage", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Khai Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(1963), "Head First C# is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First C#", 273, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(1980) },
                    { 2, "William Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(1986), "The C++ Programming Language is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The C++ Programming Language", 764, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(1986) },
                    { 3, "Alexander Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2039), "Beginning Git and GitHub is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Beginning Git and GitHub", 422, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2040) },
                    { 4, "Ozzy Jackson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2043), "JavaScript for Web Developers is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "JavaScript for Web Developers", 694, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2043) },
                    { 5, "Olivia White", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2046), "Python (All-In-One) For Dummies is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Python (All-In-One) For Dummies", 498, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2046) },
                    { 6, "Alexander Garcia", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2065), "Head First Java is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Head First Java", 245, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2065) },
                    { 7, "Emma Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2067), "Scala for the Impatient (Second Edition) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Scala for the Impatient (Second Edition)", 789, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2067) },
                    { 8, "Michael Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2091), "Learn PHP 8 is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Learn PHP 8", 135, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2091) },
                    { 9, "Eliam Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2094), "Kotlin In Action is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Kotlin In Action", 250, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2094) },
                    { 10, "Sophia Lopez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2098), "Head First Swift is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Head First Swift", 529, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2098) },
                    { 11, "Koen Johnson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3bb.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2101), "Emotional Intelligence is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Emotional Intelligence", 150, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2101) },
                    { 12, "Gian Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f555.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2104), "Dark Psychology is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dark Psychology", 409, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2104) },
                    { 13, "Sophia Thompson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f333.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2127), "Emotional Intelligence (Why It Can Matter More Than IQ) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Emotional Intelligence (Why It Can Matter More Than IQ)", 528, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2128) },
                    { 14, "Mason Cullen", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-hho4f4f706f3bb.webp", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2129), "The Emotional Intelligence workbook is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Emotional Intelligence workbook", 223, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2130) },
                    { 15, "Wylder Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-7bf4f3f706f3fb.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2132), "Emotional Intelligence (for leadership) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Emotional Intelligence (for leadership)", 294, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2132) },
                    { 16, "Bridger Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbb_1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2135), "Take What You Need is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Take What You Need", 624, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2135) },
                    { 17, "Ozzy Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2138), "A Reason For Marriage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "A Reason For Marriage", 575, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2138) },
                    { 18, "Amiri Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2164), "Stormy Surrender is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Stormy Surrender", 742, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2165) },
                    { 19, "Charlotte Brooks", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd088wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2166), "In Graywolf's Hands (The Bachelors Of Blair Memorial) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "In Graywolf's Hands (The Bachelors Of Blair Memorial)", 333, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2167) },
                    { 20, "Camilo Brown", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079wwcvbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2169), "Maximum Ride Forever is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Maximum Ride Forever", 212, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2170) },
                    { 21, "Amiri Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9ee8-ddd079wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2171), "The Lost Wife is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Lost Wife", 117, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2172) },
                    { 22, "Matt Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2174), "The Forced Bride is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Forced Bride", 709, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2174) },
                    { 23, "Noah Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2197), "A Lady Betrayed is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "A Lady Betrayed", 764, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2198) },
                    { 24, "John Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\4ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2200), "Winning the Highlander's Heart is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Winning the Highlander's Heart", 114, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2200) },
                    { 25, "Andrew Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\5ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2202), "Alaska Skies is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Alaska Skies", 387, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2202) },
                    { 26, "Alexander Sanchez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\6ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2204), "Hungry for More is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Hungry for More", 177, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2204) },
                    { 27, "Emily Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\7ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2206), "Gem of a Girl is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Gem of a Girl", 375, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2206) },
                    { 28, "Banks Perez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\8ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2230), "Surrender to the Fury is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Surrender to the Fury", 734, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2230) },
                    { 29, "Loyal Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\9ffc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2232), "Leave Yesterday Behind is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Leave Yesterday Behind", 217, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2232) },
                    { 30, "Camilo Garcia", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\99fc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2234), "The Lion's Bride is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Lion's Bride", 786, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2234) },
                    { 31, "Mariot Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\77fc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2235), "Villa In The Sun is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Villa In The Sun", 321, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2236) },
                    { 32, "Amiri Jackson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwcbbdd.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2237), "Lover's Touch is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Lover's Touch", 330, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2237) },
                    { 33, "Olivia Wilson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1111.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2239), "Never A Lady is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Never A Lady", 655, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2239) },
                    { 34, "Ava Gonzalez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1112.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2267), "A Reason For Marriage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "A Reason For Marriage", 613, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2267) },
                    { 35, "Gian Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1113.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2269), "The Siren is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Siren", 135, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2269) },
                    { 36, "Loyal Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1114.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2271), "Twice Her Husband (Silhouette Special Edition) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Twice Her Husband (Silhouette Special Edition)", 767, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2271) },
                    { 37, "Alexander Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1115.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2273), "The Blind - Date Bride (The Australians) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Blind - Date Bride (The Australians)", 687, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2273) },
                    { 38, "Sophia Johnson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1116.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2296), "Only Love is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Only Love", 387, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2296) },
                    { 39, "Zyair Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1117.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2298), "Christmas at Lilac Cottage is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Christmas at Lilac Cottage", 797, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2298) },
                    { 40, "Olivia Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1118.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2300), "Once Upon A Scandal (Once Upon Scandal) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Once Upon A Scandal (Once Upon Scandal)", 301, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2300) },
                    { 41, "Camilo Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1119.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2301), "Wild Jasmine is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Wild Jasmine", 730, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2302) },
                    { 42, "William Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1110.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2304), "Promise Of A Family is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Promise Of A Family", 416, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2304) },
                    { 43, "Colter Lee", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11d1.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2306), "Happy Christmas Love Mills Boon Helen Bianchin Et Al is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Happy Christmas Love Mills Boon Helen Bianchin Et Al", 579, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2306) },
                    { 44, "Colter Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc1a12.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2341), "Sister to Meryl is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Sister to Meryl", 487, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2341) },
                    { 45, "Emily Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2343), "Stellar Attraction is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Stellar Attraction", 639, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2343) },
                    { 46, "John Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2345), "The wife he couldn't forget / Seduced by the CEO is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The wife he couldn't forget / Seduced by the CEO", 499, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2345) },
                    { 47, "James Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2347), "Match For Mom is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Match For Mom", 783, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2348) },
                    { 48, "Koen Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2349), "Lucianna is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Lucianna", 540, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2350) },
                    { 49, "James Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b6cb-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2373), "Hidden mistress, public wife is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Hidden mistress, public wife", 533, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2373) },
                    { 50, "Olivia Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa01-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2375), "Dance of Death is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dance of Death", 542, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2375) },
                    { 51, "Liam Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa02-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2377), "Bears, bears, bears is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Bears, bears, bears", 335, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2377) },
                    { 52, "Kathy Brown", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa03-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2379), "Mockingjay is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Mockingjay", 728, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2379) },
                    { 53, "Mariot Casey", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-aa04-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2381), "Larklight is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Larklight", 235, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2381) },
                    { 54, "Gian Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa05-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2404), "Flat Stanley on ice is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Flat Stanley on ice", 100, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2405) },
                    { 55, "Kylian Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa06-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2407), "Taran Wanderer (The Chronicles of Prydain) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Taran Wanderer (The Chronicles of Prydain)", 545, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2407) },
                    { 56, "Mariot Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa07-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2408), "Big Nate is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Big Nate", 363, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2409) },
                    { 57, "Eliam Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa08-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2410), "In a Glass Grimmly is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "In a Glass Grimmly", 342, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2411) },
                    { 58, "Camilo Hernandez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-aa09-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2413), "Nate the Great Talks Turkey is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Nate the Great Talks Turkey", 213, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2413) },
                    { 59, "Noah Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-aa10-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2437), "Thea Stilton And The Great Tulip Heist is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Thea Stilton And The Great Tulip Heist", 213, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2438) },
                    { 60, "Olivia Perez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-aa11-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2440), "Harry Potter and the Philosopher's Stone is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Harry Potter and the Philosopher's Stone", 635, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2440) },
                    { 61, "Ava Cruz", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-aa12-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2442), "The Book Thief is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Book Thief", 117, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2443) },
                    { 62, "Michael Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-aa13-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2444), "Cue for Treason is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Cue for Treason", 583, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2444) },
                    { 63, "Koen Lopez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b614-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2446), "The House of Hades is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The House of Hades", 230, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2446) },
                    { 64, "Sophia Duff", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b615-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2470), "Dangerous pumpkins is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dangerous pumpkins", 766, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2470) },
                    { 65, "Bjarne Wilson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b616-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2473), "Danger at the Landings is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Danger at the Landings", 290, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2474) },
                    { 66, "Ozzy Clark", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b617-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2478), "Battle of the Bots is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Battle of the Bots", 455, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2479) },
                    { 67, "Charlotte Miller", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b618-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2480), "Prise d'otages à Disneyland is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Prise d'otages à Disneyland", 317, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2481) },
                    { 68, "Isabella Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b619-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2482), "Games Magazine Presents the Kids' Giant Book of Games is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Games Magazine Presents the Kids' Giant Book of Games", 288, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2483) },
                    { 69, "Gian Davis", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b620-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2506), "Lucy and the Wolf in Sheep's Clothing (A Young Lion Storybook) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Lucy and the Wolf in Sheep's Clothing (A Young Lion Storybook)", 155, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2506) },
                    { 70, "Noah Martin", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b621-4cbe-9ee8-ddd111wwwc11b3.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2508), "Atlantis quest is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Atlantis quest", 205, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2508) },
                    { 71, "Noah Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b622-4cbe-9ee8-ddd111wwwc11b4.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2510), "The Way (Darby Creek Exceptional Titles) is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Way (Darby Creek Exceptional Titles)", 673, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2510) },
                    { 72, "Bridger Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b623-4cbe-9ee8-ddd111wwwc11b5.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2512), "The voice and the pendant is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The voice and the pendant", 712, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2512) },
                    { 73, "Mia Jackson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b624-4cbe-9ee8-ddd111wwwc11b6.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2514), "Hattie Marshall and the dangerous fire is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Hattie Marshall and the dangerous fire", 192, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2514) },
                    { 74, "Andrew Clark", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111wwwc11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2538), "Henry and the hand-me-downs is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Henry and the hand-me-downs", 204, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2538) },
                    { 75, "Jacob Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w01c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2540), "The eyes of darkness is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The eyes of darkness", 675, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2540) },
                    { 76, "Emily Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w02c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2542), "IT is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "IT", 422, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2542) },
                    { 77, "Elio Duff", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w03c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2544), "The Shining is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Shining", 130, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2544) },
                    { 78, "Mac Jones", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w04c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2546), "Cell is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Cell", 331, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2546) },
                    { 79, "Amiri Johnson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w05c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2569), "RED STORM RISING is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "RED STORM RISING", 712, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2569) },
                    { 80, "Koen Johnson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w06c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2571), "Insomnia is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Insomnia", 231, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2572) },
                    { 81, "Amiri Martinez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w07c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2573), "Pet Sematary is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Pet Sematary", 219, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2574) },
                    { 82, "Evander Clark", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w08c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2575), "Black wind is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Black wind", 112, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2576) },
                    { 83, "Andrew Perez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w09c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2577), "The Bachman Books is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The Bachman Books", 474, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2577) },
                    { 84, "Khai Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w10c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2579), "Just After Sunset is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Just After Sunset", 323, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2579) },
                    { 85, "Onyx Harris", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w11c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2607), "Carrie is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Carrie", 199, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2608) },
                    { 86, "Camilo Gonzalez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w12c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2609), "Under the Dome is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Under the Dome", 350, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2610) },
                    { 87, "Ozzy Ford", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w13c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2611), "The bear and the dragon is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The bear and the dragon", 716, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2611) },
                    { 88, "Noah Brando", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w14c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2613), "Dark Justice is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Dark Justice", 367, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2613) },
                    { 89, "John Anderson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w15c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2615), "The good guy is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "The good guy", 283, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2615) },
                    { 90, "Khai Perez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w16c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2640), "Executive Orders is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Executive Orders", 149, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2641) },
                    { 91, "Sophia Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w17c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2642), "Treasure is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Treasure", 775, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2642) },
                    { 92, "Banks Carson", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w18c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2644), "The Green Mile is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Green Mile", 666, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2644) },
                    { 93, "Sophia Thomas", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w19c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2646), "Different Seasons is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Different Seasons", 402, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2646) },
                    { 94, "Gian Rodriguez", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w20c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2648), "Debt of Honor is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Debt of Honor", 406, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2649) },
                    { 95, "Emily Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w21c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2672), "Atlantis Found is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Atlantis Found", 770, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2673) },
                    { 96, "William Denton", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 3, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w22c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2674), "Wolves of the Calla is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "Wolves of the Calla", 782, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2674) },
                    { 97, "Alexander Duff", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 2, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w23c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2676), "Red rabbit is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 2, "Red rabbit", 112, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2677) },
                    { 98, "Camilo Brady", "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf", 1, "\\files\\books\\coverImages\\fgfc0832-b625-4cbe-9ee8-ddd111w24c11b7.jpg", new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2678), "The Dark Tower is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!", 1, "The Dark Tower", 630, new DateTime(2023, 4, 9, 20, 14, 8, 301, DateTimeKind.Local).AddTicks(2679) }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "BookGalleries",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3bdd301-35d1-4114-b5e4-78d509b5607c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9647819-fcca-435b-a82a-79ced94218e7", "AQAAAAIAAYagAAAAEGZs3xTXJEpQBrpeXPwwrxLS+iQV5Ha+aTIr2zgLaE/L3Cbgf+viQfP1H53QClaUaQ==", "02846ca8-42e2-4362-87db-18b464f95d31" });
        }
    }
}
