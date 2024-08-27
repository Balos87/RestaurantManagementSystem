using RestaurantManagementSystem.Repository;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Repository.IRepository;
using RestaurantManagementSystem.DTOs.CustomerDTOs;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerProfileDto> CreateCustomerAsync(CreateCustomerDto createCustomerDto)
        {
            //var createCustomer = new CreateCustomerDto()
            //{
            //    FirstName = createCustomerDto.FirstName,
            //    LastName = createCustomerDto.FirstName,
            //    PhoneNumber = createCustomerDto.PhoneNumber,
            //    Email = createCustomerDto.Email
            //};

            var customer = new Customer()
            {
                FirstName = createCustomerDto.FirstName,
                LastName = createCustomerDto.LastName,
                PhoneNumber = createCustomerDto.PhoneNumber,
                Email = createCustomerDto.Email

            };

            await _customerRepository.AddCustomerAsync(customer);

            var customerProfileDto = new CustomerProfileDto()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                Email = customer.Email
            };

            return customerProfileDto;

        }

        public async Task<CustomerProfileDto> GetCustomerProfileAsync(int customerId)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(customerId);

            if (customer == null)
            {
                return null;
            }

            var customerProfileDto = new CustomerProfileDto()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };

            return customerProfileDto;
        }

    }
}
