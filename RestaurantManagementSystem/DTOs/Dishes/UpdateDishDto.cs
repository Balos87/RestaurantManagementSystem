using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.DishDTOs
{
    public class UpdateDishDto
    {
        [Required]
        [StringLength(500, MinimumLength = 1)]
        public string DishName { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }
    }
}
