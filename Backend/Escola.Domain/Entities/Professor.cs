﻿using Enceja.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Enceja.Domain.Entities
{
    [Table("professor")]
    public class Professor : Usuario
    {
        [JsonIgnore]
        public ICollection<Professor_Disciplina> Professores_Disciplinas { get; set; }

    }
}
