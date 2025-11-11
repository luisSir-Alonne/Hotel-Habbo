using Capa_Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Habitaciones
    {
        public List<Habitaciones> Leer()
        {
            List<Habitaciones> hotel = new List<Habitaciones>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM habitaciones";
                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            hotel.Add(new Habitaciones()
                            {
                                idhabitacion = Convert.ToInt32(dr["idHabitacion"]),
                                habitacion = dr["habitacion"].ToString(),
                                disponible = Convert.ToBoolean(dr["disponible"].ToString()),
                                tipo = dr["tipo"].ToString()
                            });
                        }
                    }
                }
                catch
                {
                    hotel = new List<Habitaciones>();
                }
            }

            return hotel;
        }

        
    }
}
