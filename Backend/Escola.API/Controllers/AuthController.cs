using Enceja.Domain.Services;
using Enceja.Appplication.DTOs;
using Enceja.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Enceja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;
        private readonly IUsuarioService _usuarioService;

        public AuthController(TokenService tokenService, IUsuarioService usuarioService)
        {
            _tokenService = tokenService;
            _usuarioService = usuarioService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO request)
        {
            var usuario = await _usuarioService.GetByEmailAsync(request.Email);

            if (usuario == null || usuario.Senha != request.PasswordHash)
            {
                return Unauthorized(new { Message = "Usuário ou senha inválidos" });
            }

            var token = _tokenService.GenerateToken(usuario.Email, "User");
            return Ok(new { Token = token });
        }
    }
}
