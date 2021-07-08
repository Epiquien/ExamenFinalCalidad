using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.Models
{
    public class DetalleUsuarioNota
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdNota { get; set; }
        public bool Estado { get; set; }
    }
}
