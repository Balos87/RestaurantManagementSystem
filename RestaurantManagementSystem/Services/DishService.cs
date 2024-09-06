using RestaurantManagementSystem.DTOs.DishDTOs;
using RestaurantManagementSystem.DTOs.Dishes;
using RestaurantManagementSystem.DTOs.MenuDTOs;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _dishRepository;
        private readonly IMenuRepository _menuRepository;

        public DishService(IDishRepository dishRepository, IMenuRepository menuRepository)
        {
            _dishRepository = dishRepository;
            _menuRepository = menuRepository;
        }

        public async Task CreateDishAsync(CreateDishDto createDishDto)
        {
            var dish = new Dish()
            {
                DishName = createDishDto.DishName,
                Description = createDishDto.Description,
                Price = createDishDto.Price,
                IsAvailable = createDishDto.IsAvailable
            };

            await _dishRepository.CreateDishRepoAsync(dish);
        }

        public async Task<DishSingleDto> ReadDishAsync(int dishId)
        {
            var dish = await _dishRepository.ReadDishRepoAsync(dishId);

            if (dish == null)
            {
                return null;
            }

            var dishProfileDto = new DishSingleDto()
            {
                DishName = dish.DishName,
                Description = dish.Description,
                Price = dish.Price,
                IsAvailable = dish.IsAvailable,
                Menu = dish.Menu != null ? new MenuDto() { MenuId = dish.Menu.MenuId, MenuName = dish.Menu.MenuName } : null
            };

            return dishProfileDto;
        }

        public async Task<IEnumerable<DishDto>> ReadAllDishesAsync()
        {
            var dishes = await _dishRepository.ReadAllDishesRepoAsync();

            var dishDtos = dishes.Select(dish => new DishDto()
            {
                DishId = dish.DishId,
                DishName = dish.DishName,
                Description = dish.Description,
                Price = dish.Price,
                IsAvailable = dish.IsAvailable,
                Menu = dish.Menu != null ? new MenuDto() { MenuId = dish.Menu.MenuId, MenuName = dish.Menu.MenuName } : null
            });

            return dishDtos;
        }

        public async Task LinkDishToMenuAsync(int dishId, int menuId)
        {
            var dish = await _dishRepository.ReadDishRepoAsync(dishId) ?? throw new ArgumentException("Sorry, but no dish with the provided ID was found.");

            var menu = await _menuRepository.ReadMenuRepoAsync(menuId) ?? throw new ArgumentException("Sorry, but no menu with the provided ID was found.");

            dish.MenuId = menuId;

            await _dishRepository.UpdateDishRepoAsync(dish);
        }

        public async Task UnlinkDishFromMenuAsync(int dishId)
        {
            var dish = await _dishRepository.ReadDishRepoAsync(dishId) ?? throw new ArgumentException("Sorry, but no dish with the provided ID was found.");

            dish.MenuId = null;

            await _dishRepository.UpdateDishRepoAsync(dish);
        }

        public async Task<bool> UpdateDishAsync(int dishId, UpdateDishDto updateDishDto)
        {
            var dish = await _dishRepository.ReadDishRepoAsync(dishId);
            if (dish == null)
            {
                return false;
            }

            dish.DishName = updateDishDto.DishName;
            dish.Description = updateDishDto.Description;
            dish.Price = updateDishDto.Price;
            dish.IsAvailable = updateDishDto.IsAvailable;

            await _dishRepository.UpdateDishRepoAsync(dish);
            return true;
        }

        public async Task<bool> DeleteDishAsync(int dishId, string dishName)
        {
            return await _dishRepository.DeleteDishRepoAsync(dishId, dishName);
        }
    }
}
