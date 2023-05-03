using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;
using System.Diagnostics;
using FilmesApi.Data;
using FilmesApi.Data.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

namespace FilmesApi.Controllers
{
    //Controller serve como local das requisições e respota do cliente
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;
        private IMapper _mapper;

        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody]CreateFilmeDto filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmePorId), new {id = filme.Id}, filme);
        }
        [HttpGet]
        public IEnumerable<ReadFilmeDto> RecuperaFilmes([FromQuery]int skip = 0, [FromQuery] int take = 50)
        {
            return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take));
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme == null) return NotFound();
            var filmeDto = _mapper.Map<ReadFilmeDto>(filme);
            return Ok(filmeDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody]UpdateFilmeDto filmeDto)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme == null) return NotFound();
            _mapper.Map(filmeDto, filme);
            _context.SaveChanges();
            //Para retornar um status atualizado, se usa NoContent()
            return NoContent();

        }
        [HttpPatch("{id}")]
        public IActionResult AtualizaFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDto> patch)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null) return NotFound();
            var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);
            patch.ApplyTo(filmeParaAtualizar, ModelState);
            if (!TryValidateModel(filmeParaAtualizar))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(filmeParaAtualizar, filme);
            _context.SaveChanges();
            //Para retornar um status atualizado, se usa NoContent()
            return NoContent();

        }
        [HttpDelete("{id}")]
        public IActionResult RemoveFilme(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null) return NotFound();
            _context.Remove(filme);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
