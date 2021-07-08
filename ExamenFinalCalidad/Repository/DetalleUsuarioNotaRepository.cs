using ExamenFinalCalidad.DB.Maps;
using ExamenFinalCalidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.Repository
{
    public interface IDetalleUsuarioNotaRepository
    {
        public Nota DetalleNota(int id);
    }
    public class DetalleUsuarioNotaRepository : IDetalleUsuarioNotaRepository
    {
        private CalidadContext _context;

        public DetalleUsuarioNotaRepository(CalidadContext context)
        {
            _context = context;
        }

        public Nota DetalleNota(int id)
        {
            var notaDetalle = _context._Notas.FirstOrDefault(o => o.IdNota == id);
            return notaDetalle;
        }
    }
}
