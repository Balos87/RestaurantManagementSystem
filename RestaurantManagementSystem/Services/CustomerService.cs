using RestaurantManagementSystem.Repository;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.DTOs.CustomerDTOs;
using RestaurantManagementSystem.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;

namespace RestaurantManagementSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerCreatedDto> CreateCustomerProfileAsync(CreateCustomerDto createCustomerDto)
        {
            var customer = new Customer()
            {
                FirstName = createCustomerDto.FirstName,
                LastName = createCustomerDto.LastName,
                PhoneNumber = createCustomerDto.PhoneNumber,
                Email = createCustomerDto.Email

            };
            
            await _customerRepository.CreateCustomerProfileAsync(customer);

            var customerCreatedDto = new CustomerCreatedDto()
            {
                CustomerId = customer.CustomerId,
            };

            return customerCreatedDto;

        }

        public async Task<CustomerProfileDto> ReadCustomerProfileAsync(int customerId)
        {
            var customer = await _customerRepository.ReadCustomerProfileAsync(customerId);

            if (customer == null)
            {
                return null;
            }

            var customerProfileDto = new CustomerProfileDto()
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };

            return customerProfileDto;
        }

        public async Task<CustomerProfileUpdatedDto> UpdateCustomerProfileAsync(UpdateCustomerProfileDto updateCustomerProfileDto)
        {
            var customer = await _customerRepository.ReadCustomerProfileAsync(updateCustomerProfileDto.CustomerId) ?? throw new ArgumentException("No customer was found");
            customer.FirstName = updateCustomerProfileDto.FirstName;
            customer.LastName = updateCustomerProfileDto.LastName;
            customer.Email = updateCustomerProfileDto.Email;
            customer.PhoneNumber = updateCustomerProfileDto.PhoneNumber;

            await _customerRepository.UpdateCustomerProfileAsync(customer);

            return new CustomerProfileUpdatedDto();
        }

        public async Task<CustomerDeletedDto> DeleteCustomerProfileAsync(DeleteCustomerProfileDto deleteCustomerProfileDto)
        {
            var customer = new Customer()
            {
                CustomerId = deleteCustomerProfileDto.CustomerId,
                Email = deleteCustomerProfileDto.Email
            };

            var successfullyDeleted = await _customerRepository.DeleteCustomerProfileAsync(customer);

            if (!successfullyDeleted)
            {
                return null;
            }
          
            return new CustomerDeletedDto();
        }
    }
}
