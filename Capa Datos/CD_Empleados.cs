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
    public class CD_Empleados
    {
        public List<Empleado> Leer()
        {
            List<Empleado> empleados = new List<Empleado>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM empleados_hotel h INNER JOIN rol r ON h.IdRol = r.IdRol;";
                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            empleados.Add(new Empleado()
                            {
                                idEmpleado = Convert.ToInt32(dr["idEmpleado"]),
                                nombre = dr["nombre"].ToString(),
                                correo = dr["correo"].ToString(),
                                clave = dr["clave"].ToString(),
                                fecha = dr["fecha_registro"].ToString(),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), descripcion = dr["descripcion"].ToString() }
                            });
                        }
                    }
                }
                catch
                {
                    empleados = new List<Empleado>();
                }
            }

            return empleados;
        }

        public int Registrar(Empleado obj, out string mensaje)
        {
            int generado = 0;
            mensaje = String.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_NEWEMPLEADO", oconexion);
                    cmd.Parameters.AddWithValue("nombreP", obj.nombre);
                    cmd.Parameters.AddWithValue("claveP", obj.clave);
                    cmd.Parameters.AddWithValue("correoP", obj.correo);
                    cmd.Parameters.AddWithValue("idRolP", obj.oRol.IdRol);

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
        public bool Editar(Empleado obj, out string mensaje)
        {
            bool idgenerado = false;
            mensaje = string.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("nombreP", obj.nombre);
                    cmd.Parameters.AddWithValue("claveP", obj.clave);
                    cmd.Parameters.AddWithValue("correoP", obj.correo);
                    cmd.Parameters.AddWithValue("idRol", obj.oRol.IdRol);

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

        public bool Eliminar(Empleado obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_ELIMINAREMPLEADO", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.idEmpleado);
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
