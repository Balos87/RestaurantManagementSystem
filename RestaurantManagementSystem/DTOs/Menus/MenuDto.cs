using RestaurantManagementSystem.DTOs.DishDTOs;

namespace RestaurantManagementSystem.DTOs.MenuDTOs
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public List<DishDto> Dishes { get; set; }
    }
}
