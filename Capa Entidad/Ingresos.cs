using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Ingresos
    {
        public int idUsuario { get; set; }
        public decimal monto_bruto { get; set; }
        public decimal impuesto { get; set; }
        public decimal servicios { get; set; }
        public decimal monto_total { get; set; }

    }
}
