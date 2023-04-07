using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        private List<Book> GetBooks()
        {
            string[] bookTitle = {
                "Head First C#",
                "The C++ Programming Language",
                "Beginning Git and GitHub",
                "JavaScript for Web Developers",
                "Python (All-In-One) For Dummies",
                "Head First Java",
                "Scala for the Impatient (Second Edition)",
                "Learn PHP 8",
                "Kotlin In Action",
                "Head First Swift",
                "Emotional Intelligence",
                "Dark Psychology",
                "Emotional Intelligence (Why It Can Matter More Than IQ)",
                "The Emotional Intelligence workbook",
                "Emotional Intelligence (for leadership)",
                "Take What You Need"
            };

            string[] names = {
                "Andrew", "Bjarne", "Mariot", "Matt", "John", "Kathy", "Noah", "Liam", "Jacob", "Mason", "William", "Ethan",
                "Michael", "Alexander", "James", "Elijah", "Emma", "Sophia", "Olivia", "Isabella", "Ava", "Mia", "Abigail",
                "Emily", "Madison", "Charlotte"
            };

            string[] surnames = {
                "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez",
                "Lopez", "Gonzalez", "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson",
                "White", "Harris", "Sanchez"
            };

            string[] coverImageName =
            {
                "83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png",
                "acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg",
                "fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg",
                "1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg",
                "359ee713-f716-488c-866d-d05c57bafc1b_1.jpg",
                "04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg",
                "01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg",
                "87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg",
                "a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg",
                "648c38b8-0ed4-4674-a9e5-c5d623063e95_1.jpg",
                "1e15c7af-09d5-4484-9cf7-bbf4f4f706f3bb.jpg",
                "1e15c7af-09d5-4484-9cf7-bbf4f4f706f555.jpg",
                "1e15c7af-09d5-4484-9cf7-bbf4f4f706f333.jpg",
                "1e15c7af-09d5-4484-9cf7-hho4f4f706f3bb.webp",
                "1e15c7af-09d5-4484-9cf7-7bf4f3f706f3fb.jpg",
                "acbc0832-b6cb-4cbe-9gc8-ddd079389cbb_1.jpg"
            };

            List<Book> bookList = new();

            Random random = new Random();

            for (int i=1; i <= bookTitle.Length; i++)
            {
                bookList.Add(new()
                {
                    Id = i,
                    Title = bookTitle[i-1],
                    Author = names[random.Next(0, names.Length)] + " " + surnames[random.Next(0, names.Length)],
                    Description = $"{ bookTitle[i-1] } is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!",
                    TotalPage = random.Next(100, 800),
                    LanguageId = random.Next(1, 3),
                    CoverImageUrl = $"\\files\\books\\coverImages\\{coverImageName[i - 1] }",
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf"
                });
            }

            return bookList;
        }

        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(GetBooks());

            //builder.HasData(
            //    new()
            //    {
            //        Id = 1,
            //        Title = "Head First C#",
            //        Author = "Andrew Stellman",
            //        Description = "Head First C# is a complete learning experience for programming\r\nwith C#, XAML, the .NET Framework, and Visual Studio. Built for\r\nyour brain, this book keeps you engaged from the first chapter,\r\nwhere you’ll build a fully functional video game. After that, you’ll\r\nlearn about classes and object-oriented programming, draw graphics and animation, query your data with LINQ, and serialize it to\r\nfiles. And you’ll do it all by building games, solving puzzles, and\r\ndoing hands-on projects. By the time you’re done you’ll be a solid\r\nC# programmer, and you’ll have a great time along the way!",
            //        TotalPage = 194,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\edad80b3-edfb-4984-979f-319bcbb96049_Head _First_C_Sharp.pdf"
            //    },
            //    new()
            //    {
            //        Id = 2,
            //        Title = "The C++ Programming Language",
            //        Author = "Bjarne Straustrup",
            //        Description = "The new C++11 standard allows programmers to express ideas more clearly, simply, and directly, and to write faster, more efficient code. Bjarne Stroustrup, the designer and original implementer of C++, has reorganized, extended, and completely rewritten his definitive reference and tutorial for programmers who want to use C++ most effectively.",
            //        TotalPage = 1366,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\29eac4b2-b4bb-495c-b3c4-f5c01768e81f_11.pdf"
            //    },
            //    new()
            //    {
            //        Id = 3,
            //        Title = "Beginning Git and GitHub",
            //        Author = "Mariot Tsitoara",
            //        Description = "Divided into three parts – Version Control, Project Management and Teamwork – this book reveals what waits for you in the real world and how to resolve the problems you may run into. Once past the basics of Git, you'll see how to manage a software project, and finally how to utilize Git and GithHub to work effectively as a team.",
            //        TotalPage = 294,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\fc4642a8-a8b3-4e43-9134-fd2cbae68af8_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\01b97c2c-7062-478e-b0e9-8b117cc10fbe_Beginning_Git_and_GitHub_(2020).pdf"
            //    },
            //    new()
            //    {
            //        Id = 4,
            //        Title = "JavaScript for Web Developers",
            //        Author = "Matt Frisbie",
            //        Description = "Professional JavaScript for Web Developers is the essential guide to next-level JavaScript development. At 1,200 pages, this book is the most comprehensive JavaScript reference available anywhere. Written for intermediate-to-advanced programmers, this book jumps right into the technical details to help you clean up your code and become a more sophisticated JavaScript developer. ",
            //        TotalPage = 964,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\7c64fba0-1b7a-46bc-9403-a759bcbf23ea_Beginning_Git_and_GitHub_(2020).pdf"
            //    },
            //    new()
            //    {
            //        Id = 5,
            //        Title = "Python (All-In-One) For Dummies",
            //        Author = "John C. Shovic",
            //        Description = "This book is a reference manual to guide you through the process of learning\r\nPython and how to use it in modern computer applications, such as data science,\r\nartificial intelligence, physical computing, and robotics. If you’re looking to learn\r\na little about a lot of exciting things, this is the book for you. It gives you an introduction to the topics that you’ll need to explore more deeply.",
            //        TotalPage = 723,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\a8a0c944-d076-436d-8980-e8d228482a47_Python_All-In-One_for_Dummies.pdf"
            //    },
            //    new()
            //    {
            //        Id = 6,
            //        Title = "Head First Java",
            //        Author = "Kathy Sierra",
            //        Description = "Head First Java is a complete learning experience in Java and object-oriented programming. With this book, you'll learn the Java language with a unique method that goes beyond how-to manuals and helps you become a great programmer. Through puzzles, mysteries, and soul-searching interviews with famous Java objects, you'll quickly get up to speed on Java's fundamentals and advanced topics including lambdas, streams, generics, threading, networking, and the dreaded desktop GUI.",
            //        TotalPage = 722,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\59b685ea-9a6a-4bf5-be00-35d2e884f6ed_Head_First_Java_Second_Edition.pdf"
            //    },
            //    new()
            //    {
            //        Id = 7,
            //        Title = "Scala for the Impatient (Second Edition)",
            //        Author = "Cay S. Horstmann",
            //        Description = "Interest in the Scala programming language continues to grow for many reasons. Scala embraces the functional programming style without abandoning the object-oriented paradigm, and it allows you to write programs more concisely than in Java. Because Scala runs on the JVM, it can access any Java library and is interoperable with familiar Java frameworks. Scala also makes it easier to leverage the full power of concurrency.",
            //        TotalPage = 385,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\01fd088e-db1a-4e60-b6ef-ae96c2afddab_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\6dbbb0b0-59ec-4820-9422-e4df9a3241c8_Scala for the Impatient, 2nd Edition.pdf"
            //    },
            //    new()
            //    {
            //        Id = 8,
            //        Title = "Learn PHP 8",
            //        Author = "Steve Prettyman",
            //        Description = "Write solid, secure, object-oriented code in the new PHP 8. In this book you will create a complete three-tier application using a natural process of building and testing modules within each tier. This practical approach teaches you about app development and introduces PHP features when they are actually needed rather than providing you with abstract theory and contrived examples.",
            //        TotalPage = 422,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\87b8a2c5-6f10-4443-9eb1-591e15f2b308_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\1557c693-f85a-4d23-bfeb-d73933b698c8_Learn_PHP_8_2nd_Edition_(2020).pdf"
            //    },
            //    new()
            //    {
            //        Id = 9,
            //        Title = "Kotlin In Action",
            //        Author = "Dmitry Jemerov",
            //        Description = "Kotllyn became interested in Android as an official language. This book is a kind of official book written by developers of Comlin compilers in JetBrain who developed the language. The greatest feature of the Kohlin language is its practicality. This book was also used to emphasize practicality. Introduce Kotllyns fundamentals and explain the contents of higher order functions, object orientation, and generics.",
            //        TotalPage = 363,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\bcd7faf8-e2c0-4f64-895a-c26c00acdd14_Kotlin_in_Action_(2017).pdf"
            //    },
            //    new()
            //    {
            //        Id = 10,
            //        Title = "Head First Swift",
            //        Author = "Paris Buttfield-Addison",
            //        Description = "Swift is best known as Apple's programming language of choice for developing apps on iOS, iPadOS, macOS, watchOS, and tvOS. But it's far more versatile than that. Open source Swift is also gaining ground as a language for systems programming and server-side code, and it runs on Linux and Windows. So where do you start? With Head First Swift, you'll explore from the ground ",
            //        TotalPage = 722,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\5c399598-3a58-4efd-b67c-a4f55303ffcf_Paris_Buttfield-Addison_Jon_Manning_-_Head_First_Swift_2022.pdf"
            //    },
            //    new()
            //    {
            //        Id = 11,
            //        Title = "Emotional Intelligence",
            //        Author = "Brandon Goleman",
            //        Description = "Emotional Intelligence is best known as Apple's programming language of choice for developing apps on iOS, iPadOS, macOS, watchOS, and tvOS. But it's far more versatile than that. Open source Swift is also gaining ground as a language for systems programming and server-side code, and it runs on Linux and Windows. So where do you start? With Head First Swift, you'll explore from the ground",
            //        TotalPage = 356,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3bb.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\c0cecdce-f7db-47f6-8c05-e6cba73dc27b_Beginning_Git_and_GitHub_(20aa).pdf"
            //    },
            //    new()
            //    {
            //        Id = 12,
            //        Title = "Dark Psychology",
            //        Author = "Benedict Goleman",
            //        Description = "Dark Psychology is best known as Apple's programming language of choice for developing apps on iOS, iPadOS, macOS, watchOS, and tvOS. But it's far more versatile than that. Open source Swift is also gaining ground as a language for systems programming and server-side code, and it runs on Linux and Windows. So where do you start? With Head First Swift, you'll explore from the ground",
            //        TotalPage = 411,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f555.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\c0cecdce-f7db-47f6-8c05-e6cba73dc27b_Beginning_Git_and_GitHub_(20aa).pdf"
            //    },
            //    new()
            //    {
            //        Id = 13,
            //        Title = "Emotional Intelligence (Why It Can Matter More Than IQ)",
            //        Author = "Daniel Goleman",
            //        Description = "Emotional Intelligence (Why It Can Matter More Than IQ) is best known as Apple's programming language of choice for developing apps on iOS, iPadOS, macOS, watchOS, and tvOS. But it's far more versatile than that. Open source Swift is also gaining ground as a language for systems programming and server-side code, and it runs on Linux and Windows. So where do you start? With Head First Swift, you'll explore from the ground",
            //        TotalPage = 118,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f333.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\c0cecdce-f7db-47f6-8c05-e6cba73dc27b_Beginning_Git_and_GitHub_(20aa).pdf"
            //    },
            //    new()
            //    {
            //        Id = 14,
            //        Title = "The Emotional Intelligence workbook",
            //        Author = "Jill Dann",
            //        Description = "The Emotional Intelligence workbook is best known as Apple's programming language of choice for developing apps on iOS, iPadOS, macOS, watchOS, and tvOS. But it's far more versatile than that. Open source Swift is also gaining ground as a language for systems programming and server-side code, and it runs on Linux and Windows. So where do you start? With Head First Swift, you'll explore from the ground",
            //        TotalPage = 215,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-hho4f4f706f3bb.webp",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\c0cecdce-f7db-47f6-8c05-e6cba73dc27b_Beginning_Git_and_GitHub_(20aa).pdf"
            //    },
            //    new()
            //    {
            //        Id = 15,
            //        Title = "Emotional Intelligence (for leadership)",
            //        Author = "James Adams",
            //        Description = "Emotional Intelligence (for leadership) is best known as Apple's programming language of choice for developing apps on iOS, iPadOS, macOS, watchOS, and tvOS. But it's far more versatile than that. Open source Swift is also gaining ground as a language for systems programming and server-side code, and it runs on Linux and Windows. So where do you start? With Head First Swift, you'll explore from the ground",
            //        TotalPage = 422,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-7bf4f3f706f3fb.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\c0cecdce-f7db-47f6-8c05-e6cba73dc27b_Beginning_Git_and_GitHub_(20aa).pdf"
            //    },
            //    new()
            //    {
            //        Id = 16,
            //        Title = "Take What You Need",
            //        Author = "Garth Greenwell",
            //        Description = "Set in the Allegheny Mountains of Appalachia, Take What You Need tracks the aftermath of a long estrangement between a stepmother and daughter. Leah is a web editor and young mother who's sought an urban life and clean break from her rural childhood. But with her stepmother Jean's death, Leah must return to sort through what's been left behind.",
            //        TotalPage = 515,
            //        LanguageId = 1,
            //        CoverImageUrl = "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbb_1.jpg",
            //        CreatedOn = DateTime.Now,
            //        UpdatedOn = DateTime.Now,
            //        BookPdfFileUrl = "\\files\\books\\bookPdfFiles\\c0cecdce-f7db-47f6-8c05-e6cba73dc27b_Beginning_Git_and_GitHub_(20aa).pdf"
            //    }
            //);
        }
    }
}
