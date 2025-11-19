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
    public class CD_Hotel
    {
        public List<Hotel> Leer()
        {
            List<Hotel> hotel = new List<Hotel>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM hotel";
                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            hotel.Add(new Hotel()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                nombre = dr["nombre"].ToString(),
                                numero_habitacion = dr["numero_habitacion"].ToString(),
                                tipo_habitacion = dr["tipo_habitacion"].ToString(),
                                numeroPersonas = Convert.ToInt32(dr["numero_personas"]),
                                reserva =Convert.ToDateTime(dr["reserva"]),
                                salida =Convert.ToDateTime(dr["salida"]),
                                dias_estancia = Convert.ToInt32(dr["dias_estancia"]),
                                dias_restantes = Convert.ToInt32(dr["dias_restantes"])
                            });
                        }
                    }
                }
                catch
                {
                    hotel = new List<Hotel>();
                }
            }

            return hotel;
        }

        public bool Registrar(Hotel obj, out string mensaje)
        {
            bool generado = false;
            mensaje = String.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_CHECKIN", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.idUsuario);

                    cmd.Parameters.AddWithValue("nombreP", obj.nombre);
                    cmd.Parameters.AddWithValue("numerohabitacionP", obj.numero_habitacion);
                    cmd.Parameters.AddWithValue("personasP", obj.numeroPersonas);
                    cmd.Parameters.AddWithValue("salidaP", obj.salida);
                    cmd.Parameters.AddWithValue("tipoP", obj.tipo_habitacion);
                    cmd.Parameters.AddWithValue("restantesP", obj.dias_restantes);
                    cmd.Parameters.AddWithValue("estanciaP", obj.dias_estancia);

                    cmd.Parameters.Add("idgenerado", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    generado = Convert.ToBoolean(cmd.Parameters["idgenerado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (MySqlException ex)
            {
                mensaje = ex.Message;
                generado = false;
            }
            return generado;


        }
        public bool Editar(Hotel obj, out string mensaje)
        {
            bool idgenerado = false;
            mensaje = string.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_EDITARCLIENTE", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.idUsuario);

                    cmd.Parameters.AddWithValue("nombreP", obj.nombre);
                    cmd.Parameters.AddWithValue("numerohabitacionP", obj.numero_habitacion);
                    cmd.Parameters.AddWithValue("personasP", obj.numeroPersonas);
                    cmd.Parameters.AddWithValue("salidaP", obj.salida);
                    cmd.Parameters.AddWithValue("tipoP", obj.tipo_habitacion);
                    cmd.Parameters.AddWithValue("restantesP", obj.dias_restantes);
                    cmd.Parameters.AddWithValue("estanciaP", obj.dias_estancia);


                    cmd.Parameters.Add("respuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    idgenerado = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();



                }
            }
            catch (MySqlException ex)
            {
                idgenerado = false;
                mensaje = ex.Message;

            }
            return idgenerado;
        }

        public bool Eliminar(Hotel obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_CHECKOUT", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.idUsuario);
                    cmd.Parameters.Add("respuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
                    Console.WriteLine("Esta es la respuesta: " + respuesta.ToString());
                    Console.WriteLine("Este es el mensaje: " + cmd.Parameters["mensaje"].Value.ToString());

                    Console.WriteLine("pene");

                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (MySqlException ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }
    }
}
