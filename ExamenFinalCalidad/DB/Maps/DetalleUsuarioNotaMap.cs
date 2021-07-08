using ExamenFinalCalidad.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.DB.Maps
{
    public class DetalleUsuarioNotaMap : IEntityTypeConfiguration<DetalleUsuarioNota>
    {
        public void Configure(EntityTypeBuilder<DetalleUsuarioNota> builder)
        {
            builder.ToTable("DetalleUsuarioNota");
            builder.HasKey(o => o.Id);
        }
    }
}
