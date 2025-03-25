using Escola.Domain.DTO;
using Escola.Domain.Entities;
using Escola.Domain.Interfaces.Services;
using Escola.Domain.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Escola.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        //private readonly TokenService _tokenService;
        private readonly IUsuarioService _usuarioService;

        public AuthController(/*TokenService tokenService,*/ IUsuarioService usuarioService)
        {
            //_tokenService = tokenService;
            _usuarioService = usuarioService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            var usuarioCpf = await _usuarioService.GetByCpfAsync(login.Cpf);
            var hashedPassword = new PasswordHasher<Usuario>()
                .HashPassword(  , login.PasswordHash);
            //var usuario = await _usuarioService.BuscarUsuarioPorEmailAsync(model.Email);

            //if (usuario == null || usuario.Senha != model.Senha)
            //    return Unauthorized(new { message = "E-mail ou senha inválidos." });

            //var token = _tokenService.Generate(usuario);

            //return Ok(new { token, usuario = new { usuario.Id, usuario.Nome } });
            return null;
        }
    }
}
