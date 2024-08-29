using Microsoft.Identity.Client;

namespace RestaurantManagementSystem.DTOs.CustomerDTOs
{
    public class DeleteCustomerProfileDto
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
    }
}
