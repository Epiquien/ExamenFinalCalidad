using ExamenFinalCalidad.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.DB.Maps
{
    public class EtiquetaMap : IEntityTypeConfiguration<Etiqueta>
    {
        public void Configure(EntityTypeBuilder<Etiqueta> builder)
        {
            builder.ToTable("Etiqueta");
            builder.HasKey(o => o.IdEtiqueta);

        }
    }
}
