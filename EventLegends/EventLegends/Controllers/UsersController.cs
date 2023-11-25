using EventLegends.Models.DTOs;
using EventLegends.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace EventLegends.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserById([FromRoute] Guid userId)
        {
            var user = await _userService.GetUserById(userId);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDto userDto)
        {
            await _userService.CreateUser(userDto);
            return Ok();
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid userId, [FromBody] UserDto userDto)
        {
            await _userService.UpdateUser(userId, userDto);
            return Ok();
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid userId)
        {
            await _userService.DeleteUser(userId);
            return Ok();
        }
    }

}
