using System.ComponentModel.DataAnnotations;

namespace RoupaApi.Models
{
    public class Roupa
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Máximo de caracteres = 50")]
        public string Modelo { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Máximo de caracteres = 50")]
        public string Marca { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Máximo de caracteres = 50")]
        public string Tamanho { get; set; }
    }
}
