using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.DTOs.MenuDTOs;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/menu")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateMenuControllerAsync([FromBody] CreateMenuDto createMenuDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _menuService.CreateMenuServiceAsync(createMenuDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"{ex.Message}");
            }
        }

        [HttpGet("{menuId}")]
        public async Task<IActionResult> ReadMenuControllerAsync(int menuId)
        {
            var menuDto = await _menuService.ReadMenuServiceAsync(menuId);

            if (menuDto == null)
            {
                return NotFound();
            }

            return Ok(menuDto);
        }

        [HttpGet]
        [Route("menus")]
        public async Task<IActionResult> ReadAllMenusControllerAsync()
        {
            var menuDtos = await _menuService.ReadAllMenusServiceAsync();

            return Ok(menuDtos);
        }

        [HttpPut("update/{menuId}")]
        public async Task<IActionResult> UpdateMenuControllerAsync(int menuId, [FromBody] UpdateMenuDto updateMenuDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var success = await _menuService.UpdateMenuServiceAsync(menuId, updateMenuDto);

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

        [HttpDelete("delete/{menuId}")]
        public async Task<IActionResult> DeleteMenuControllerAsync(int menuId, [FromBody] DeleteMenuDto deleteMenuDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var success = await _menuService.DeleteMenuServiceAsync(menuId, deleteMenuDto.MenuName);

                if (!success)
                {
                    return NotFound();
                }

                return NoContent();
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
    }
}
