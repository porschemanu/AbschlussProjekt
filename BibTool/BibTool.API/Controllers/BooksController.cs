using BibTool.API.Services.BookService;
using BibTool.Data.Models;
using Microsoft.AspNetCore.Mvc;
using RecipePlatformApi.Services.UserService;

namespace BibTool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        // GET api/books
        [HttpGet]
        public async Task<ActionResult> GetBooks()
        {
            var result = await bookService.ReadBooks();
            return Ok(result);
        }



        // GET api/books/5



        // POST api/books
        [HttpPost]
        public async Task<ActionResult> PostBook(Book book)
        {
            var result = await bookService.CreateBook(book);

            if (result == null) return BadRequest("Book could not be created");

            return Created("api/books", result);
        }






            //if (result == null) return BadRequest("User could not be created");

            //return Created("api/users", result);
        



        // PUT api/books/5



        // DELETE api/books/5
    }
}
