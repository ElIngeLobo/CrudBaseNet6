using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerData
{
    public class AppVentaLibrosContext : DbContext
    {
        private const string connectionString = @"Data Source = . ;Initial Catalog=LibrosWeb; User=sa;password=12345678; Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibroAutor>().HasKey(xi => new { xi.AutorId, xi.LibroId });
        }

        public DbSet<Libro> Libro { get; set; }
        public DbSet<Precio> Precio { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<LibroAutor> LibroAutor { get; set; }


    }
}
