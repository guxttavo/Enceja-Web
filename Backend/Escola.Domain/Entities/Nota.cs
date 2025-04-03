using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enceja.Domain.Entities
{
    [Table("nota")]
    public class Nota
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("id_aluno")]
        public int IdAluno { get; set; }

        [Column("id_disciplina")]
        public int IdDisciplina { get; set; }

        [Column("id_professor")]
        public int IdProfessor { get; set; }

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
