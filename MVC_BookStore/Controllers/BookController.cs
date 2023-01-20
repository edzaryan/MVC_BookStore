using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_BookStore.Models;
using MVC_BookStore.Repository;

namespace MVC_BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRep;
        private readonly ILanguageRepository _langRep;
        private readonly IWebHostEnvironment _webHostEnv;

        public BookController(IBookRepository bookRep, ILanguageRepository langRep, IWebHostEnvironment webHostEnv)
        {
            _bookRep = bookRep;
            _langRep = langRep;
            _webHostEnv = webHostEnv;
        }

        public async Task<ViewResult> AllBooks()
        {
            var all_books = await _bookRep.GetAllBooksAsync();

            return View(all_books);
        }

        [Route("{id:int:min(1)}")]
        public async Task<ViewResult> GetBook(int id)
        {
            var book = await _bookRep.GetBookByIdAsync(id);

            return View(book);
        }

        //public async Task<List<BookModel>> SearchBooks(string bookName, string authorName)
        //{
        //    // return await _bookRep.SearchBookAsync(bookName, authorName);
        //}

        [Authorize]
        [HttpGet("addNewBook")]
        public async Task<IActionResult> AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            var model = new BookModel();

            ViewBag.Language = new SelectList(await _langRep.GetLanguages(), "Id", "Name");

            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;

            return View(model);
        }

        [HttpPost("addNewBook")]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                if (bookModel.CoverPhoto != null)
                {
                    string folder = "books/cover/";
                    bookModel.CoverImageUrl = await UploadImage(folder, bookModel.CoverPhoto);
                }

                if (bookModel.GalleryFiles != null)
                {
                    string folder = "books/gallery/";

                    bookModel.Gallery = new List<GalleryModel>();

                    foreach (var file in bookModel.GalleryFiles)
                    {
                        var gallery = new GalleryModel
                        {
                            Name = file.Name,
                            URL = await UploadImage(folder, file)
                        };

                        bookModel.Gallery.Add(gallery);
                    }
                }

                if (bookModel.BookPdf != null)
                {
                    string folder = "books/pdf/";

                    bookModel.BookPdfUrl = await UploadImage(folder, bookModel.BookPdf);
                }

                int id = await _bookRep.AddBookAsync(bookModel);

                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }

            return View();
        }

        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {
            folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;

            string serverFolder = Path.Combine(_webHostEnv.WebRootPath, folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }
    }
}
