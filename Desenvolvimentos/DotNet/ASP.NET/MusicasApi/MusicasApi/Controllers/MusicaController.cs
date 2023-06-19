using Microsoft.AspNetCore.Mvc;
using MusicasApi.Models;

namespace MusicasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicaController : ControllerBase
    {
        private static List<Musica> musicas = new List<Musica>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionarMusica([FromBody] Musica musica)
        {
            musica.Id = id++;
            musicas.Add(musica);
            //Informa ao usuário o caminho em que ele pode encontrar o filme cadastrado
            //primeiro parâmetro: método utilizado para retornar o elemento criado;
            //segundo: parâmetros que o método precisa para retornar o elemento que foi criado, no caso o ID;
            //Terceiro: O objeto que foi criado.
            return CreatedAtAction(nameof(ListarMusicasPorId), new {id = musica.Id}, musica);
        }
        [HttpGet]
        public IEnumerable<Musica> ListarMusicas([FromQuery]int skip=0, int take=10)
        {
            //Vai pular um total de 0 músicas e vai pegar 10, não precisando trazer tudo de vez.
            return musicas.Skip(skip).Take(take);
        }
        [HttpGet("{id}")]
        //IActionResult é resultado de uma ação encontrada: notfound or ok
        public IActionResult ListarMusicasPorId(int id)
        {
            var musica = musicas.FirstOrDefault(musica => musica.Id == id);
            if(musica == null) return NotFound();
            return Ok(musica);
        }
    }
}
