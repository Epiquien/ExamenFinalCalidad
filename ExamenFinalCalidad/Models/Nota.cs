using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.Models
{
    public class Nota
    {
        public int IdNota { get; set; }
        public String TituloNota { get; set; }
        public String ContenidoNota { get; set; }

        public DateTime Fecha { get; set; }
        public int IdCategoria { get; set; }
      
        public int IdCreador { get; set; }
      
    }
}
