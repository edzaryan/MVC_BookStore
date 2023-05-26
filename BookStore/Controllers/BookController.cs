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


        [HttpGet("categories/{category}/{letter?}/{page?}")]
        public async Task<ViewResult> GetCategoryBook(string category, string letter = "A", int page = 1)
        {
            var data = await _bookRepository.GetBooks(category, letter, page);

            return View(data);
        }


        [HttpGet("book-details/{id:int:min(1)}", Name = "Details")]
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookById(id);

            return View(data);
        }


        [HttpGet("search")]
        public /*async Task<ViewResult>*/ void SearchBook(string v = "abc", int page = 5, int rat = 4, int cond = 3, string price = "140-200", string cat = "1,5,6", string year = "1970-1980", string lang = "eng,rus,arm")
        {
            Console.WriteLine("v: " + v);
            Console.WriteLine("page: " + page);
            Console.WriteLine("rat: " + rat);
            Console.WriteLine("cond: " + cond);
            Console.WriteLine("price: " + price);
            Console.WriteLine("cat: " + cat);
            Console.WriteLine("year: " + year);
            Console.WriteLine("lang: " + lang);

            //var data = await _bookRepository.SearchBook(v, page);

            //return View(data);
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
        [RequestFormLimits(MultipartBodyLengthLimit = 152428800)]
        [RequestSizeLimit(152428800)]
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
