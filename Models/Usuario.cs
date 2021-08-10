using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace money.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Usuario()
        {
            Rendas = new Collection<Renda>();
            Contas = new Collection<Conta>();
            Finalidades = new Collection<Finalidade>();
        }
        [Key]
        public int UsuarioId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(80)]
        public string Email { get; set; }
        [Required]
        [MaxLength(20)]
        public string Senha { get; set; }
        public ICollection<Renda> Rendas { get; set; }
        public ICollection<Conta> Contas { get; set; }
        public ICollection<Finalidade> Finalidades { get; set; }


    }
}
