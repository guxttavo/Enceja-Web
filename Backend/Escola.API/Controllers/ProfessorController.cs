using Microsoft.AspNetCore.Mvc;
using Enceja.Application.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enceja.Application.Interfaces;

namespace Enceja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>> Get()
        {
            var professores = await _professorService.GetAllAsync();
            return Ok(professores);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Professor>> Get(int id)
        {
            var professor = await _professorService.GetByIdAsync(id);
            if (professor == null)
                return NotFound();
            return Ok(professor);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Professor professor)
        {
            if (professor == null)
                return BadRequest();

            await _professorService.AddAsync(professor);
            return CreatedAtAction(nameof(Get), new { id = professor.Id }, professor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Professor professor)
        {
            //if (professor == null || professor.Id != id)
            //    return BadRequest();

            await _professorService.UpdateAsync(professor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var professor = await _professorService.GetByIdAsync(id);
            if (professor == null)
                return NotFound();

            await _professorService.DeleteAsync(id);
            return NoContent();
        }
    }
}
