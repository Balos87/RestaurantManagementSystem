using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.DishDTOs
{
    public class DeleteDishDto
    {
        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string DishName { get; set; }
    }
}
