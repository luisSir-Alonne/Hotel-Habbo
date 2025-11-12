using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System.Data;
namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Leer()
        {
            List<Usuario> empleados = new List<Usuario>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM usuarios";
                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            empleados.Add(new Usuario()
                            {
                                id = Convert.ToInt32(dr["id"]),
                                nombre = dr["nombre"].ToString(),
                                numeroTelefono = dr["numero_telefono"].ToString(),
                                sexo = dr["sexo"].ToString(),
                                correo = dr["correo_electronicio"].ToString(),
                                edad = dr["edad"].ToString(),
                                membresia = Convert.ToBoolean(dr["membresia_activa"]),
                                fecha_registro = dr["fecha_registro"].ToString()
                            });
                        }
                    }
                }
                catch
                {
                    empleados = new List<Usuario>();
                }
            }

            return empleados;
        }

        public int Registrar(Usuario obj, out string mensaje)
        {
            int generado = 0;
            mensaje = String.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_NEWUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("nombreP", obj.nombre);
                    cmd.Parameters.AddWithValue("numeroP", obj.numeroTelefono);
                    cmd.Parameters.AddWithValue("correoP", obj.correo);
                    cmd.Parameters.AddWithValue("sexoP", obj.sexo);
                    cmd.Parameters.AddWithValue("edadP", obj.edad);

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
        public bool Editar(Usuario obj, out string mensaje)
        {
            bool idgenerado = false;
            mensaje = string.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.id);
                    cmd.Parameters.AddWithValue("telefonoP", obj.numeroTelefono);
                    cmd.Parameters.AddWithValue("nombreP", obj.nombre);
                    cmd.Parameters.AddWithValue("correoP", obj.correo);
                    cmd.Parameters.AddWithValue("edadP", obj.edad);
                    cmd.Parameters.AddWithValue("mem", obj.membresia);
                    cmd.Parameters.AddWithValue("sexoP", obj.sexo);


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

        public bool Eliminar(Usuario obj, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
                {
                    MySqlCommand cmd = new MySqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("idP", obj.id);
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
