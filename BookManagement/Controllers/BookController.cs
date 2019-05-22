using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagement.Entity;
using BookManagement.Service.Contract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookManagement.Controllers
{
    public class BookController : Controller
    {
        #region Private Fields

        private readonly IBookService _bookService;

        #endregion

        #region Constructors

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        #endregion

        #region Public Methods

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetBooks();
            return View(books);
        }

        public IActionResult Add(Book book)
        {
            _bookService.AddBook(book);

            return RedirectToAction("Index");
        }


        #endregion
    }
}
