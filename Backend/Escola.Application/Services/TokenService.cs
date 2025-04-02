using Enceja.Domain.Helpers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Enceja.Domain.Services
{
    public class TokenService
    {
        private readonly string _secretKey;

        public TokenService()
        {
            _secretKey = JwtSecretKey.GenerateSecretKey(); 
        }

        public string GenerateToken(string username, string role)
        {
            var keyBytes = JwtSecretKey.GetKeyBytes(_secretKey);
            var key = new SymmetricSecurityKey(keyBytes);
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role)
            };

            var token = new JwtSecurityToken(
                issuer: "Enceja.API",
                audience: "Enceja.API",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
