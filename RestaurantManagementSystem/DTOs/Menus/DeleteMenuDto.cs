using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.MenuDTOs
{
    public class DeleteMenuDto
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string MenuName { get; set; }
    }
}
