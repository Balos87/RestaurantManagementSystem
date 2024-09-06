using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.CustomerDTOs
{
    public class DeleteCustomerProfileDto
    {
        [Required]
        [EmailAddress(ErrorMessage = "Please use a valid email adress.")]
        public string Email { get; set; }
    }
}
