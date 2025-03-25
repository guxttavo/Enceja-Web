using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Escola.Domain.Entities
{
    [Table("usuario")]
    public class Usuario : IdentityUser<Guid>
    {
        [Column("nome")]
        public override string UserName { get; set; }

        [Column("email")]
        public override string Email { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("senha")]
        public override string PasswordHash { get; set; }

        [Column("telefone")]
        public override string PhoneNumber { get; set; }

        [Column("endereco")]
        public virtual string Endereco { get; set; }

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
