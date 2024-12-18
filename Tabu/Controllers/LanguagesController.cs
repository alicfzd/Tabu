using FluentValidation.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tabu.DAL;
using Tabu.DTOs.Languages;
using Tabu.Services.Abstracts;

namespace Tabu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController(ILanguageService _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Post(LanguageCreateDto dto)
        {
            await _service.Create(dto);
            return Created();
        }
        [HttpGet("{code}")]
        public async Task<IActionResult> GetByCode(string code)
        {

                var language = await _service.GetByCode(code);
                return Ok(language);

        }

        [HttpPut("{code}")]
        public async Task<IActionResult> Put(string code, LanguageCreateDto dto)
        {
           
           await _service.Update(code, dto);
           return NoContent();
  
        }

        [HttpDelete("{code}")]
        public async Task<IActionResult> Delete(string code)
        {

            await _service.Delete(code);
            return NoContent();
            
        }
    }
}
