using Microsoft.EntityFrameworkCore;
using Modelo.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class StockContext : DbContext
    {
        //Clases tipo entidad
        public DbSet<Almacen> Almacen { get; set; }
        public DbSet<Configuracion> Configuracion { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Movimiento> Movimiento { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Provedores> Provedores { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        //constructot vacio 
        public StockContext() : base()
        {

        }
        //Constructor para pasar la conexion al padre
        public StockContext(DbContextOptions<StockContext> opciones)
            : base(opciones)
        {

        }
        // Se mantiene para la creacion de la base de datos 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                StockConfig.ContextOptions(optionsBuilder);
            }

        }
        //Configuracion del modelo de objetos tipo entidad 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relacion relacion con movimiento y producto 
          
           modelBuilder.Entity<Movimiento>()
                .HasOne(m => m.Producto)
                .WithMany(p => p.Movimiento)
                .HasForeignKey(m => m.ProductoId);
            
        }
    }
}
