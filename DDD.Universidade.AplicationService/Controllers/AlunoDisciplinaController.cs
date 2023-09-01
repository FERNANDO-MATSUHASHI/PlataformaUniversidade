using DDD.Infra.MemoryDB.Interfaces;
using DDD.Unimar.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Universidade.AplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoDisciplinaController : ControllerBase
    {
        readonly IAlunoDisciplinaRepository _alunoDisciplinaRepository;

        public int idAluno;
        public AlunoDisciplinaController(IAlunoDisciplinaRepository alunoDisciplinaRepository)
        {
            _alunoDisciplinaRepository = alunoDisciplinaRepository;
        }

        [HttpGet]
        public ActionResult<List<AlunoDisciplina>> Get()
        {
            return Ok(_alunoDisciplinaRepository.GetAlunoDisciplina());
        }

        [HttpGet("{id}")]
        public ActionResult<AlunoDisciplina> GetById(int id)
        {
            idAluno = id;
            return Ok(_alunoDisciplinaRepository.GetAlunoDisciplinaById(id));
        }

        [HttpPost]
        public ActionResult<AlunoDisciplina> CreateAluno(AlunoDisciplina alunoDisciplina)
        {
            _alunoDisciplinaRepository.InsertAlunoDisciplina(alunoDisciplina);
            return CreatedAtAction(nameof(GetById), new { Id = alunoDisciplina.Id }, alunoDisciplina);
        }
    }
}
