using RestaurantManagementSystem.DTOs.Dishes;

namespace RestaurantManagementSystem.DTOs.Menus
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public List<DishDto> Dishes { get; set; }
    }
}
