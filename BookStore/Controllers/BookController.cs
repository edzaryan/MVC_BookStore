using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository? _bookRepository = null;
        private readonly ILanguageRepository? _languageRepository = null;
        private readonly IWebHostEnvironment? _webHostEnvironment = null;

        public BookController(IBookRepository bookRepository, 
            ILanguageRepository languageRepository,
            IWebHostEnvironment env)
        {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
            _webHostEnvironment = env;
        }

        [HttpGet("all-books")]
        public async Task<ViewResult> GetAllBooks()
        {
            var data = await _bookRepository.GetAllBooks();

            return View(data);
        }

        [HttpGet("book-details/{id:int:min(1)}", Name = "Details")]
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookById(id);

            return View(data);
        }

        [HttpGet]
        public ViewResult SearchBook(string bookTitle, string authorName)
        {
            var data = _bookRepository.SearchBook(bookTitle, authorName);

            return View();
        }

        [Authorize]
        [HttpGet("add-book")]
        public async Task<ViewResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            var model = new BookModel
            {
                LanguageId = 2
            };

            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;

            return View(model);
        }

        [HttpPost("add-book")]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                if (bookModel.CoverPhoto != null)
                {
                    string folder = "files\\books\\coverImages";

                    bookModel.CoverImageUrl = await UploadImage(folder, bookModel.CoverPhoto);
                }

                if (bookModel.GalleryFiles != null)
                {
                    string folder = "files\\books\\galleryImages";

                    bookModel.Gallery = new List<GalleryModel>();
                    
                    foreach (var galleryFile in bookModel.GalleryFiles)
                    {
                        var gallery = new GalleryModel
                        {
                            Name = galleryFile.FileName,
                            URL = await UploadImage(folder, galleryFile),
                        };

                        bookModel.Gallery.Add(gallery);
                    }
                }

                if (bookModel.BookPdfFile != null)
                {
                    string folder = "files\\books\\bookPdfFiles";

                    bookModel.BookPdfFileUrl = await UploadImage(folder, bookModel.BookPdfFile);
                }

                var id = await _bookRepository.AddNewBook(bookModel);

                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }

            ViewBag.Language = new SelectList(await _languageRepository.GetLanguages(), "Id", "Name");

            return View();
        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {
            folderPath += "\\" + Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "\\" + folderPath;
        }
    }
}
