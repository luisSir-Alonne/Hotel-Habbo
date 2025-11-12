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
    public class CD_Ingresos
    {
        public List<Ingresos> Leer()
        {
            List<Ingresos> ingresos = new List<Ingresos>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM ingresos";
                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ingresos.Add(new Ingresos()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"].ToString()),
                                monto_bruto = Convert.ToDecimal(dr["monto_bruto"]),
                                impuesto = Convert.ToDecimal(dr["impuesto"].ToString()),
                                servicios = Convert.ToDecimal(dr["servicios"].ToString()),
                                monto_total = Convert.ToDecimal(dr["monto_total"])

                            });
                        }
                    }
                }
                catch
                {
                    ingresos = new List<Ingresos>();
                }
            }

            return ingresos;
        }

        public bool Registrar(Ingresos obj, out string mensaje)
        {
            bool generado = false;
            mensaje = String.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_INGRESO", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.idUsuario);
                    cmd.Parameters.AddWithValue("brutoP", obj.monto_bruto);
                    cmd.Parameters.AddWithValue("impuestoP", obj.impuesto);
                    cmd.Parameters.AddWithValue("serviciosP", obj.servicios);
                    cmd.Parameters.AddWithValue("totalP", obj.monto_total);

                    cmd.Parameters.Add("respuesta", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", MySqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    generado = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
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
        public bool Editar(Ingresos obj, out string mensaje)
        {
            bool idgenerado = false;
            mensaje = string.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_EDITARINGRESOS", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.idUsuario);
                    cmd.Parameters.AddWithValue("brutoP", obj.monto_bruto);
                    cmd.Parameters.AddWithValue("impuestoP", obj.impuesto);
                    cmd.Parameters.AddWithValue("serviciosP", obj.servicios);
                    cmd.Parameters.AddWithValue("totalP", obj.monto_total);
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
    // Posible adicion del procedimiento almacenado para eliminar el ingreso total
       /* public bool Eliminar(Ingresos obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_ELIMINAREMPLEADO", oconexion);
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
        }*/
    }
}
