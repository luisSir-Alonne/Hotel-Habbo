using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Leer(int idUsuario)
        {
            List<Permiso> permisos = new List<Permiso>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "Select p.IdRol, p.descripcion FROM permisos p INNER JOIN rol r on r.IdRol = p.IdRol INNER JOIN empleados_hotel h ON h.IdRol = r.IdRol WHERE h.idEmpleado = @idP";
                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@idP", idUsuario);
                    cmd.CommandType = System.Data.CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            permisos.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                descripcion = dr["descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                return permisos;
            }
    }   }

}
