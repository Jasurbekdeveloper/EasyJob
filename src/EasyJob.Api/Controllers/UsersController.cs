using EasyJob.Application.Services.Users;
using EasyJob.Domain.Entities.Users;
using Microsoft.AspNetCore.Mvc;

namespace EasyJob.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<User>> PostUserAsync(
            User user)
        {
            var createdUser = await this.userService
                .CreateUserAsync(user);

            return Created("", createdUser);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = this.userService
                .RetrieveUsers();

            return Ok(users);
        }

        [HttpGet("{userId:guid}")]
        public async ValueTask<ActionResult<User>> GetUserByIdAsync(
            Guid userId)
        {
            var user = await this.userService
                .RetrieveUserByIdAsync(userId);

            return Ok(user);
        }

        [HttpPut]
        public async ValueTask<ActionResult<User>> PutUserAsync(
            User user)
        {
            var modifiedUser = await this.userService
                .ModifyUserAsync(user);

            return Ok(modifiedUser);
        }

        [HttpDelete("{userId:guid}")]
        public async ValueTask<ActionResult<User>> DeleteUserAsync(
            Guid userId)
        {
            var removed = await this.userService
                .RemoveUserAsync(userId);

            return Ok(removed);
        }
    }
}
