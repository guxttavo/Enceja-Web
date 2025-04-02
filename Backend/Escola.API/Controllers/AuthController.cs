using Enceja.Domain.Services;
using Enceja.Appplication.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Enceja.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDTO request)
        {
            if (request.Email == "admin" && request.PasswordHash == "1234")
            {
                var token = _tokenService.GenerateToken(request.Email, "Admin");
                return Ok(new { Token = token });
            }

            return Unauthorized(new { Message = "Usuário ou senha inválidos" });
        }
    }
}
