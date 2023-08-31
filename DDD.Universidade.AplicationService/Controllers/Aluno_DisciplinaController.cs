using DDD.Infra.MemoryDB.Interfaces;
using DDD.Infra.MemoryDB.Repositories;
using DDD.Unimar.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace DDD.Universidade.AplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Aluno_DisciplinaController : ControllerBase
    {
        readonly IAlunoDisciplinaRepository _aluno_DisciplinaRepository;
        public Aluno_DisciplinaController(IAlunoDisciplinaRepository aluno_DisciplinaRepository)
        {
            _aluno_DisciplinaRepository = aluno_DisciplinaRepository;
        }

        [HttpGet]
        public ActionResult<List<AlunoDisciplina>> Get()
        {
            return Ok(_aluno_DisciplinaRepository.GetAlunos_Disciplina());
        }

        [HttpGet("{id}")]
        public ActionResult<AlunoDisciplina> GetById(int id)
        {
            return Ok(_aluno_DisciplinaRepository.GetAluno_DisciplinaById(id));
        }

        [HttpPost]
        public ActionResult<AlunoDisciplina> CreateAluno_Disciplina(AlunoDisciplina aluno_Disciplina)
        {
            _aluno_DisciplinaRepository.InsertAlunoDisciplina(aluno_Disciplina);
            return CreatedAtAction(nameof(GetById), new { Id = aluno_Disciplina.DisciplinaID }, aluno_Disciplina);
        }
    }
}
