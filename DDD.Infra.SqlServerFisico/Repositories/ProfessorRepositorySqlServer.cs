using DDD.Infra.SqlServerFisico.Interfaces;
using DDD.Unimar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServerFisico.Repositories
{
    public class ProfessorRepositorySqlServer : IProfessorRepository
    {
        private readonly SqlServerContext _context;

        // Dependency Injection
        public ProfessorRepositorySqlServer(SqlServerContext context)
        {
            _context = context;
        }

        public List<Professor> GetProfessores()
        {
            var list = _context.Professores.Include(x => x.Disciplinas).ToList();
            return list;
        }

        public Professor GetProfessorById(int id)
        {
            return _context.Professores.Find(id);
        }

        public void InsertProfessor(Professor professor)
        {
            try
            {
                _context.Professores.Add(professor);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                //LOG
                throw;

            }
        }

        public void UpdateProfessor(Professor professor)
        {
            try
            {
                _context.Entry(professor).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                //LOG
                throw;
            }
        }
        public void DeleteProfessor(Professor professor)
        {
            try
            {
                _context.Set<Professor>().Remove(professor);
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
