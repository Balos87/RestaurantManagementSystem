using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;

namespace RestaurantManagementSystem.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly RestaurantManagementSystemContext _context;

        public MenuRepository(RestaurantManagementSystemContext context)
        {
            _context = context;
        }

        public async Task CreateMenuRepoAsync(Menu menu)
        {
            await _context.Menus.AddAsync(menu);
            await _context.SaveChangesAsync();
        }

        public async Task<Menu> ReadMenuRepoAsync(int menuId)
        {
            try
            {
                return await _context.Menus
                    .Include(m => m.Dishes)
                    .SingleOrDefaultAsync(m => m.MenuId == menuId);
            }
            catch (Exception)
            {
                throw new Exception("Something went wrong when trying to fetch data from database.");
            }
        }

        public async Task<IEnumerable<Menu>> ReadAllMenusRepoAsync()
        {
            return await _context.Menus
                .Include(m => m.Dishes)
                .ToListAsync();
        }

        public async Task UpdateMenuRepoAsync(Menu menu)
        {
            _context.Menus.Update(menu);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteMenuRepoAsync(int menuId, string menuName)
        {
            var menuToDelete = await _context.Menus
                .Include(m => m.Dishes)
                .FirstOrDefaultAsync(m => m.MenuId == menuId && m.MenuName == menuName);

            if (menuToDelete == null)
            {
                return false;
            }

            foreach (var dish in menuToDelete.Dishes)
            {
                dish.MenuId = null;
            }

            _context.Menus.Remove(menuToDelete);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
