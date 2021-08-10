using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace money.Models
{
    [Table("Finalidades")]
    public class Finalidade
    {
        [Key]
        public int FinalidadeId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        public int Porcentagem { get; set; }
        public Conta Conta { get; set; }
        public int ContaId { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
