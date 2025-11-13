using CapaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
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
        public bool Actualizar(Habitaciones habitacion, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SP_ACTUALIZARHABITACION", oconexion);
                    cmd.Parameters.AddWithValue("habitacionP", habitacion.habitacion);
                    cmd.Parameters.AddWithValue("estado", habitacion.disponible);

                    cmd.Parameters.Add("respuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", MySqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    mensaje = cmd.Parameters["mensaje"].ToString();

                    
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex);
                    respuesta = false;
                }
                return respuesta;
            }

        }
        
    }
}
