using DDD.Unimar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SqlServerFisico.Interfaces
{
    public interface IProfessorRepository
    {
        //CRUD
        public List<Professor> GetProfessores(); //Read
        public Professor GetProfessorById(int id); //Read
        public void InsertProfessor(Professor professor); //Create
        public void UpdateProfessor(Professor professor); //Update
        public void DeleteProfessor(Professor professor); //Delete
    }
}
