using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.DTOs.CustomerDTOs
{
    public class CustomerCreatedDto
    {
        [Description("Customer Successfully added!")]
        public string ConfirmationMessage { get; set; }

        [Description("Your ID, please use this to find the profile in the database!")]
        public int YourId { get; set; }
    }
}
