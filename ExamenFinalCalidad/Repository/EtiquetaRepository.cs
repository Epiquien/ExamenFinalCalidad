using ExamenFinalCalidad.DB.Maps;
using ExamenFinalCalidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.Repository
{
    public interface IEtiquetaRepository
    {
        public List<Etiqueta> Categorias();
    }
    public class EtiquetaRepository : IEtiquetaRepository
    {
        private CalidadContext _context;

        public EtiquetaRepository(CalidadContext context)
        {
            _context = context;
        }

        public List<Etiqueta> Categorias()
        {
            var categorias = _context._Etiquetas.ToList();
            return categorias;
        }
    }
}
