using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces;

namespace Enceja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly ITurmaService _turmaService;

        public TurmaController(ITurmaService turmaService)
        {
            _turmaService = turmaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turma>>> Get()
        {
            var turmas = await _turmaService.GetAllAsync();
            return Ok(turmas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Turma>> Get(int id)
        {
            var turma = await _turmaService.GetByIdAsync(id);
            if (turma == null)
                return NotFound();

            return Ok(turma);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Turma turma)
        {
            if (turma == null)
                return BadRequest("Turma inválida");

            await _turmaService.AddAsync(turma);
            return CreatedAtAction(nameof(Get), new { id = turma.Id }, turma);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Turma turma)
        {
            //if (turma == null || turma.Id != id)
            //    return BadRequest("Dados inconsistentes");

            var turmaExistente = await _turmaService.GetByIdAsync(id);
            if (turmaExistente == null)
                return NotFound();

            await _turmaService.UpdateAsync(turma);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var turma = await _turmaService.GetByIdAsync(id);
            if (turma == null)
                return NotFound();

            await _turmaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
