using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Hotel
    {
        public CD_Hotel obj_hotel = new CD_Hotel();
        public List<Hotel> Listar()
        {
            return obj_hotel.Leer();
        }
        public bool Registrar(Hotel obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.idUsuario == 0)
            {
                mensaje += " Es necesario el Id del Cliente";

            }
            if (obj.nombre == "")
            {
                mensaje += " Es necesario el Nombre del Cliente";

            }
            if (obj.numero_habitacion == "")
            {
                mensaje += " Es necesario el Numero de Habitacion";

            }
            if (obj.tipo_habitacion == "")
            {
                mensaje += " Es necesario el Tipo de Habitacion";

            }
            if (obj.numeroPersonas == 0)
            {
                mensaje += " Es necesario el Numero de Personas";

            }
            if (obj.reserva == null)
            {
                mensaje += " Es necesaria la Fecha de Reserva del Cliente";
            }
            if (obj.salida == null)
            {
                mensaje += " Es necesaria la fecha de Salidad el Cliente";
            }
            if (obj.dias_estancia == 0)
            {
                mensaje += " Es necesario los Dias de Instancia del Cliente";

            } 
            if (obj.dias_restantes == null)
            {
                mensaje += " Es necesario los Dias Restantes del Cliente";

            }
            if(mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_hotel.Registrar(obj, out mensaje);

            }
        }
        public bool Editar(Hotel obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.idUsuario == 0)
            {
                mensaje += " Es necesario el Id del Cliente";

            }
            if (obj.nombre == "")
            {
                mensaje += " Es necesario el Nombre del Cliente";

            }
            if (obj.numero_habitacion == "")
            {
                mensaje += " Es necesario el Numero de Habitacion";

            }
            if (obj.tipo_habitacion == "")
            {
                mensaje += " Es necesario el Tipo de Habitacion";

            }
            if (obj.numeroPersonas == 0)
            {
                mensaje += " Es necesario el Numero de Personas";

            }
            if (obj.reserva == null)
            {
                mensaje += " Es necesaria la Fecha de Reserva del Cliente";
            }
            if (obj.salida == null)
            {
                mensaje += " Es necesaria la fecha de Salidad el Cliente";
            }
            if (obj.dias_estancia == 0)
            {
                mensaje += " Es necesario los Dias de Instancia del Cliente";

            }
            if (obj.dias_restantes == null)
            {
                mensaje += " Es necesario los Dias Restantes del Cliente";

            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_hotel.Editar(obj, out mensaje);

            }
        }
        public bool Eliminar(Hotel obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.idUsuario == 0)
            {
                mensaje += " Es necesario el Id del Usuario";

            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_hotel.Eliminar(obj, out mensaje);

            }
        }

    }
}
