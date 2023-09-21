using DDD.Unimar.Domain.SecretariaContext;
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
    }
}