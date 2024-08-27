using RestaurantManagementSystem.DTOs.CustomerDTOs;

namespace RestaurantManagementSystem.Services.IServices
{
    public interface ICustomerService
    {
        Task<CustomerProfileDto> GetCustomerProfileAsync(int customerId);
        Task<CustomerProfileDto> CreateCustomerAsync(CreateCustomerDto createCustomerDto);
    }
}
