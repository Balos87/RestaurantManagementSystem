using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository.IRepository
{
    public interface ICustomerRepository
    {
        // ------ CRUD Operations for Customers -------
        Task<Customer> CreateCustomerProfileAsync(Customer customer); // Create
        Task<Customer> ReadCustomerProfileAsync(int customerId); // Read
        Task UpdateCustomerProfileAsync(Customer customer); // Update
        Task<bool> DeleteCustomerProfileAsync(Customer customer); // Delete
        // --------------------------------------------
    }
}
