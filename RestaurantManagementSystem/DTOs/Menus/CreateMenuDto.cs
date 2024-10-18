using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.Menus
{
    public class CreateMenuDto
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string MenuName { get; set; }
    }
}
