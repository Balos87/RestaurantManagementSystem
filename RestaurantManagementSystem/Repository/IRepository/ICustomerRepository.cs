using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository.IRepository
{
    public interface ICustomerRepository
    {
        // ------ CRUD Operations for Customers -------
        Task<Customer> CreateCustomerRepoAsync(Customer customer); // Create
        Task<Customer> ReadCustomerRepoAsync(int customerId); // Read
        Task<IEnumerable<Customer>> ReadAllCustomersRepoAsync();
        Task UpdateCustomerRepoAsync(Customer customer); // Update
        Task<bool> DeleteCustomerRepoAsync(Customer customer); // Delete
        // --------------------------------------------
    }
}
