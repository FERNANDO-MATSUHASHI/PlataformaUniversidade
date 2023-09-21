using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Unimar.Domain.SecretariaContext
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int AlunoId{ get; set; }

        public Aluno Aluno { get; set; }
        public int DisciplicaId { get; set; }
        
        public Disciplina Disciplina { get; set; }
        public DateTime Data { get; set; }
    }
}
