using DDD.Unimar.Domain.SecretariaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.MemoryDB.Interfaces
{
    public interface IAlunoRepository
    {
        //CRUD
        public List<Aluno> GetAlunos(); //Read
        public Aluno GetAlunoById(int id); //Read
        public void InsertAluno(Aluno aluno); //Create
        public void UpdateAluno(Aluno aluno); //Update
        public void DeleteAluno(Aluno aluno); //Delete

    }
}
