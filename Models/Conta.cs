using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace money.Models
{
    [Table("Contas")]
    public class Conta
    {
        public Conta()
        {
            Finalidades = new Collection<Finalidade>();
        }
        [Key]
        public int ContaId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        public decimal ValorContido { get; set; }
        public ICollection<Finalidade> Finalidades { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
