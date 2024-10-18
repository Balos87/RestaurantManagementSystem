using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<User> CreateUserRepoAsync(User user);
        Task<User> ReadUserRepoAsync(int userId);
        Task<IEnumerable<User>> ReadAllUsersRepoAsync();
        Task UpdateUserRepoAsync(User user);
        Task<bool> DeleteUserRepoAsync(User user);
        Task<User> FindUserWithEmailAsync(string email);
    }
}
