using DDD.Unimar.Domain.UserManagementContext;
using DDD.Unimar.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Unimar.Domain.SecretariaContext
{
    public class Aluno : User
    {
        public IList<Matricula> Matriculas { get; set; }

        //public List<Disciplina> Disciplinas { get; set; }
    }
}
