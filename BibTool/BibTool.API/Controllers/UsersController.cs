using Azure;
using BibTool.API.Services.UserService;
using BibTool.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibTool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET api/users
        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var result = await userService.ReadUsers();
            return Ok(result);
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser(int id)
        {
            var result = await userService.ReadUser(id);

            if (result == null) return NotFound($"User with Id: \"{id}\" was not found");

            return Ok(result);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult> PostUser(User user)
        {
            var result = await userService.CreateUser(user);

            if (result == null) return BadRequest("User could not be created");

            return Created("api/users", result);
        }

        // PUT api/users/5
        [HttpPut]
        public async Task<ActionResult> PutUser(int id, User user)
        {
            var result = await userService.UpdateUser(id, user);

            if (result == null) return NotFound($"User with id \"{id}\" could not be updated");

            return NoContent();
        }

        // PATCH api/users/5
        [HttpPatch]
        public async Task<ActionResult> PatchUser([FromBody] JsonPatchDocument<User> patchDocument)
        {
            return Ok("");
        }

        // DELETE api/users/5
        [HttpDelete]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var result = await userService.DeleteUser(id);

            if (result == null) return BadRequest($"User with Id: \"{id}\" could not be deleted");

            return NoContent();
        }
    }
}
