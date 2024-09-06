using RestaurantManagementSystem.DTOs.DishDTOs;
using RestaurantManagementSystem.DTOs.MenuDTOs;
using RestaurantManagementSystem.DTOs.Menus;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task CreateMenuServiceAsync(CreateMenuDto createMenuDto)
        {
            var menu = new Menu
            {
                MenuName = createMenuDto.MenuName
            };

            await _menuRepository.CreateMenuRepoAsync(menu);
        }

        public async Task<MenuSingleDto> ReadMenuServiceAsync(int menuId)
        {
            var menu = await _menuRepository.ReadMenuRepoAsync(menuId);

            if (menu == null)
            {
                return null;
            }

            return new MenuSingleDto
            {
                MenuName = menu.MenuName,
                Dishes = menu.Dishes?.Select(d => new DishDto
                {
                    DishId = d.DishId,
                    DishName = d.DishName,
                    Description = d.Description,
                    Price = d.Price,
                    IsAvailable = d.IsAvailable
                }).ToList()
            };
        }

        public async Task<IEnumerable<MenuDto>> ReadAllMenusServiceAsync()
        {
            var menus = await _menuRepository.ReadAllMenusRepoAsync();

            var menuDtos = menus.Select(menu => new MenuDto()
            {
                MenuId = menu.MenuId,
                MenuName = menu.MenuName,
                Dishes = menu.Dishes.Select(d => new DishDto()
                {
                    DishId = d.DishId,
                    DishName = d.DishName,
                    Description = d.Description,
                    Price = d.Price,
                    IsAvailable = d.IsAvailable
                }).ToList()
            });

            return menuDtos;
        }

        public async Task<bool> UpdateMenuServiceAsync(int menuId, UpdateMenuDto updateMenuDto)
        {
            var menu = await _menuRepository.ReadMenuRepoAsync(menuId);

            if (menu == null)
            {
                return false;
            }

            menu.MenuName = updateMenuDto.MenuName;

            await _menuRepository.UpdateMenuRepoAsync(menu);

            return true;
        }

        public async Task<bool> DeleteMenuServiceAsync(int menuId, string menuName)
        {
            return await _menuRepository.DeleteMenuRepoAsync(menuId, menuName);
        }
    }
}
