using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookGallery> BookGalleries { get; set; }

        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Book>()
                .HasData(new Book[]
                {
                    new()
                    {
                        Id = 1,
                        Title = "Head First C#",
                        Author = "Andrew Stellman",
                        Description = "Head First C# is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!",
                        TotalPage = 194,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf"
                    },
                    new()
                    {
                        Id = 2,
                        Title = "The C++ Programming Language",
                        Author = "Bjarne Straustrup",
                        Description = "The new C++11 standard allows programmers to express ideas more clearly, simply, and directly, and to write faster, more efficient code. Bjarne Stroustrup, the designer and original implementer of C++, has reorganized, extended, and completely rewritten his definitive reference and tutorial for programmers who want to use C++ most effectively.",
                        TotalPage = 1366,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\29eac4b2-b4bb-495c-b3c4-f5c01768e81f_11.pdf"
                    },
                    new()
                    {
                        Id = 3,
                        Title = "Beginning Git and GitHub",
                        Author = "Mariot Tsitoara",
                        Description = "Divided into three parts – Version Control, Project Management and Teamwork – this book reveals what waits for you in the real world and how to resolve the problems you may run into. Once past the basics of Git, you'll see how to manage a software project, and finally how to utilize Git and GithHub to work effectively as a team.",
                        TotalPage = 294,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\01b97c2c-7062-478e-b0e9-8b117cc10fbe_Beginning_Git_and_GitHub_(2020).pdf"
                    },
                    new()
                    {
                        Id = 4,
                        Title = "JavaScript for Web Developers",
                        Author = "Matt Frisbie",
                        Description = "Professional JavaScript for Web Developers is the essential guide to next-level JavaScript development. At 1,200 pages, this book is the most comprehensive JavaScript reference available anywhere. Written for intermediate-to-advanced programmers, this book jumps right into the technical details to help you clean up your code and become a more sophisticated JavaScript developer. ",
                        TotalPage = 964,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\7c64fba0-1b7a-46bc-9403-a759bcbf23ea_Beginning_Git_and_GitHub_(2020).pdf"
                    },
                    new()
                    {
                        Id = 5,
                        Title = "Python (All-In-One) For Dummies",
                        Author = "John C. Shovic",
                        Description = "This book is a reference manual to guide you through the process of learning\r\nPython and how to use it in modern computer applications, such as data science,\r\nartificial intelligence, physical computing, and robotics. If you’re looking to learn\r\na little about a lot of exciting things, this is the book for you. It gives you an introduction to the topics that you’ll need to explore more deeply.",
                        TotalPage = 723,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\a8a0c944-d076-436d-8980-e8d228482a47_Python_All-In-One_for_Dummies.pdf"
                    },
                    new()
                    {
                        Id = 6,
                        Title = "Head First Java",
                        Author = "Kathy Sierra",
                        Description = "Head First Java is a complete learning experience in Java and object-oriented programming. With this book, you'll learn the Java language with a unique method that goes beyond how-to manuals and helps you become a great programmer. Through puzzles, mysteries, and soul-searching interviews with famous Java objects, you'll quickly get up to speed on Java's fundamentals and advanced topics including lambdas, streams, generics, threading, networking, and the dreaded desktop GUI.",
                        TotalPage = 722,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\59b685ea-9a6a-4bf5-be00-35d2e884f6ed_Head_First_Java_Second_Edition.pdf"
                    },
                    new()
                    {
                        Id = 7,
                        Title = "Scala for the Impatient (Second Edition)",
                        Author = "Cay S. Horstmann",
                        Description = "Interest in the Scala programming language continues to grow for many reasons. Scala embraces the functional programming style without abandoning the object-oriented paradigm, and it allows you to write programs more concisely than in Java. Because Scala runs on the JVM, it can access any Java library and is interoperable with familiar Java frameworks. Scala also makes it easier to leverage the full power of concurrency.",
                        TotalPage = 385,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\6dbbb0b0-59ec-4820-9422-e4df9a3241c8_Scala for the Impatient, 2nd Edition.pdf"
                    },
                    new()
                    {
                        Id = 8,
                        Title = "Learn PHP 8",
                        Author = "Steve Prettyman",
                        Description = "Write solid, secure, object-oriented code in the new PHP 8. In this book you will create a complete three-tier application using a natural process of building and testing modules within each tier. This practical approach teaches you about app development and introduces PHP features when they are actually needed rather than providing you with abstract theory and contrived examples.",
                        TotalPage = 422,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\1557c693-f85a-4d23-bfeb-d73933b698c8_Learn_PHP_8_2nd_Edition_(2020).pdf"
                    },
                    new()
                    {
                        Id = 9,
                        Title = "Kotlin In Action",
                        Author = "Dmitry Jemerov",
                        Description = "Kotllyn became interested in Android as an official language. This book is a kind of official book written by developers of Comlin compilers in JetBrain who developed the language. The greatest feature of the Kohlin language is its practicality. This book was also used to emphasize practicality. Introduce Kotllyns fundamentals and explain the contents of higher order functions, object orientation, and generics.",
                        TotalPage = 363,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\a224595a-1dbf-4240-992e-859f6a287cfa_1.jpg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\bcd7faf8-e2c0-4f64-895a-c26c00acdd14_Kotlin_in_Action_(2017).pdf"
                    },
                    new()
                    {
                        Id = 10,
                        Title = "Head First Swift",
                        Author = "Paris Buttfield-Addison",
                        Description = "Swift is best known as Apple's programming language of choice for developing apps on iOS, iPadOS, macOS, watchOS, and tvOS. But it's far more versatile than that. Open source Swift is also gaining ground as a language for systems programming and server-side code, and it runs on Linux and Windows. So where do you start? With Head First Swift, you'll explore from the ground ",
                        TotalPage = 722,
                        LanguageId = 1,
                        CoverImageUrl = "\\files\\books\\coverImages\\e021b60d-5c7c-4a59-96d3-32bcf10bccb2_1491922850.01._SCLZZZZZZZ_SX500_.jpg",
                        CreatedOn = DateTime.Now,
                        UpdatedOn = DateTime.Now,
                        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\5c399598-3a58-4efd-b67c-a4f55303ffcf_Paris_Buttfield-Addison_Jon_Manning_-_Head_First_Swift_2022.pdf"
                    },
                });

            modelBuilder
                .Entity<BookGallery>()
                .HasData(new BookGallery[]
                {
                    // C#
                    new()
                    {
                        Id = 1,
                        Name = "5.jpeg",
                        URL = "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png",
                        BookId = 1,
                    },
                    new()
                    {
                        Id = 2,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4edc_2.jpg",
                        BookId = 1,
                    },
                    new()
                    {
                        Id = 3,
                        Name = "3.png",
                        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
                        BookId = 1,
                    },
                    new()
                    {
                        Id = 4,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\8a053ea6-0e24-4347-a98c-5cc61f432c23_4.jpeg",
                        BookId = 1,
                    },

                    // C++
                    new()
                    {
                        Id = 5,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg",
                        BookId = 2,
                    },
                    new()
                    {
                        Id = 6,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\c04c92d7-e7cc-4a1e-bd1f-14db83cc9520_2.jpg",
                        BookId = 2,
                    },
                    new()
                    {
                        Id = 7,
                        Name = "3.png",
                        URL = "\\files\\books\\galleryImages\\585eb055-1a37-4e0f-9706-47c99c544370_3.jpg",
                        BookId = 2,
                    },
                    new()
                    {
                        Id = 8,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\535e6d66-6017-415a-8d1d-caf963b59f67_4.jpg",
                        BookId = 2,
                    },

                    // Git
                    new()
                    {
                        Id = 9,
                        Name = "2.jpg",
                        URL = "\\files\\books\\coverImages\\1a059024-fb6e-410d-85db-963ba3f455b4_1.jpg",
                        BookId = 3,
                    },
                    new()
                    {
                        Id = 10,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\aaacf5f4-0b5d-4739-a44d-890065632f28_2.jpg",
                        BookId = 3,
                    },
                    new()
                    {
                        Id = 11,
                        Name = "3.jpeg",
                        URL = "\\files\\books\\galleryImages\\f9015d77-3237-45d5-944b-ac864e9b15b6_3.jpeg",
                        BookId = 3,
                    },
                    new()
                    {
                        Id = 12,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\6383ad9a-09eb-41dd-9e8a-02fbc7bd5ff9_4.jpeg",
                        BookId = 3,
                    },

                    // Javascript
                    new()
                    {
                        Id = 13,
                        Name = "2.jpg",
                        URL = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg",
                        BookId = 4,
                    },
                    new()
                    {
                        Id = 14,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\2a12c3b8-9cf9-4d90-b8b7-720daf74adf8_2.jpg",
                        BookId = 4,
                    },
                    new()
                    {
                        Id = 15,
                        Name = "3.jpeg",
                        URL = "\\files\\books\\galleryImages\\48d42e20-5ef0-43a6-9361-39e4083ffe04_3.jpeg",
                        BookId = 4,
                    },
                    new()
                    {
                        Id = 16,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\9a2c740e-3bfa-463e-9e31-35294a695aba_4.jpeg",
                        BookId = 4,
                    },

                    // Python
                    new()
                    {
                        Id = 17,
                        Name = "2.jpg",
                        URL = "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg",
                        BookId = 5,
                    },
                    new()
                    {
                        Id = 18,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\aed2fbf7-5c53-41ef-8c65-7c0bb0210cd1_2.jpg",
                        BookId = 5,
                    },
                    new()
                    {
                        Id = 19,
                        Name = "3.jpeg",
                        URL = "\\files\\books\\galleryImages\\b147163d-b9e6-4e5d-bc26-6f347300f547_3.jpeg",
                        BookId = 5,
                    },
                    new()
                    {
                        Id = 20,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\3287bb6c-d76a-4e39-9baa-59ebdc8665f1_4.jpeg",
                        BookId = 5,
                    },

                    // Java
                    new()
                    {
                        Id = 21,
                        Name = "2.jpg",
                        URL = "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg",
                        BookId = 6,
                    },
                    new()
                    {
                        Id = 22,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\af854ea4-84b7-4217-993b-49ac92492974_2.jpg",
                        BookId = 6,
                    },
                    new()
                    {
                        Id = 23,
                        Name = "3.jpeg",
                        URL = "\\files\\books\\galleryImages\\470046f5-b2bc-4e17-834b-33624f300efd_3.jpeg",
                        BookId = 6,
                    },
                    new()
                    {
                        Id = 24,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\874c31e5-93d3-4c89-80e9-ac0fa9cdbd1a_4.jpeg",
                        BookId = 6,
                    },

                    // Scala
                    new()
                    {
                        Id = 25,
                        Name = "1.jpeg",
                        URL = "\\files\\books\\galleryImages\\f2954d2c-94e0-4b0a-adce-058ed70d5b32_1.jpg",
                        BookId = 7,
                    },
                    new()
                    {
                        Id = 26,
                        Name = "2.jpeg",
                        URL = "\\files\\books\\galleryImages\\a3d7d206-f541-4c90-8fb9-5320d572ef20_2.jpg",
                        BookId = 7,
                    },
                    new()
                    {
                        Id = 27,
                        Name = "3.jpeg",
                        URL = "\\files\\books\\galleryImages\\968128e9-574e-4318-a582-53964dcafcd6_3.jpeg",
                        BookId = 7,
                    },
                    new()
                    {
                        Id = 28,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\7ec06f14-5f08-419f-9900-ebaf7db8ceb1_4.jpeg",
                        BookId = 7,
                    },

                    // PHP
                    new()
                    {
                        Id = 29,
                        Name = "1.jpg",
                        URL = "\\files\\books\\galleryImages\\6004d2f5-8fc5-4fbc-8c63-c82367c9cb31_1.jpg",
                        BookId = 8,
                    },
                    new()
                    {
                        Id = 30,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\3287bb6c-d76a-4e39-9baa-59ebdc8665f1_4.jpeg",
                        BookId = 8,
                    },
                    new()
                    {
                        Id = 31,
                        Name = "3.jpeg",
                        URL = "\\files\\books\\galleryImages\\470046f5-b2bc-4e17-834b-33624f300efd_3.jpeg",
                        BookId = 8,
                    },
                    new()
                    {
                        Id = 32,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\edbe5e93-1536-48ca-8b44-846fd4b490ab_2.jpg",
                        BookId = 8,
                    },

                    // Kotlin
                    new()
                    {
                        Id = 33,
                        Name = "1.jpg",
                        URL = "\\files\\books\\galleryImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg",
                        BookId = 9,
                    },
                    new()
                    {
                        Id = 34,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\2c7328fe-1974-47af-a82f-ae25cf60e206_4.jpeg",
                        BookId = 9,
                    },
                    new()
                    {
                        Id = 35,
                        Name = "3.jpeg",
                        URL = "\\files\\books\\galleryImages\\af854ea4-84b7-4217-993b-49ac92492974_2.jpg",
                        BookId = 9,
                    },
                    new()
                    {
                        Id = 36,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\9a1b90d9-6a61-45d9-b015-dff9af9f2051_2.jpg",
                        BookId = 9,
                    },

                    // Swift
                    new()
                    {
                        Id = 37,
                        Name = "1.jpg",
                        URL = "\\files\\books\\galleryImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.webp",
                        BookId = 10,
                    },
                    new()
                    {
                        Id = 38,
                        Name = "2.jpg",
                        URL = "\\files\\books\\galleryImages\\8a053ea6-0e24-4347-a98c-5cc61f432c23_4.jpeg",
                        BookId = 10,
                    },
                    new()
                    {
                        Id = 39,
                        Name = "3.jpeg",
                        URL = "\\files\\books\\galleryImages\\535e6d66-6017-415a-8d1d-caf963b59f67_4.jpg",
                        BookId = 10,
                    },
                    new()
                    {
                        Id = 40,
                        Name = "4.jpeg",
                        URL = "\\files\\books\\galleryImages\\23194214-9443-468c-8fbc-ccb417b7a204_3.webp",
                        BookId = 10,
                    },
                });

            modelBuilder
                .Entity<Language>()
                .HasData(new Language[]
                {
                    new()
                    {
                        Id = 1,
                        Name = "English"
                    },
                    new()
                    {
                        Id = 2,
                        Name = "German"
                    },
                    new()
                    {
                        Id = 3,
                        Name = "Russian"
                    },
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
