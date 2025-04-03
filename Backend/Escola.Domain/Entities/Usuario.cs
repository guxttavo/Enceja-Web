using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enceja.Domain.Entities
{
    [Table("usuario")]
    public class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public string Senha { get; set; }

        public string Telefone { get; set; }

        public virtual string Endereco { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
