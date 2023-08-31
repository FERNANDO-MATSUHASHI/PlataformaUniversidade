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
        public List<AlunoDisciplina> GetAlunos_Disciplina(); //Read
        public Aluno GetAluno_DisciplinaById(int id); //Read
        public void InsertAlunoDisciplina(AlunoDisciplina aluno_Disciplina); //Create
    }
}