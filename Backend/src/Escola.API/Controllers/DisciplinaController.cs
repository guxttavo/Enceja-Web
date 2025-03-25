using Microsoft.AspNetCore.Mvc;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Escola.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaController(IDisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Disciplina>>> Get()
        {
            var disciplinas = await _disciplinaService.GetAllAsync();
            return Ok(disciplinas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Disciplina>> Get(int id)
        {
            var disciplina = await _disciplinaService.GetByIdAsync(id);
            if (disciplina == null)
                return NotFound();

            return Ok(disciplina);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Disciplina disciplina)
        {
            if (disciplina == null)
                return BadRequest();

            await _disciplinaService.AddAsync(disciplina);
            return CreatedAtAction(nameof(Get), new { id = disciplina.Id }, disciplina);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Disciplina disciplina)
        {
            //if (disciplina == null || disciplina.Id != id)
            //    return BadRequest();

            await _disciplinaService.UpdateAsync(disciplina);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _disciplinaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
