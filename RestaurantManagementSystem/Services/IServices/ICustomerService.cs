using RestaurantManagementSystem.DTOs.CustomerDTOs;

namespace RestaurantManagementSystem.Services.IServices
{
    public interface ICustomerService
    {
        // ------ CRUD Operations for Customers -------
        Task<CustomerCreatedDto> CreateCustomerProfileAsync(CreateCustomerDto createCustomerDto);
        Task<CustomerProfileDto> ReadCustomerProfileAsync(int customerId);
        Task<CustomerProfileUpdatedDto> UpdateCustomerProfileAsync(UpdateCustomerProfileDto updateCustomerProfileDto);
        Task<CustomerDeletedDto> DeleteCustomerProfileAsync(DeleteCustomerProfileDto deleteCustomerProfileDto);
        // --------------------------------------------
    }
}
