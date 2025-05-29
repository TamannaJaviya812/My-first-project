using BookApi.Models;
using BookApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly BookService bookService;
        public BookController(BookService book)
        {
            this.bookService = book;
        }

        [HttpPost]
        [Route ("Add")]
        public ActionResult AddBook(Book book)
        {
            this.bookService.AddBook(book);
            return Ok("Book created !");
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(this.bookService.GetAll());
        }

        [HttpGet]
        [Route("GetById")]

        public ActionResult GetById([FromQuery]int id)
        {
            var res = this.bookService.GetBookById(id);

            if (res != null) { return Ok(res);  }
            return NotFound("Book not found!");

        }

    }
}
 