using Microsoft.AspNetCore.Mvc;
using RoupaApi.Models;

namespace RoupaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoupaController : ControllerBase
    {
        private static List<Roupa> roupas = new List<Roupa>();
        private static int id = 0;
        [HttpPost]
        public void AdicionarRoupa([FromBody]Roupa roupa)
        {
            roupa.Id = id++;
            roupas.Add(roupa);
            Console.WriteLine(roupa.Id);
            Console.WriteLine(roupa.Modelo);
            Console.WriteLine(roupa.Marca);
            Console.WriteLine(roupa.Tamanho);
        }
    }
}
