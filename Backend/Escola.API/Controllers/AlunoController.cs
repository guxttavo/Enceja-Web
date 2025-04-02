using Enceja.Application.Interfaces;
using Enceja.Application.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Enceja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> Get()
        {
            var alunos = await _alunoService.GetAllAsync();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> Get(int id)
        {
            var aluno = await _alunoService.GetByIdAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return Ok(aluno);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Aluno aluno)
        {
            if (aluno == null)
            {
                return BadRequest();
            }
            await _alunoService.AddAsync(aluno);
            return CreatedAtAction(nameof(Get), new { id = aluno.Id }, aluno);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Aluno aluno)
        {
            await _alunoService.UpdateAsync(aluno);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var aluno = await _alunoService.GetByIdAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }
            await _alunoService.DeleteAsync(id);
            return NoContent();
        }
    }
}