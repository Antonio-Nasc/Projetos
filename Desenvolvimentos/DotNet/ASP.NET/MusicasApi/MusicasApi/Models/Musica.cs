using System.ComponentModel.DataAnnotations;

namespace MusicasApi.Models
{
    public class Musica
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "A banda/cantor deve ter no máximo 100 caracteres")]
        public string Banda { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "O nome da música deve ter no máximo 100 caracteres")]
        public string NomeDaMusica { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "A musica deve ter no máximo 30 caracteres")]
        public string DuracaoDaMusica { get; set; }
    }
}
