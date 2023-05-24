using System.ComponentModel.DataAnnotations;

namespace ApiTarefas.Models
{
    public class Tarefas
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "Título deve ter no máximo 60 caracteres")]
        public string Titulo { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "Descrição deve ter no máximo 300 caracteres")]
        public string Descricao { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Status deve ter no máximo 40 caracteres")]
        public string Status { get; set; }
    }
}
