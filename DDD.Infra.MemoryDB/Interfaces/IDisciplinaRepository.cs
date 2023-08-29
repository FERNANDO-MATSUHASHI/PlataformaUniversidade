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
        //CRUD
        public List<Disciplina> GetDisciplina();

        public Disciplina GetDisciplinaById(int id); //Read
        public void InsertDisciplina(Disciplina disciplina); //Create
        public void UpdateDIsciplina(Disciplina disciplina); //Update
        public void DeleteDisciplina(Disciplina disciplina); //Delete
    }
}
