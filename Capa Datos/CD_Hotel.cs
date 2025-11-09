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
    public class CD_Hotel
    {
        public List<Hotel> Leer()
        {
            List<Hotel> empleados = new List<Hotel>();
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
                            empleados.Add(new Hotel()
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
                    empleados = new List<Hotel>();
                }
            }

            return empleados;
        }

        public int Registrar(Hotel obj, out string mensaje)
        {
            int generado = 0;
            mensaje = String.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_CHECKIN", oconexion);
                   

                    cmd.Parameters.Add("idgenerado", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    generado = Convert.ToInt32(cmd.Parameters["idgenerado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();

                }
            }
            catch (MySqlException ex)
            {
                mensaje = ex.Message;
                generado = 0;
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
                    MySqlCommand cmd = new MySqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.idUsuario);
                    cmd.Parameters.Add("respuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
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
