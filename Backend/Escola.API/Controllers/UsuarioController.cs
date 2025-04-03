using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enceja.Domain.Entities;
using Enceja.Domain.Interfaces;
using System;
using Microsoft.AspNetCore.Identity;

namespace Enceja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IPasswordHasher<Usuario> _passwordHasher;

        public UsuarioController(IUsuarioService usuarioService, IPasswordHasher<Usuario> passwordHasher)
        {
            _usuarioService = usuarioService;
            _passwordHasher = passwordHasher;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> Get()
        {
            var usuarios = await _usuarioService.GetAllAsync();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            var usuario = await _usuarioService.GetByIdAsync(id);
            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest("Usuário inválido");

            usuario.Senha = _passwordHasher.HashPassword(usuario, usuario.Senha);
            await _usuarioService.AddAsync(usuario);
            return CreatedAtAction(nameof(Get), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Usuario usuario)
        {
            var usuarioExistente = await _usuarioService.GetByIdAsync(id);
            if (usuarioExistente == null)
                return NotFound();

            usuario.Senha = _passwordHasher.HashPassword(usuario, usuario.Senha);
            await _usuarioService.UpdateAsync(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var usuario = await _usuarioService.GetByIdAsync(id);
            if (usuario == null)
                return NotFound();

            await _usuarioService.DeleteAsync(id);
            return NoContent();
        }
    }
}
