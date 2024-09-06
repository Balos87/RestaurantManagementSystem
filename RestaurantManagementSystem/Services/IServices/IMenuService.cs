using RestaurantManagementSystem.DTOs.MenuDTOs;
using RestaurantManagementSystem.DTOs.Menus;

namespace RestaurantManagementSystem.Services.IServices
{
    public interface IMenuService
    {
        Task CreateMenuServiceAsync(CreateMenuDto createMenuDto);
        Task<MenuSingleDto> ReadMenuServiceAsync(int menuId);
        Task<IEnumerable<MenuDto>> ReadAllMenusServiceAsync();
        Task<bool> UpdateMenuServiceAsync(int menuId, UpdateMenuDto updateMenuDto);
        Task<bool> DeleteMenuServiceAsync(int menuId, string menuName);
    }
}
