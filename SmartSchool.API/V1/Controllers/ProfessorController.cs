using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Data;
using SmartSchool.API.V1.Dtos;
using SmartSchool.API.Models;
using SmartSchool.API.Helpers;

namespace SmartSchool.API.V1.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public ProfessorController(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var professores = _repository.GetAllProfessores(true);

            return Ok(_mapper.Map<IEnumerable<ProfessorDto>>(professores));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var professor = _repository.GetProfessorById(id, false);
            if (professor is null)
                return BadRequest(Messages.GetMessageNaoEncontrado(nameof(Professor)));

            return Ok(_mapper.Map<ProfessorDto>(professor));
        }

        [HttpPost]
        public IActionResult Post(ProfessorRegistrarDto model)
        {
            var professor = _mapper.Map<Professor>(model);

            _repository.Add(professor);
            if (_repository.SaveChanges())
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ProfessorRegistrarDto model)
        {
            var professor = _repository.GetProfessorById(id, false);
            if (professor is null)
                return BadRequest(Messages.GetMessageNaoEncontrado(nameof(Professor)));

            _mapper.Map(model, professor);

            _repository.Update(professor);
            if (_repository.SaveChanges())
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            return BadRequest();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, ProfessorRegistrarDto model)
        {
            var professor = _repository.GetProfessorById(id, false);
            if (professor is null)
                return BadRequest(Messages.GetMessageNaoEncontrado(nameof(Professor)));

            _mapper.Map(model, professor);

            _repository.Update(professor);
            if (_repository.SaveChanges())
                return Created($"/api/professor/{model.Id}", _mapper.Map<ProfessorDto>(professor));
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repository.GetProfessorById(id, false);
            if (professor is null)
                return BadRequest(Messages.GetMessageNaoEncontrado(nameof(Professor)));

            _repository.Delete(professor);
            if (_repository.SaveChanges())
                return Ok();
            return BadRequest();
        }
    }
}