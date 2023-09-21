using DDD.Unimar.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Unimar.Domain.SecretariaContext
{
    public class Professor : User
    {

        public List<Disciplina> Disciplinas { get; set; }
    }
}
