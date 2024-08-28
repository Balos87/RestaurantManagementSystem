using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly RestaurantManagementSystemContext _context;

        public CustomerRepository(RestaurantManagementSystemContext context)
        {
            _context = context;
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            return await _context.Customers.SingleOrDefaultAsync(c => c.CustomerId == customerId);
        }


    }
}
