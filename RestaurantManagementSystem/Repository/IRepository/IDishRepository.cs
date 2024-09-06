using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository.IRepository
{
    public interface IDishRepository
    {
        Task<Dish> CreateDishRepoAsync(Dish dish);
        Task<Dish> ReadDishRepoAsync(int dishId);
        Task<IEnumerable<Dish>> ReadAllDishesRepoAsync();
        Task UpdateDishRepoAsync(Dish dish);
        Task<bool> DeleteDishRepoAsync(int dishId, string dishName);
    }
}
