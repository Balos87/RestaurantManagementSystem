using RestaurantManagementSystem.Repository;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;
using RestaurantManagementSystem.DTOs.Users;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace RestaurantManagementSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task CreateUserAsync(CreateUserDto createUserDto)
        {
            var checkingForExistingUserEmail = await _userRepository.FindUserWithEmailAsync(createUserDto.Email);
            if (checkingForExistingUserEmail != null)
            {
                throw new ArgumentException("There is already a user with that email in the database.");
            }

            string newPassword = BCrypt.Net.BCrypt.HashPassword(createUserDto.Password);

            var newUser = new User()
            {
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                PhoneNumber = createUserDto.PhoneNumber,
                Email = createUserDto.Email,
                PasswordHash = newPassword,
                RoleId = 3
            };


            await _userRepository.CreateUserRepoAsync(newUser);
        }

        public async Task<UserSingleDto> ReadUserAsync(int userId)
        {
            var user = await _userRepository.ReadUserRepoAsync(userId);

            if (user == null)
            {
                return null;
            }

            var userDto = new UserSingleDto()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            };

            return userDto;
        }

        public async Task<IEnumerable<UserDto>> ReadAllUsersAsync()
        {
            var users = await _userRepository.ReadAllUsersRepoAsync();

            var userDto = users.Select(user => new UserDto()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                RoleName = user.Role.RoleName
            });

            return userDto;
        }

        public async Task<bool> UpdateUserAsync(int userId, UpdateUserDto updateUserDto)
        {
            var user = await _userRepository.ReadUserRepoAsync(userId);
            if (user == null)
            {
                return false;
            }

            user.FirstName = updateUserDto.FirstName;
            user.LastName = updateUserDto.LastName;
            user.Email = updateUserDto.Email;
            user.PhoneNumber = updateUserDto.PhoneNumber;

            await _userRepository.UpdateUserRepoAsync(user);

            return true;
        }

        public async Task<bool> DeleteUserAsync(int userId, string email)
        {
            var user = new User()
            {
                UserId = userId,
                Email = email
            };

            return await _userRepository.DeleteUserRepoAsync(user);
        }

        public async Task<string> LoginAsync(string email, string password)
        {
            var user = await _userRepository.FindUserWithEmailAsync(email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return null;
            }

            return GenerateJwtToken(user);
        }

        private string GenerateJwtToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>()
            {
                new(JwtRegisteredClaimNames.Sub, user.Email),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.NameId, user.UserId.ToString()),
                new(JwtRegisteredClaimNames.Name, $"{user.FirstName} {user.LastName}"),
                new(JwtRegisteredClaimNames.Email, user.Email),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new(ClaimTypes.Role, user.Role.RoleName),
                new(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
            };

            var token = new JwtSecurityToken
            (
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
