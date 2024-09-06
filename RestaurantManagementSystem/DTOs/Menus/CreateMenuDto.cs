using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.MenuDTOs
{
    public class CreateMenuDto
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string MenuName { get; set; }
    }
}
