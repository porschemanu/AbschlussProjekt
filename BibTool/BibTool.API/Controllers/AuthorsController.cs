using BibTool.API.Services.AuthorService;
using BibTool.API.Services.UserService;
using BibTool.Data.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BibTool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService authorService;

        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        // GET api/authors
        [HttpGet]
        public async Task<ActionResult> GetAuthors()
        {
            var result = await authorService.ReadAuthors();
            return Ok(result);
        }

        // GET api/authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAuthor(int id)
        {
            var result = await authorService.ReadAuthor(id);

            if (result == null) return NotFound($"Author with Id: \"{id}\" was not found");

            return Ok(result);
        }

        // POST api/authors
        [HttpPost]
        public async Task<ActionResult> PostAuthor(Author author)
        {
            var result = await authorService.CreateAuthor(author);

            if (result == null) return BadRequest("Author could not be created");

            return Created("api/authors", result);
        }


        // PUT api/authors/5
        [HttpPut]
        public async Task<ActionResult> PutAuthor(int id, Author author)
        {
            var result = await authorService.UpdateAuthor(id, author);

            if (result == null) return NotFound($"Author with id \"{id}\" could not be updated");

            return NoContent();
        }

        // DELETE api/authors/5
        [HttpDelete]
        public async Task<ActionResult> DeleteAuthor(int id)
        {
            var result = await authorService.DeleteAuthor(id);

            if (result == null) return BadRequest($"Author with Id: \"{id}\" could not be deleted");

            return NoContent();
        }
    }
}
