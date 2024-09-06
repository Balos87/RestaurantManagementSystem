using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.DTOs.CustomerDTOs;
using RestaurantManagementSystem.DTOs.TableDTOs;
using RestaurantManagementSystem.Repository;
using RestaurantManagementSystem.Services;
using RestaurantManagementSystem.Services.IServices;

namespace RestaurantManagementSystem.Controllers
{
    [Route("api/table")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateTableAsync([FromBody] CreateTableDto createTableDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _tableService.CreateTableAsync(createTableDto);

            return NoContent();
        }

        [HttpGet]
        [Route("{tableId}")]
        public async Task<IActionResult> ReadTableInformationAsync(int tableId)
        {
            var tableInformationDto = await _tableService.ReadTableInformationAsync(tableId);

            if (tableInformationDto == null)
            {
                return NotFound();
            }
            return Ok(tableInformationDto);
        }

        [HttpGet]
        [Route("tables")]
        public async Task<IActionResult> ReadAllTablesControllerAsync()
        {
            var tableDtos = await _tableService.ReadAllTablesAsync();

            if (!tableDtos.Any())
            {
                return NotFound();
            }

            return Ok(tableDtos);
        }

        [HttpPut("update/{tableId}")]
        public async Task<IActionResult> UpdateTableControllerAsync(int tableId, [FromBody] UpdateTableDto updateTableDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var success = await _tableService.UpdateTableInformationServiceAsync(tableId, updateTableDto);

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

        [HttpDelete("delete/{tableId}")]
        public async Task<IActionResult> DeleteTableControllerAsync(int tableId, [FromBody] DeleteTableDto deleteTableDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var success = await _tableService.DeleteTableServiceAsync(tableId, deleteTableDto);

                if (!success)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

    }
}
