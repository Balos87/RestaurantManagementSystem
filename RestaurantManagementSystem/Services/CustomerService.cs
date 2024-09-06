using RestaurantManagementSystem.Repository;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.DTOs.CustomerDTOs;
using RestaurantManagementSystem.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;
using RestaurantManagementSystem.DTOs.Customers;

namespace RestaurantManagementSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task CreateCustomerProfileAsync(CreateCustomerDto createCustomerDto)
        {
            var customer = new Customer()
            {
                FirstName = createCustomerDto.FirstName,
                LastName = createCustomerDto.LastName,
                PhoneNumber = createCustomerDto.PhoneNumber,
                Email = createCustomerDto.Email
            };

            await _customerRepository.CreateCustomerRepoAsync(customer);
        }

        public async Task<CustomerSingleDto> ReadCustomerProfileAsync(int customerId)
        {
            var customer = await _customerRepository.ReadCustomerRepoAsync(customerId);

            if (customer == null)
            {
                return null;
            }

            var customerDto = new CustomerSingleDto()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };

            return customerDto;
        }

        public async Task<IEnumerable<CustomerDto>> ReadAllCustomersAsync()
        {
            var customers = await _customerRepository.ReadAllCustomersRepoAsync();

            var customerViewModels = customers.Select(customer => new CustomerDto()
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            });

            return customerViewModels;
        }

        public async Task<bool> UpdateCustomerProfileAsync(int customerId, UpdateCustomerProfileDto updateCustomerProfileDto)
        {
            var customer = await _customerRepository.ReadCustomerRepoAsync(customerId);
            if (customer == null)
            {
                return false;
            }

            customer.FirstName = updateCustomerProfileDto.FirstName;
            customer.LastName = updateCustomerProfileDto.LastName;
            customer.Email = updateCustomerProfileDto.Email;
            customer.PhoneNumber = updateCustomerProfileDto.PhoneNumber;

            await _customerRepository.UpdateCustomerRepoAsync(customer);

            return true;
        }

        public async Task<bool> DeleteCustomerProfileAsync(int customerId, string email)
        {
            var customer = new Customer()
            {
                CustomerId = customerId,
                Email = email
            };

            return await _customerRepository.DeleteCustomerRepoAsync(customer);
        }
    }
}
