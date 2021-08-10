using Microsoft.EntityFrameworkCore;
using money.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace money.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Finalidade> Finalidades { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Renda> Rendas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
