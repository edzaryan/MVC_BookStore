using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please enter the title of the book")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the author of the book")]
        public string Author { get; set; }

        [StringLength(500, MinimumLength = 30)]
        public string? Description { get; set; }

        public string? Category { get; set; }

        [Required(ErrorMessage = "Please enter the total pages of the book")]
        [Display(Name = "Total pages of book")]
        public int TotalPage { get; set; }

        [Required(ErrorMessage = "Please choose the language of the book")]
        [Display(Name = "Language")]
        public int? LanguageId { get; set; }

        public string? Language { get; set; }
        
        [Required(ErrorMessage = "Please choose the cover image of the book")]
        [Display(Name = "Cover Photo")]
        public IFormFile CoverPhoto { get; set; }

        public string? BookPdfFileUrl { get; set; }

        [Required(ErrorMessage = "Please choose the gallery images of the book")]
        [Display(Name = "Gallery Images")]
        public IFormFileCollection GalleryFiles { get; set; }

        public string? CoverImageUrl { get; set; }

        [Required(ErrorMessage = "Please choose the file of the book (in PDF format)")]
        [Display(Name = "Cover PDF file")]
        public IFormFile BookPdfFile { get; set; }

        public List<GalleryModel>? Gallery { get; set; }
    }
}
