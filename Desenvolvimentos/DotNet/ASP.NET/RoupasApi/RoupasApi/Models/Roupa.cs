using System.ComponentModel.DataAnnotations;

namespace RoupasApi.Models
{
    public class Roupa
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "É necessário ter caracteres de no máximo 50 dígitos")]
        public string Modelo { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "É necessário ter caracteres de no máximo 50 dígitos")]
        public string Marca { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "É necessário ter caracteres de no máximo 50 dígitos")]
        public string Tamanho { get; set;}
    }
}
