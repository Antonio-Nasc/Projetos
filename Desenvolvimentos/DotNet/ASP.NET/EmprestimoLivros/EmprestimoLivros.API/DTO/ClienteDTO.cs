using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.API.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(14)]
        [MinLength(14)]
        public string CliCpf { get; set; }
        [Required]
        [StringLength(200)]
        public string CliNome { get; set; }
        [Required]
        [StringLength(200)]
        public string CliEndereco { get; set; }
        [Required]
        [StringLength(100)]
        public string CliCidade { get; set; }
        [Required]
        [StringLength(100)]
        public string CliBairro { get; set; }
        [Required]
        [StringLength(50)]
        public string CliNumero { get; set; }
        [Required]
        [StringLength(14)]
        public string CliTelefoneCelular { get; set; }
        [Required]
        [StringLength(13)]
        public string CliTelefoneFixo { get; set; }
    }
}
