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

        public async Task<Customer> CreateCustomerRepoAsync(Customer customer)
        {
            try
            {
                await _context.Customers.AddAsync(customer);
                await _context.SaveChangesAsync();
                return customer;
            }
            catch (Exception)
            {
                throw new Exception("Could not add data to database.");
            }
        }

        public async Task<Customer> ReadCustomerRepoAsync(int customerId)
        {
            try
            {
                return await _context.Customers.SingleOrDefaultAsync(c => c.CustomerId == customerId);
            }
            catch (Exception)
            {
                throw new Exception("Could not fetch data from database.");
            }
        }

        public async Task<IEnumerable<Customer>> ReadAllCustomersRepoAsync()
        {
            try
            {
                return await _context.Customers.ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Could not fetch data from database.");
            }
        }

        public async Task UpdateCustomerRepoAsync(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();          
        }

        public async Task<bool> DeleteCustomerRepoAsync(Customer customer)
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
