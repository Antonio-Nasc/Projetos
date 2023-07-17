using AutoMapper;
using EmprestimoLivros.API.DTO;
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
        private readonly IMapper _mapper;
        public ClienteController(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
        {
            var clientes = await _clienteRepository.SelecionarTodos();
            var clientesDTO = _mapper.Map<IEnumerable<ClienteDTO>>(clientes);
            return Ok(clientesDTO);
        }
        [HttpPost]
        public async Task<IActionResult> CadastrarCliente(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            _clienteRepository.Incluir(cliente);
            if(await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente cadastrado com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao salvar o cliente.");
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> AlterarCliente(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
             _clienteRepository.Alterar(cliente);
            if(clienteDTO.Id == 0)
            {
               return BadRequest("Não é possivel alterar o cliente. É preciso informar o ID");
            }
            var clienteExiste = await _clienteRepository.SelecionarByPk(clienteDTO.Id);
            if(clienteExiste == null)
            {
               return NotFound("Cliente não encontrado");
            }
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
            var clienteDTO = _mapper.Map<ClienteDTO>(cliente);
            return Ok(clienteDTO);
        }
    }
}
