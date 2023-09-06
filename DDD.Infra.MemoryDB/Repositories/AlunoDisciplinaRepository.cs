using DDD.Infra.MemoryDB.Interfaces;
using DDD.Unimar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.MemoryDB.Repositories
{
    public class AlunoDisciplinaRepository : IAlunoDisciplinaRepository
    {
		private readonly APIContext _context;
		public AlunoDisciplinaRepository(APIContext context)
		{
			_context = context;
		}
        public List<AlunoDisciplina> GetAlunoDisciplina()
        {
            var list = _context.AlunoDisciplina.ToList();
            return list;
        }
        public AlunoDisciplina GetAlunoDisciplinaById(int id)
        {
            return _context.AlunoDisciplina.Find(id);
        }
        public void InsertAlunoDisciplina(AlunoDisciplina alunoDisciplina)
        {
			try
			{
				_context.AlunoDisciplina.Add(alunoDisciplina);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				//LOG
				throw;
			}
        }
    }
}
