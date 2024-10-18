using RestaurantManagementSystem.DTOs.Dishes;

namespace RestaurantManagementSystem.DTOs.Menus
{
    public class MenuSingleDto
    {
        public string MenuName { get; set; }
        public List<DishDto> Dishes { get; set; }
    }
}
