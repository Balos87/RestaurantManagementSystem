using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;

namespace RestaurantManagementSystem.Repository
{
    public class DishRepository : IDishRepository
    {
        private readonly RestaurantManagementSystemContext _context;

        public DishRepository(RestaurantManagementSystemContext context)
        {
            _context = context;
        }

        public async Task<Dish> CreateDishRepoAsync(Dish dish)
        {
            try
            {
                await _context.Dishes.AddAsync(dish);
                await _context.SaveChangesAsync();
                return dish;
            }
            catch (Exception)
            {
                throw new Exception("Could not add data to database.");
            }
        }

        public async Task<Dish> ReadDishRepoAsync(int dishId)
        {
            try
            {
                return await _context.Dishes
                    .Include(d => d.Menu)
                    .SingleOrDefaultAsync(d => d.DishId == dishId);
            }
            catch (Exception)
            {
                throw new Exception("Could Not Fetch Data from Database.");
            }
        }

        public async Task<IEnumerable<Dish>> ReadAllDishesRepoAsync()
        {
            try
            {
                return await _context.Dishes
                    .Include(d => d.Menu)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Could Not Fetch Data from Database.");
            }
        }

        public async Task UpdateDishRepoAsync(Dish dish)
        {
            _context.Dishes.Update(dish);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteDishRepoAsync(int dishId, string dishName)
        {
            var dishToDelete = await _context.Dishes
                .FirstOrDefaultAsync(d => d.DishId == dishId && d.DishName == dishName);

            if (dishToDelete == null)
            {
                return false;
            }

            _context.Dishes.Remove(dishToDelete);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
