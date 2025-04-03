using Enceja.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enceja.Domain.Entities
{
    [Table("aluno")]
    public class Aluno : Usuario
    {
        [Column("id_turma")]
        public int IdTurma { get; set; }

        [Column("matricula")]
        public int Matricula { get; set; }

        public ICollection<Nota> Notas { get; set; }

        [ForeignKey(nameof(IdTurma))]
        public Turma Turma { get; set; }
    }
}
