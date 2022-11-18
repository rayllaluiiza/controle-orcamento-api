using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleOrcamentoAPI.Models
{
    public class Despesas
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(300, MinimumLength = 3)]
        public string Descricao { get; set; }
        [Required]
        [Range(0, 999.99)]
        [Column(TypeName = "decimal(18, 2)")]
        public double Valor { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; } 
    }
}
