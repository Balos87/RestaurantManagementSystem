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
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCustomerControllerAsync([FromBody] CreateCustomerDto createCustomerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _customerService.CreateCustomerProfileAsync(createCustomerDto);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> ReadCustomerControllerAsync(int customerId)
        {
            var customerDto = await _customerService.ReadCustomerProfileAsync(customerId);

            if (customerDto == null)
            {
                return NotFound();
            }

            return Ok(customerDto);
        }

        [HttpGet]
        [Route("customers")]
        public async Task<IActionResult> ReadAllCustomersControllerAsync()
        {
            var customerDto = await _customerService.ReadAllCustomersAsync();

            if (!customerDto.Any())
            {
                return NotFound();
            }

            return Ok(customerDto);
        }

        [HttpPut("update/{customerId}")]
        public async Task<IActionResult> UpdateCustomerControllerAsync(int customerId, [FromBody] UpdateCustomerProfileDto updateCustomerProfileDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var customerUpdated = await _customerService.UpdateCustomerProfileAsync(customerId, updateCustomerProfileDto);

                if (!customerUpdated)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("delete/{customerId}")]
        public async Task<IActionResult> DeleteCustomerControllerAsync(int customerId, [FromBody] DeleteCustomerProfileDto deleteCustomerProfileDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var success = await _customerService.DeleteCustomerProfileAsync(customerId, deleteCustomerProfileDto.Email);

                if (!success)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
