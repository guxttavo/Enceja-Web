using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enceja.Application.Entities;
using Enceja.Application.Interfaces;

namespace Enceja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {
        private readonly INotaService _notaService;

        public NotaController(INotaService notaService)
        {
            _notaService = notaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Nota>>> Get()
        {
            var notas = await _notaService.GetAllAsync();
            return Ok(notas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Nota>> Get(int id)
        {
            var nota = await _notaService.GetByIdAsync(id);
            if (nota == null)
                return NotFound();

            return Ok(nota);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Nota nota)
        {
            if (nota == null)
                return BadRequest("Nota inválida");

            await _notaService.AddAsync(nota);
            return CreatedAtAction(nameof(Get), new { id = nota.Id }, nota);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Nota nota)
        {
            //if (nota == null || nota.Id != id)
            //    return BadRequest("Dados inconsistentes");

            var notaExistente = await _notaService.GetByIdAsync(id);
            if (notaExistente == null)
                return NotFound();

            await _notaService.UpdateAsync(nota);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var nota = await _notaService.GetByIdAsync(id);
            if (nota == null)
                return NotFound();

            await _notaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
