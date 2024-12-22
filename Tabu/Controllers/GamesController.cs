using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tabu.DTOs.Games;
using Tabu.Services.Abstracts;

namespace Tabu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController(IGameService _service) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(GameCreateDto dto)
        {
            return Ok(await _service.AddAsync(dto));
        }
    }
}
