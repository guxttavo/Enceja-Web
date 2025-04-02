using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Enceja.Domain.Entities
{
    [Table("professor_disciplina")]
    public class Professor_Disciplina
    {
        [Column("id_professor")]
        public Guid IdProfessor { get; set; }

        [Column("id_disciplina")]
        public Guid IdDisciplina { get; set; }

        [ForeignKey(nameof(IdProfessor))]
        public Professor Professor { get; set; }

        [ForeignKey(nameof(IdDisciplina))]
        public Disciplina Disciplina { get; set; }

    }
}
