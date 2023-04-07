using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class BookGalleryConfiguration : IEntityTypeConfiguration<BookGallery>
    {
        private List<BookGallery> GetBookGallery()
        {
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

            List<BookGallery> bookGalleryList = new();

            int TargetId = 1;

            for (int i=1; i <= coverImageName.Length; i++)
            {
                bookGalleryList.Add(new()
                {
                    Id = TargetId,
                    BookId = i,
                    Name = "X.jpeg",
                    URL = $"\\files\\books\\coverImages\\{coverImageName[i-1]}"
                });

                TargetId++;

                string[] galleryImageNames = {
                    "45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
                    "45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
                    "ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png"
                };

                for (int j=0; j < 3; j++)
                {
                    bookGalleryList.Add(new()
                    {
                        Id = TargetId,
                        BookId = i,
                        Name = "X.jpeg",
                        URL = $"\\files\\books\\galleryImages\\{galleryImageNames[j]}"
                    });

                    TargetId++;
                }
            }

            return bookGalleryList;
        }
        public void Configure(EntityTypeBuilder<BookGallery> builder)
        {
            builder.HasData(GetBookGallery());

            //builder.HasData(
            //    // C#
            //    new()
            //    {
            //        Id = 1,
            //        Name = "5.jpeg",
            //        URL = "\\files\\books\\coverImages\\83522a32-aa0b-4bd6-a84a-9e5476a26ab5_1.png",
            //        BookId = 1,
            //    },
            //    new()
            //    {
            //        Id = 2,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 1,
            //    },
            //    new()
            //    {
            //        Id = 3,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 1,
            //    },
            //    new()
            //    {
            //        Id = 4,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 1,
            //    },

            //    // C++
            //    new()
            //    {
            //        Id = 5,
            //        Name = "4.jpeg",
            //        URL = "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9fc8-ddd079389cbb_1.jpg",
            //        BookId = 2,
            //    },
            //    new()
            //    {
            //        Id = 6,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 2,
            //    },
            //    new()
            //    {
            //        Id = 7,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 3,
            //    },
            //    new()
            //    {
            //        Id = 8,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 4,
            //    },

            //    // Git
            //    new()
            //    {
            //        Id = 9,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\coverImages\\1a059024-fb6e-410d-85db-963ba3f455b4_1.jpg",
            //        BookId = 3,
            //    },
            //    new()
            //    {
            //        Id = 10,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 3,
            //    },
            //    new()
            //    {
            //        Id = 11,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 3,
            //    },
            //    new()
            //    {
            //        Id = 12,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 3,
            //    },

            //    // Javascript
            //    new()
            //    {
            //        Id = 13,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3_1.jpg",
            //        BookId = 4,
            //    },
            //    new()
            //    {
            //        Id = 14,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 4,
            //    },
            //    new()
            //    {
            //        Id = 15,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 4,
            //    },
            //    new()
            //    {
            //        Id = 16,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 4,
            //    },

            //    // Python
            //    new()
            //    {
            //        Id = 17,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\coverImages\\359ee713-f716-488c-866d-d05c57bafc1b_1.jpg",
            //        BookId = 5,
            //    },
            //    new()
            //    {
            //        Id = 18,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 5,
            //    },
            //    new()
            //    {
            //        Id = 19,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 5,
            //    },
            //    new()
            //    {
            //        Id = 20,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 5,
            //    },

            //    // Java
            //    new()
            //    {
            //        Id = 21,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\coverImages\\04734f18-dc2e-4ed5-bf47-5be69608dc9a_1.jpeg",
            //        BookId = 6,
            //    },
            //    new()
            //    {
            //        Id = 22,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 6,
            //    },
            //    new()
            //    {
            //        Id = 23,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 6,
            //    },
            //    new()
            //    {
            //        Id = 24,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 6,
            //    },

            //    // Scala
            //    new()
            //    {
            //        Id = 25,
            //        Name = "1.jpeg",
            //        URL = "\\files\\books\\coverImages\\f2954d2c-94e0-4b0a-adce-058ed70d5b32_1.jpg",
            //        BookId = 7,
            //    },
            //    new()
            //    {
            //        Id = 26,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 7,
            //    },
            //    new()
            //    {
            //        Id = 27,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 7,
            //    },
            //    new()
            //    {
            //        Id = 28,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 7,
            //    },

            //    // PHP
            //    new()
            //    {
            //        Id = 29,
            //        Name = "1.jpg",
            //        URL = "\\files\\books\\coverImages\\6004d2f5-8fc5-4fbc-8c63-c82367c9cb31_1.jpg",
            //        BookId = 8,
            //    },
            //    new()
            //    {
            //        Id = 30,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 8,
            //    },
            //    new()
            //    {
            //        Id = 31,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 8,
            //    },
            //    new()
            //    {
            //        Id = 32,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 8,
            //    },

            //    // Kotlin
            //    new()
            //    {
            //        Id = 33,
            //        Name = "1.jpg",
            //        URL = "\\files\\books\\coverImages\\a2eedf17-f1d1-4094-a141-fa8b42997f2a_1.jpg",
            //        BookId = 9,
            //    },
            //    new()
            //    {
            //        Id = 34,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 9,
            //    },
            //    new()
            //    {
            //        Id = 35,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 9,
            //    },
            //    new()
            //    {
            //        Id = 36,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 9,
            //    },

            //    // Swift
            //    new()
            //    {
            //        Id = 37,
            //        Name = "1.jpg",
            //        URL = "\\files\\books\\coverImages\\648c38b8-0ed4-4674-a9e5-c5d623063e95_1.jpg",
            //        BookId = 10,
            //    },
            //    new()
            //    {
            //        Id = 38,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 10,
            //    },
            //    new()
            //    {
            //        Id = 39,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 10,
            //    },
            //    new()
            //    {
            //        Id = 40,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 10,
            //    },


            //    // Emotional Intelligence
            //    new()
            //    {
            //        Id = 41,
            //        Name = "1.jpg",
            //        URL = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f3bb.jpg",
            //        BookId = 11,
            //    },
            //    new()
            //    {
            //        Id = 42,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 11,
            //    },
            //    new()
            //    {
            //        Id = 43,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 11,
            //    },
            //    new()
            //    {
            //        Id = 44,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 11,
            //    },


            //    // Dark Psychology
            //    new()
            //    {
            //        Id = 45,
            //        Name = "1.jpg",
            //        URL = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f555.jpg",
            //        BookId = 12,
            //    },
            //    new()
            //    {
            //        Id = 46,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 12,
            //    },
            //    new()
            //    {
            //        Id = 47,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 12,
            //    },
            //    new()
            //    {
            //        Id = 48,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 12,
            //    },

            //    // Emotional Intelligence (Why It Can Matter More Than IQ)
            //    new()
            //    {
            //        Id = 49,
            //        Name = "1.jpg",
            //        URL = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-bbf4f4f706f333.jpg",
            //        BookId = 13,
            //    },
            //    new()
            //    {
            //        Id = 50,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 13,
            //    },
            //    new()
            //    {
            //        Id = 51,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 13,
            //    },
            //    new()
            //    {
            //        Id = 52,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 13,
            //    },

            //    // The Emotional Intelligence workbook
            //    new()
            //    {
            //        Id = 53,
            //        Name = "1.jpg",
            //        URL = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-hho4f4f706f3bb.webp",
            //        BookId = 14,
            //    },
            //    new()
            //    {
            //        Id = 54,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 14,
            //    },
            //    new()
            //    {
            //        Id = 55,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 14,
            //    },
            //    new()
            //    {
            //        Id = 56,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 14,
            //    },

            //    // Emotional Intelligence (for leadership)
            //    new()
            //    {
            //        Id = 57,
            //        Name = "1.jpg",
            //        URL = "\\files\\books\\coverImages\\1e15c7af-09d5-4484-9cf7-7bf4f3f706f3fb.jpg",
            //        BookId = 15,
            //    },
            //    new()
            //    {
            //        Id = 58,
            //        Name = "2.jpg",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 15,
            //    },
            //    new()
            //    {
            //        Id = 59,
            //        Name = "3.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 15,
            //    },
            //    new()
            //    {
            //        Id = 60,
            //        Name = "4.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 15,
            //    },

            //    // Take What You Need
            //    new()
            //    {
            //        Id = 61,
            //        Name = "5.png",
            //        URL = "\\files\\books\\coverImages\\acbc0832-b6cb-4cbe-9gc8-ddd079389cbb_1.jpg",
            //        BookId = 16,
            //    },
            //    new()
            //    {
            //        Id = 62,
            //        Name = "5.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4b77-b9cb-9e4120a9619d_3.png",
            //        BookId = 16,
            //    },
            //    new()
            //    {
            //        Id = 63,
            //        Name = "5.png",
            //        URL = "\\files\\books\\galleryImages\\45f78393-ca6c-4bd7-b9cb-9e4120a9619d_3.png",
            //        BookId = 16,
            //    },
            //    new()
            //    {
            //        Id = 64,
            //        Name = "5.png",
            //        URL = "\\files\\books\\galleryImages\\ce0f7196-f93d-4de6-85e7-f1ed076b4aaa_2.png",
            //        BookId = 16,
            //    }
            //);
        }
    }
}
