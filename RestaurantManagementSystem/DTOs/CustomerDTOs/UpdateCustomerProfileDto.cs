namespace RestaurantManagementSystem.DTOs.CustomerDTOs
{
    public class UpdateCustomerProfileDto
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }        
    }
}
