using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Negocio
{
    public class CN_Ingresos
    {
        private CD_Ingresos obj_ingresos = new CD_Ingresos();
        public List<Ingresos> Leer()
        {
            return obj_ingresos.Leer();
        }
        public bool Registrar(Ingresos obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.idUsuario == 0)
            {
                mensaje += " Es necesario el Identificador del Cliente";
            }
            if (obj.monto_bruto == 0)
            {
                mensaje += " Es necesario un Monto Bruto de Ingreso para poder registrarse";
            }
            if (obj.monto_total == 0)
            {
                mensaje += " Es necesario un Monto Total de Ingreso para poder registrarse";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_ingresos.Registrar(obj, out mensaje);

            }
        }
        public bool Editar(Ingresos obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (obj.idUsuario == 0)
            {
                mensaje += " Es necesario el Identificador del Cliente";
            }
            if (obj.monto_bruto == 0)
            {
                mensaje += " Es necesario un Monto Bruto de Ingreso para poder registrarse";
            }
            if (obj.monto_total == 0)
            {
                mensaje += " Es necesario un Monto Total de Ingreso para poder registrarse";
            }
            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return obj_ingresos.Editar(obj, out mensaje);

            }
        }
    }
}
