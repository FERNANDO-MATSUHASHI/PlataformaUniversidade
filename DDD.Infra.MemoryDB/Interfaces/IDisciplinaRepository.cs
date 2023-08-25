using DDD.Unimar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.MemoryDB.Interfaces
{
    public interface IDisciplinaRepository
    {
        public List<Disciplina> GetDisciplina();
    }
}
