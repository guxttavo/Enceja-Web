using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Escola.Domain.Entities
{
    [Table("disciplina")]
    public class Disciplina
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [JsonIgnore]
        public ICollection<Professor_Disciplina> Professores_Disciplinas { get; set; }
    }
}
