using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario obj_usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {
            return obj_usuario.Leer();
        }
        public bool Registrar(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.nombre == "")
            {
                mensaje += " Es  necesario el nombre del Usuario";
            }
            if (obj.numeroTelefono == "")
            {
                mensaje += " Es necesario el Numero Telefonico del Usuario";

            }
            if (obj.correo == "")
            {
                mensaje += " Es necesario el Correo Electronico del Usuario";

            }
            if (obj.sexo == "")
            {
                mensaje += " Es necesario el Sexo del Usuario";

            }
            if (obj.edad == "")
            {
                mensaje += " Es necesario la Edad del Usuario";

            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_usuario.Editar(obj, out mensaje);

            }
        }
        public bool ImplementarMembresia(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.id == 0)
            {
                mensaje += " Es necesario el Identificador del Usuario";
                   
            }
            if (obj.nombre == "")
            {
                mensaje += " Es necesario el Nombre del Usuario";

            }
            if(obj.numeroTelefono == "")
            {
                mensaje += " Es necesario el Numero Telefonico del Usuario";

            }
            if(obj.correo == "")
            {
                mensaje += " Es necesario el Correo del Usuario";

            }
            if (obj.edad == "")
            {
                mensaje += " Es necesario la Edad del Usuario";

            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_usuario.activarMembresia(obj, out mensaje);
            }



        }
        public bool Eliminar(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.id == 0)
            {
                mensaje += " Es necesario el Id del Usuario";

            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_usuario.Eliminar(obj, out mensaje);
            }
        }
    }
}
