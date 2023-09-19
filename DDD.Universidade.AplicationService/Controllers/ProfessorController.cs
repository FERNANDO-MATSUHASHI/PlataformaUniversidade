using DDD.Infra.SqlServerFisico.Interfaces;
using DDD.Unimar.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Universidade.AplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        readonly IProfessorRepository _professorRepository;
        public ProfessorController(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        [HttpGet]
        public ActionResult<List<Professor>> Get()
        {
            return Ok(_professorRepository.GetProfessores());
        }

        [HttpGet("{id}")]
        public ActionResult<Professor> GetById(int id)
        {
            return Ok(_professorRepository.GetProfessorById(id));
        }

        [HttpPost]
        public ActionResult<Professor> CreateProfessor(Professor professor)
        {
            //Validação
            if (professor.Nome.Length < 3 || professor.Nome.Length > 30)
            {
                return BadRequest("Nome não pode ser menor que 3 ou maior que 30 caracteres");
            }
            _professorRepository.InsertProfessor(professor);
            return CreatedAtAction(nameof(GetById), new { Id = professor.Id }, professor);
        }

        [HttpPut]
        public ActionResult<Professor> UpdateProfessor(Professor professor)
        {
            try
            {
                if (professor == null)
                {
                    return BadRequest();
                }
                _professorRepository.UpdateProfessor(professor);
                return Ok("Professor Alterado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Professor professor)
        {
            try
            {
                if (professor == null)
                {
                    return BadRequest();
                }
                _professorRepository.DeleteProfessor(professor);
                return Ok("Professor deletado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
