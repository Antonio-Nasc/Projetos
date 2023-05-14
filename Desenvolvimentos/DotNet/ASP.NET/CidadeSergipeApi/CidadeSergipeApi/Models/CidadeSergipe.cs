using System.ComponentModel.DataAnnotations;

namespace CidadeSergipeApi.Models
{
    public class CidadeSergipe
    {
        public int id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "É necessário nome ter no máximo 100 caracteres", MinimumLength = 1)]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "É necessário população ter no máximo 100 caracteres", MinimumLength = 1)]
        public string Populacao { get; set; }
    }
}
