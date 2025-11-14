using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Habitaciones
    {
        private CD_Habitaciones obj_habitaciones = new CD_Habitaciones();
        public List<Habitaciones> Listar()
        {
            return obj_habitaciones.Leer();
        }
    }
}
