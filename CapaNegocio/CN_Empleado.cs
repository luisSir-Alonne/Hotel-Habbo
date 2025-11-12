using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Empleado
    {
        private CD_Empleados obj_empleado = new CD_Empleados() ;
       public List<Empleado> Listar()
        {
            return obj_empleado.Leer();
        }
        public int Registrar(Empleado obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.correo == "")
            {
                mensaje += " Es necesario el correo del nuevo Empleado";

            }
            if (obj.clave == "")
            {
                mensaje += " Es neecsaria la clave del usuario";

            }
            if (obj.nombre == "")
            {
                mensaje += " Es necesario el Nombre del usuario";

            }
            if (mensaje != string.Empty)
            {
                return 0; 

            }
            else
            {
                return obj_empleado.Registrar(obj, out mensaje);
            }
        }
        public bool Editar(Empleado obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.nombre == "")
            {
                mensaje += " Es necesario el nombre del Empleado";

            }
            if (obj.clave == "")
            {
                mensaje += " Es necesario la clave del Empleado";

            }
            if (obj.correo == "")
            {
                mensaje += " Es necesario el correo electronico del Empleado";

            }
            if ( mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_empleado.Editar(obj, out mensaje);

            }
        }
        public bool Eliminar(Empleado obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.idEmpleado == 0)
            {
                mensaje += " Es necesario el Id del Usuario";

            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_empleado.Eliminar(obj, out mensaje);
            }
        }
    }
}
