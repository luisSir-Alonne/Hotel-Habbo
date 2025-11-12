using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol obj_rol = new CD_Rol();
        public List<Rol> Leer()
        {
            return obj_rol.Leer();
        }
    }
}
