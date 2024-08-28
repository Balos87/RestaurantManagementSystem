using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Services;
using RestaurantManagementSystem.DTOs.CustomerDTOs;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("Customer Profile")]
        public async Task<IActionResult> GetProfile(int customerId)
        {
            var profileDto = await _customerService.GetCustomerProfileAsync(customerId);

            if (profileDto == null)
            {
                return NotFound();
            }

            return Ok(profileDto);
        }

        [HttpPost]
        [Route("Create Customer")]
        public async Task<IActionResult> CreateCustomerAsync([FromBody] CreateCustomerDto createCustomerDto)
        {
            var customerCreatedDto = await _customerService.CreateCustomerAsync(createCustomerDto);

            if (customerCreatedDto == null)
            {
                return NotFound();
            }

            return Ok(customerCreatedDto);
        }

    }
}


//[HttpGet]
//[Route("profile")]
//public async Task<ActionResult<Customer>> GetProfile(int customerId)
//{
//    var profileDto = await _customerService.GetCustomerProfileAsync(customerId);

//    if (profileDto == null)
//    {
//        return NotFound();
//    }

//    return Ok(profileDto);
//}