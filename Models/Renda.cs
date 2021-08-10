using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace money.Models
{
    [Table("Rendas")]
    public class Renda
    {
        [Key]
        public int RendaId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Tipo { get; set; }
        [Required]
        public decimal Valor { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
