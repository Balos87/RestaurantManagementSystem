using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.DTOs.DishDTOs;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/dish")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;

        public DishController(IDishService dishService)
        {
            _dishService = dishService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateDishControllerAsync([FromBody] CreateDishDto createDishDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _dishService.CreateDishAsync(createDishDto);
                return Ok();
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("{dishId}")]
        public async Task<IActionResult> ReadDishControllerAsync(int dishId)
        {
            var dishDto = await _dishService.ReadDishAsync(dishId);

            if (dishDto == null)
            {
                return NotFound();
            }

            return Ok(dishDto);
        }

        [HttpGet]
        [Route("dishes")]
        public async Task<IActionResult> ReadAllDishesControllerAsync()
        {
            var dishes = await _dishService.ReadAllDishesAsync();
            return Ok(dishes);
        }

        [HttpPut("link-to-menu/{dishId}/{menuId}")]
        public async Task<IActionResult> LinkDishToMenuControllerAsync(int dishId, int menuId)
        {
            try
            {
                await _dishService.LinkDishToMenuAsync(dishId, menuId);
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

        [HttpPut("unlink-from-menu/{dishId}")]
        public async Task<IActionResult> UnlinkDishFromMenuControllerAsync(int dishId)
        {
            try
            {
                await _dishService.UnlinkDishFromMenuAsync(dishId);
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

        [HttpPut("update/{dishId}")]
        public async Task<IActionResult> UpdateDishControllerAsync(int dishId, [FromBody] UpdateDishDto updateDishDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var success = await _dishService.UpdateDishAsync(dishId, updateDishDto);

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

        [HttpDelete("delete/{dishId}")]
        public async Task<IActionResult> DeleteDishControllerAsync(int dishId, [FromBody] DeleteDishDto deleteDishDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var success = await _dishService.DeleteDishAsync(dishId, deleteDishDto.DishName);

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
