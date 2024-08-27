using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        [RegularExpression(@"^\d{10}$")]
        public string SocialSecurityNumber { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 3)]
        [EmailAddress]
        public string PersonalEmail { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 3)]
        [EmailAddress]
        public string WorkEmail { get; set; } = string.Empty;

        [Required]
        public Role AccountType { get; set; } = Role.Employee;

    }
}
