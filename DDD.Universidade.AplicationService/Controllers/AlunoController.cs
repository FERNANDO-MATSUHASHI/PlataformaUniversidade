using DDD.Infra.MemoryDB.Interfaces;
using DDD.Unimar.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Universidade.AplicationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        readonly IAlunoRepository _alunoRepository;
        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        [HttpGet]
        public ActionResult<List<Aluno>> Get()
        {
            return Ok(_alunoRepository.GetAlunos());
        }

        [HttpGet("{id}")]
        public ActionResult<Aluno> GetById(int id)
        {
            return Ok(_alunoRepository.GetAlunoById(id));
        }

        [HttpPost]
        public ActionResult<Aluno> CreateAluno(Aluno aluno)
        {
            //Validação
            if (aluno.Nome.Length < 3 || aluno.Nome.Length > 30)
            {
                return BadRequest("Nome não pode ser menor que 3 ou maior que 30 caracteres");
            }
            _alunoRepository.InsertAluno(aluno);
            return CreatedAtAction(nameof(GetById), new {Id = aluno.Id}, aluno);
        }
    }
}
