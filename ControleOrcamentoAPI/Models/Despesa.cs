using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleOrcamentoAPI.Models
{
    public class Despesa
    {
        [Key]
        [Required(ErrorMessage = "O campo id é obrigatório")]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "O campo descrição deve ter no mínimo 3 caracteres")]
        public string Descricao { get; set; }
        [Required]
        [Range(1, 999, ErrorMessage = "O valor deve ter no mínimo 1 e no máximo 999")]
        [Column(TypeName = "decimal(18, 2)")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "O campo data é obrigatório")]
        [DataType(DataType.Date)]
        public DateOnly Data { get; set; } 
    }
}
