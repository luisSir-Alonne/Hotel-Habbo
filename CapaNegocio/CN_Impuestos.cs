using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
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
