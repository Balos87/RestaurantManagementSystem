using RestaurantManagementSystem.DTOs.Menus;

namespace RestaurantManagementSystem.DTOs.Dishes
{
    public class DishDto
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool Popular { get; set; }
        public MenuDto Menu { get; set; }
    }
}
