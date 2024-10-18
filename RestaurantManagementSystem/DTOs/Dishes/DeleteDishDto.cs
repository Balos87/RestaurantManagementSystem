using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.Dishes
{
    public class DeleteDishDto
    {
        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string DishName { get; set; }
    }
}
