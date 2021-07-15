using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso_.NET_MVC.Models;

namespace Curso_.NET_MVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias{ get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Curso_.NET_MVC;Integrated Security=True");
        }
        public DbSet<Curso_.NET_MVC.Models.Produto> Produto { get; set; }
    }
}
