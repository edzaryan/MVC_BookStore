using BookStore.Data;
using BookStore.Enums;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.ViewComponents
{
    public class BookList : ViewComponent
    {
        private readonly IBookRepository _bookRepository;

        public BookList(IBookRepository bookRepository) => _bookRepository = bookRepository;


        public async Task<IViewComponentResult> InvokeAsync(BookType type, int count, string title)
        {
            var books = await _bookRepository.GetBookList(type, count);

            ViewData["Title"] = title;

            return View(books);
        }
    }
}
