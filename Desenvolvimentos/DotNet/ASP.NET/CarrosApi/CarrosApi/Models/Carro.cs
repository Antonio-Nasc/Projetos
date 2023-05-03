using System.ComponentModel.DataAnnotations;

namespace CarrosApi.Models
{
    public class Carro
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Máximo de caracteres = 100")]
        public string Modelo { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Máximo de caracteres = 100")]
        public string Marca { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Máximo de caracteres = 100")]
        public string AnoLancamento { get; set; }
        [Required]
        [MinLength(1)]
        public double Valor { get; set; }
    }
}
