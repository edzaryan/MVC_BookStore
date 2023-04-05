﻿namespace BookStore.Data
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string? Description { get; set; }

        public string? Category { get; set; }

        public int TotalPage { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? CoverImageUrl { get; set; }

        public string? BookPdfFileUrl { get; set; }

        public int? LanguageId { get; set; }

        public Language? Language { get; set; }

        public ICollection<BookGallery> bookGallery { get; set; }
    }
}
