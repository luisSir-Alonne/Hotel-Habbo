using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public Rol oRol { get; set; }

        public string correo { get; set; }
        public string clave { get; set; }
        public string fecha { get; set; }

    }
}
