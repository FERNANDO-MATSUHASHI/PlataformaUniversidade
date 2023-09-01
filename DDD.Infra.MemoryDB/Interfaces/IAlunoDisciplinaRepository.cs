using DDD.Unimar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.MemoryDB.Interfaces
{
    public interface IAlunoDisciplinaRepository
    {
        //CRUD
        public List<AlunoDisciplina> GetAlunoDisciplina(); //Read
        public AlunoDisciplina GetAlunoDisciplinaById(int id); //Read
        public void InsertAlunoDisciplina(AlunoDisciplina alunoDisciplina); //Create
    }
}
