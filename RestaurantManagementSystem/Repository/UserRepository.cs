using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RestaurantManagementSystemContext _context;

        public UserRepository(RestaurantManagementSystemContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserRepoAsync(User user)
        {
            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return user;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<User> ReadUserRepoAsync(int userId)
        {
            try
            {
                return await _context.Users.SingleOrDefaultAsync(c => c.UserId == userId);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task<IEnumerable<User>> ReadAllUsersRepoAsync()
        {
            try
            {
                return await _context.Users.Include(u => u.Role).ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public async Task UpdateUserRepoAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();          
        }

        public async Task<bool> DeleteUserRepoAsync(User user)
        {
            var userToDelete = await _context.Users
                .FirstOrDefaultAsync(c => c.UserId == user.UserId && c.Email == user.Email);

            if (userToDelete == null)
            {
                return false;
            }

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<User> FindUserWithEmailAsync(string email)
        {
            return await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
