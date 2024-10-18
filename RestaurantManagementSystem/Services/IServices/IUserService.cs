using RestaurantManagementSystem.DTOs.Users;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Services.IServices
{
    public interface IUserService
    {
        Task CreateUserAsync(CreateUserDto createUserDto);
        Task<UserSingleDto> ReadUserAsync(int userId);
        Task<IEnumerable<UserDto>> ReadAllUsersAsync();
        Task<bool> UpdateUserAsync(int userId, UpdateUserDto updateUserDto);
        Task<bool> DeleteUserAsync(int userId, string email);
        Task<string> LoginAsync(string email, string password);

    }
}
