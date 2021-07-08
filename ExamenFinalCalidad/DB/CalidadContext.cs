using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenFinalCalidad.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenFinalCalidad.DB.Maps
{
    public class CalidadContext : DbContext
    {
        public DbSet<Usuario> _Usuarios { get; set; }
        public DbSet<Nota> _Notas { get; set; }
        public DbSet<Etiqueta> _Etiquetas { get; set; }
        public DbSet<DetalleUsuarioNota> _DetalleUsuarioNotas { get; set; }

        public CalidadContext(DbContextOptions<CalidadContext> options)
            :base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


          
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new NotaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaMap());
            modelBuilder.ApplyConfiguration(new DetalleUsuarioNotaMap());


        }
    }
}
