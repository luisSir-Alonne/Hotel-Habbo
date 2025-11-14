using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Habitaciones
    {
        public int idhabitacion { get; set; }
        public string habitacion { get; set; }
        public bool disponible { get; set; }
        public string tipo { get; set; }

        public override string ToString()
        {
            string estado = disponible ? "Disponible" : "Ocupada";
            return $"{habitacion} - {tipo} - {estado}";
        }
    }
}
