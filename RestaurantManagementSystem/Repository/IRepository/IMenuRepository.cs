using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository.IRepository
{
    public interface IMenuRepository
    {
        Task CreateMenuRepoAsync(Menu menu);
        Task<Menu> ReadMenuRepoAsync(int menuId);
        Task<IEnumerable<Menu>> ReadAllMenusRepoAsync();
        Task UpdateMenuRepoAsync(Menu menu);
        Task<bool> DeleteMenuRepoAsync(int menuId, string menuName);
    }
}
