using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enceja.Domain.Entities
{
    [Table("turma")]
    public class Turma
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        public ICollection<Aluno> Alunos { get; set; }

    }
}
