using System.ComponentModel.DataAnnotations;

namespace EstadoApi.Controllers.Models
{
    public class Estado
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "255 é o máximo de caracteres")]
        [MinLength(1, ErrorMessage = "É necessário pelo menos um caractere para adicionar a informação")]
        public string Name { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "255 é o máximo de caracteres")]
        [MinLength(1, ErrorMessage = "É necessário pelo menos um caractere para adicionar a informação")]
        public string Capital { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "255 é o máximo de caracteres")]
        [MinLength(1, ErrorMessage = "É necessário pelo menos um caractere para adicionar a informação")]
        public string Regiao { get; set; }
    }
}
