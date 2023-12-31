﻿using DDD.Infra.MemoryDB.Interfaces;
using DDD.Unimar.Domain.SecretariaContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.MemoryDB.Repositories
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private readonly APIContext _context;

        // Dependency Injection
        public DisciplinaRepository(APIContext context)
        {
            _context = context;
        }        
        public List<Disciplina> GetDisciplina()
        {
            using (var context = new APIContext())
            {
                var list = _context.Disciplinas.ToList();
                return list;
            }
        }
        public Disciplina GetDisciplinaById(int id)
        {
            return _context.Disciplinas.Find(id);
        }
        public void InsertDisciplina(Disciplina disciplina)
        {
            try
            {
                _context.Disciplinas.Add(disciplina);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                // LOG
                throw;
            }
        }
        public void UpdateDIsciplina(Disciplina disciplina)
        {
            try
            {
                _context.Entry(disciplina).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                // LOG
                throw;
            }
        }
        public void DeleteDisciplina(Disciplina disciplina)
        {
            try
            {
                _context.Set<Disciplina>().Remove(disciplina);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                // LOG
                throw;
            }
        }

    }
}
