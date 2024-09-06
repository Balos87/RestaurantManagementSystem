using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.MenuDTOs
{
    public class UpdateMenuDto
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string MenuName { get; set; }
    }
}
