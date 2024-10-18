using RestaurantManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }

        [StringLength(20, MinimumLength = 5)]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(380, MinimumLength = 3)]
        [EmailAddress]
        public string Email { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}