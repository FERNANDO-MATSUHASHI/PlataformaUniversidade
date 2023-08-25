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
    public class DisciplinaRepository : IDisciplinaRepository
    {
        public DisciplinaRepository()
        {
            using (var context = new APIContext())
            {
                var disciplinas = new List<Disciplina>()
                {
                    new Disciplina
                    {
                        Nome = "Programação I",
                        Disponivel = true,
                        Valor = 100,
                        Ead = true                
                    },
                    new Disciplina
                    {
                        Nome = "Banco de Dados",
                        Disponivel = false,
                        Valor = 100,
                        Ead = true
                    }
                };

                context.Disciplinas.AddRange(disciplinas);
                context.SaveChanges();
            }
        }

        public List<Disciplina> GetDisciplina()
        {
            using (var context = new APIContext())
            {
                var list = context.Disciplinas.ToList();
                return list;
            }
        }
    }
}
