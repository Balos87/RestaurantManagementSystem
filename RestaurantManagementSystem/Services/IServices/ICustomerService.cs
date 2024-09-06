using RestaurantManagementSystem.DTOs.CustomerDTOs;
using RestaurantManagementSystem.DTOs.Customers;

namespace RestaurantManagementSystem.Services.IServices
{
    public interface ICustomerService
    {
        // ------ CRUD Operations for Customers -------
        Task CreateCustomerProfileAsync(CreateCustomerDto createCustomerDto);
        Task<CustomerSingleDto> ReadCustomerProfileAsync(int customerId);
        Task<IEnumerable<CustomerDto>> ReadAllCustomersAsync();
        Task<bool> UpdateCustomerProfileAsync(int customerId, UpdateCustomerProfileDto updateCustomerProfileDto);
        Task<bool> DeleteCustomerProfileAsync(int customerId, string email);
        // --------------------------------------------
    }
}
