using RestaurantManagementSystem.DTOs.Dishes;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Services.IServices
{
    public interface IDishService
    {
        Task CreateDishAsync(CreateDishDto createDishDto);
        Task<DishSingleDto> ReadDishAsync(int dishId);
        Task<IEnumerable<DishDto>> ReadAllDishesAsync();
        Task LinkDishToMenuAsync(int dishId, int menuId);
        Task UnlinkDishFromMenuAsync(int dishId);
        Task<bool> UpdateDishAsync(int dishId, UpdateDishDto updateDishDto);
        Task<bool> DeleteDishAsync(int dishId, string dishName);
        Task<IEnumerable<Dish>> PopularDishesAsync();
    }
}
