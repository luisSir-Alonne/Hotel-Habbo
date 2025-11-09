using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string numeroTelefono { get; set; }
        public string sexo { get; set; }
        public string correo { get; set; }
        public string edad { get; set; }
        public bool membresia { get; set; }
        public string fecha_registro { get; set; }

    }
}
