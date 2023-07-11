using EmprestimoLivros.API.Interfaces;
using EmprestimoLivros.API.Models;
using EmprestimoLivros.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
        {
            return Ok(await _clienteRepository.SelecionarTodos());
        }
        [HttpPost]
        public async Task<IActionResult> CadastrarCliente(Cliente cliente)
        {
            _clienteRepository.Incluir(cliente);
            if(await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente cadastrado com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao salvar o cliente.");
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> AlterarCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);
            if(cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }
            _clienteRepository.Alterar(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente alterado com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao alterar o cliente.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);
            if (cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            _clienteRepository.Excluir(cliente);
            if(await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente excluído com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao excluir o cliente");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClientePorId(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);
            if( cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return Ok(cliente);
        }
    }
}
