using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enceja.Application.Entities
{
    [Table("nota")]
    public class Nota
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("id_aluno")]
        public Guid IdAluno { get; set; }

        [Column("id_disciplina")]
        public Guid IdDisciplina { get; set; }

        [Column("id_professor")]
        public Guid IdProfessor { get; set; }

        [Column("valor_nota")]
        public int ValorNota { get; set; }


        [ForeignKey(nameof(IdAluno))]
        public virtual Aluno Aluno { get; set; }

        [ForeignKey(nameof(IdDisciplina))]
        public virtual Disciplina Disciplina { get; set; }

        [ForeignKey(nameof(IdProfessor))]
        public virtual Professor Professor { get; set; }
    }
}
