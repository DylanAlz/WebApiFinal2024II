using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebApiFinal2024II.Dal.Entities;

namespace WebApiFinal2024II.Dal
{
    public class DataBaseContext : DbContext
    {
        //por medio de este constructor me conecto a la BD
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        //Este metodo me sirve para configurar unos indices de cada campo en una tabla en BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libros>().HasIndex(l => l.titulo).IsUnique(); //se crea un indice para la tabla country para el campo titulo

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Categorias>().HasIndex(c => c.Nombre_cat).IsUnique(); //se crea un indice para la tabla country para el campo nombre


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libros_Categorias>().HasIndex(lc => lc.libroId).IsUnique(); //se crea un indice para la tabla country para el campo libroId
        }

        #region DbSets
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Libros_Categorias> Libros_Categorias { get; set; }
        #endregion
    }
}
