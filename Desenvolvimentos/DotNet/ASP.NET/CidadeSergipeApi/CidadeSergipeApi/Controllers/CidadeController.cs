using CidadeSergipeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CidadeSergipeApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CidadeController : ControllerBase
    {
        private static List<CidadeSergipe> cidadeSergipe = new List<CidadeSergipe>();
        private static int Id = 0;

        [HttpPost]
        public CidadeSergipe AdicionarCidade(CidadeSergipe cidade)
        {
            cidade.id = Id++;
            cidadeSergipe.Add(cidade);
            return cidade;
        }
    }
}
