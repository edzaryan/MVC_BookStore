using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    public class BookGalleryConfiguration : IEntityTypeConfiguration<BookGallery>
    {
        public void Configure(EntityTypeBuilder<BookGallery> builder)
        {
            builder.HasData(
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
                }
              );
        }
    }
}
