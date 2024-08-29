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

        public async Task<Customer> CreateCustomerProfileAsync(Customer customer)
        {
            try
            {
                await _context.Customers.AddAsync(customer);
                await _context.SaveChangesAsync();
                return customer;
            }
            catch (Exception)
            {
                throw new Exception("Error when adding data");
            }
        }

        public async Task<Customer> ReadCustomerProfileAsync(int customerId)
        {
            try
            {
                return await _context.Customers.SingleOrDefaultAsync(c => c.CustomerId == customerId);
            }
            catch (Exception)
            {
                throw new Exception("Error when fetching data");
            }
        }

        public async Task UpdateCustomerProfileAsync(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();          
        }

        public async Task<bool> DeleteCustomerProfileAsync(Customer customer)
        {
            var customerToDelete = await _context.Customers
                .FirstOrDefaultAsync(c => c.CustomerId == customer.CustomerId && c.Email == customer.Email);

            if (customerToDelete == null)
            {
                return false;
            }

            _context.Customers.Remove(customerToDelete);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
