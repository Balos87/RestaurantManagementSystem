using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.Users
{
    public class UserLoginDto
    {
        [Required]
        [StringLength(380, MinimumLength = 3)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
