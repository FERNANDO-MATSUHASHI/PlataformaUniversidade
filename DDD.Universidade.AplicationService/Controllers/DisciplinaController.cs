using DDD.Infra.MemoryDB.Interfaces;
using DDD.Infra.MemoryDB.Repositories;
using DDD.Unimar.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Universidade.AplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        readonly IDisciplinaRepository _disciplinaRepository;
        public DisciplinaController(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        [HttpGet]
        public ActionResult<List<Disciplina>> Get()
        {
            return Ok(_disciplinaRepository.GetDisciplina());
        }
        [HttpGet("{id}")]
        public ActionResult<Disciplina> GetById(int id)
        {
            return Ok(_disciplinaRepository.GetDisciplinaById(id));
        }

        [HttpPost]
        public ActionResult<Disciplina> CreateDisciplina(Disciplina disciplina)
        {
            //Validação
            if (disciplina.Nome.Length < 3 || disciplina.Nome.Length > 30)
            {
                return BadRequest("Nome não pode ser menor que 3 ou maior que 30 caracteres");
            }
            _disciplinaRepository.InsertDisciplina(disciplina);
            return CreatedAtAction(nameof(GetById), new { Id = disciplina.DisciplinaID }, disciplina);
        }

        [HttpPut]
        public ActionResult<Disciplina> UpdateDisciplina(Disciplina disciplina)
        {
            try
            {
                if (disciplina == null)
                {
                    return BadRequest();
                }
                _disciplinaRepository.UpdateDIsciplina(disciplina);
                return Ok("Disciplina alterada com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Disciplina disciplina)
        {
            try
            {
                if (disciplina == null)
                {
                    return BadRequest();
                }
                _disciplinaRepository.DeleteDisciplina(disciplina);
                return Ok("Disciplina deletada com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
