using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Services;
using RestaurantManagementSystem.Services.IServices;
using RestaurantManagementSystem.DTOs.Users;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUserControllerAsync([FromBody] CreateUserDto createUserDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _userService.CreateUserAsync(createUserDto);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> ReadUserControllerAsync(int userId)
        {
            var userDto = await _userService.ReadUserAsync(userId);

            if (userDto == null)
            {
                return NotFound();
            }

            return Ok(userDto);
        }

        [HttpGet]
        [Route("users")]
        public async Task<IActionResult> ReadAllUsersControllerAsync()
        {
            var userDto = await _userService.ReadAllUsersAsync();

            if (!userDto.Any())
            {
                return NotFound();
            }

            return Ok(userDto);
        }

        [HttpPut("update/{userId}")]
        public async Task<IActionResult> UpdateUserControllerAsync(int userId, [FromBody] UpdateUserDto updateUserDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var userUpdated = await _userService.UpdateUserAsync(userId, updateUserDto);

                if (!userUpdated)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("delete/{userId}")]
        public async Task<IActionResult> DeleteUserControllerAsync(int userId, [FromBody] DeleteUserDto deleteUserDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var success = await _userService.DeleteUserAsync(userId, deleteUserDto.Email);

                if (!success)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto loginDto)
        {
            var token = await _userService.LoginAsync(loginDto.Email, loginDto.Password);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(new { Token = token });
        }

        [HttpGet("user")]
        [Authorize]
        public async Task<IActionResult> GetUserDetails()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
            {
                return Unauthorized("Invalid token.");
            }

            var user = await _userService.ReadUserAsync(int.Parse(userId));

            if (user == null)
            {
                return NotFound("User not found.");
            }

            return Ok(new { user.FirstName, user.LastName });
        }



    }
}
