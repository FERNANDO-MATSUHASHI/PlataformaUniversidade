using DDD.Unimar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infra.MemoryDB
{
    public class APIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "UniversidadeDb");
        }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Disciplina> Disciplinas { get; set; }

        public DbSet<AlunoDisciplina> AlunoDisciplina { get; set; }


    }
}