using System.ComponentModel.DataAnnotations;

namespace MVC_BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage="Enter book {0}")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter book {0}")]
        public string Author { get; set; }

        [StringLength(500, MinimumLength = 30)]
        public string? Description { get; set; }

        public string? Category { get; set; }

        [Required(ErrorMessage = "Enter book {0}")]
        public int? LanguageId { get; set; }

        public string? Language { get; set; }

        [Required(ErrorMessage = "Enter book {0}")]
        [Display(Name = "Total pages of book")]
        public int? TotalPages { get; set; }
        
        [Display(Name = "Choose the book cover photo")]
        [Required]
        public IFormFile? CoverPhoto { get; set; }

        public string? CoverImageUrl { get; set; }

        [Display(Name = "Choose the gallery images of the book")]
        [Required]
        public IFormFileCollection? GalleryFiles { get; set; }

        public List<GalleryModel>? Gallery { get; set; }

        [Display(Name = "Upload your book in pdf format")]
        [Required]
        public IFormFile? BookPdf { get; set; }
        public string? BookPdfUrl { get; set; }
    }
}
