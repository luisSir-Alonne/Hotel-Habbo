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
    public class CD_Impuestos
    {
        public List<Impuestos> Leer()
        {
            List<Impuestos> impuestos = new List<Impuestos>();
            using (MySqlConnection oconexion = new MySqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM impuestos";
                    MySqlCommand cmd = new MySqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    oconexion.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            impuestos.Add(new Impuestos()
                            {
                               idImpuesto = Convert.ToInt32(dr["idImpuesto"].ToString()),
                               impuesto = dr["impuesto"].ToString(),
                               costo = Convert.ToDecimal(dr["costo"].ToString())
                            });
                        }
                    }
                }
                catch
                {
                    impuestos = new List<Impuestos>();
                }
            }

            return impuestos;
        }

       
    }
}
