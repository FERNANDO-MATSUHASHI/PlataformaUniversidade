using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Infra.MemoryDB.Interfaces;
using DDD.Unimar.Domain.Entities;

namespace DDD.Infra.MemoryDB.Repositories
{
    public class Aluno_DisciplinaRepository : IAluno_DisciplinaRepository
    {
        private readonly APIContext _context;

        // Dependency Injection
        public Aluno_DisciplinaRepository(APIContext context)
        {
            _context = context;
        }

        public List<AlunoDisciplina> GetAlunos_Disciplina()
        {
            throw new NotImplementedException();
        }
        public AlunoDisciplina GetAluno_DisciplinaById(int id)
        {
            return _context.Aluno_Disciplina.Find(id);
        }

        public void InsertAlunoDisciplina(AlunoDisciplina aluno_Disciplina)
        {
            try
            {
                _context.Aluno_Disciplina.Add(aluno_Disciplina);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                //LOG
                throw;
            }
        }
    }

    public interface IAluno_DisciplinaRepository
    {
    }
}
