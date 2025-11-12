using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Leer()
        {
            List<Rol> rol = new List<Rol>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM rol";
                    MySqlCommand cmd = new MySqlCommand(query, oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            rol.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["idHabitacion"].ToString()),
                                descripcion = dr["descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (MySqlException ex)
                {
                     rol =  new List<Rol>();
                }
                return rol;
            }
        }
    }
}
