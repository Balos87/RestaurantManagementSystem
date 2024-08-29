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

        [HttpPost]
        [Route("CreateCustomerProfile")]
        public async Task<IActionResult> CreateCustomerAsync([FromBody] CreateCustomerDto createCustomerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var customerCreatedDto = await _customerService.CreateCustomerProfileAsync(createCustomerDto);
                return CreatedAtAction(nameof(ReadCustomerProfileAsync), new { name = customerCreatedDto.CustomerId }, customerCreatedDto);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error while trying to create the customer");
            }
        }

        [HttpGet]
        [Route("ReadCustomerProfile")]
        public async Task<IActionResult> ReadCustomerProfileAsync(int customerId)
        {
            var profileDto = await _customerService.ReadCustomerProfileAsync(customerId);

            if (profileDto == null)
            {
                return NotFound();
            }

            return Ok(profileDto);
        }

        [HttpPut]
        [Route("UpdateCustomerProfile")]
        public async Task<IActionResult> UpdateCustomerProfileAsync([FromBody] UpdateCustomerProfileDto updateCustomerProfileDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var customerProfileUpdated = await _customerService.UpdateCustomerProfileAsync(updateCustomerProfileDto);

                if (customerProfileUpdated == null)
                {
                    return NotFound("No custmer was found to edit.");
                }

                return Ok(customerProfileUpdated);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error when trying to update customer.");
            }
        }

        [HttpDelete]
        [Route("DeleteCustomerProfile")]
        public async Task <IActionResult> DeleteCustomerProfileAsync([FromBody] DeleteCustomerProfileDto deleteCustomerProfileDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var customerDeletedDto = await _customerService.DeleteCustomerProfileAsync(deleteCustomerProfileDto);

                if (customerDeletedDto == null)
                {
                    return NotFound("No customer found with these parameters");
                }

                return Ok(customerDeletedDto);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error when trying to delete customer");
            }
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