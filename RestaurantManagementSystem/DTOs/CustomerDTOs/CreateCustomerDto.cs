using RestaurantManagementSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.CustomerDTOs
{
    public class CreateCustomerDto
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name has to be between 2 and 50 characters long.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Name has to be between 2 and 100 characters long.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Phonenumber needs to be between 5 and 20 characters long.")]
        [Phone(ErrorMessage = "Please enter a valid Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Email has to be between 3 and 70 characters long.")]
        [EmailAddress(ErrorMessage = "Please use a valid email adress.")]
        public string Email { get; set; }

    }
}
