using DDD.Unimar.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Unimar.Domain.Entities
{
    public class AlunoDisciplina
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public int IdDisciplina { get; set; }
    }
}
