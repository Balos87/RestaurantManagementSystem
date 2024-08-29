using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.CustomerDTOs
{
    public class CustomerCreatedDto
    {
        public string Confirmation { get; set; } = "Customer Successfully Added!";
        public int CustomerId { get; set; }
        public string Message { get; set; } = "Please use this ID to view the profile.";
    }
}
