using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Hotel
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string numero_habitacion {get; set; }
        public string tipo_habitacion { get; set; }
        public int numeroPersonas { get; set; }
        public DateTime reserva { get; set; }
        public DateTime salida { get; set; }
        public int dias_estancia { get; set; }
        public int dias_restantes { get; set; }
        public int menores { get; set; }
    }
}
