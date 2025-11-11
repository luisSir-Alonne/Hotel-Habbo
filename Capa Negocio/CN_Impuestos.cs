using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Impuestos
    {
        private CD_Impuestos obj_impuestos = new CD_Impuestos();
        public List<Impuestos> Leer()
        {
            return obj_impuestos.Leer();
        }
    }
}
