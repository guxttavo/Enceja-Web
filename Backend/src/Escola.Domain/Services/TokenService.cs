//using Escola.Domain.Entities;
//using Microsoft.IdentityModel.Tokens;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using System;

//namespace Escola.Domain.Services
//{
//    public class TokenService
//    {
//        public string Generate(Usuario usuario)
//        {
//            var handler = new JwtSecurityTokenHandler();
//            var key = Encoding.ASCII.GetBytes("aaaaaaaa");

//            var credentials = new SigningCredentials(
//                new SymmetricSecurityKey(key),
//                SecurityAlgorithms.HmacSha256Signature
//            );

//            //var claims = new[]
//            //{
//            //    new Claim(JwtRegisteredClaimNames.Sub, usuario.Id.ToString()),
//            //    new Claim(JwtRegisteredClaimNames.UniqueName, usuario.Nome),
//            //    new Claim(JwtRegisteredClaimNames.Email, usuario.Email),
//            //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
//            //};

//            //var tokenDescriptor = new SecurityTokenDescriptor
//            //{
//            //    Subject = new ClaimsIdentity(claims),
//            //    SigningCredentials = credentials,
//            //    Expires = DateTime.UtcNow.AddHours(2)
//            //};

//            var token = handler.CreateToken(tokenDescriptor);
//            return handler.WriteToken(token);
//        }
//    }
//}
