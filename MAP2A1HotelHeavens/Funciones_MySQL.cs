using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAP2A1HotelHeavens
{
    public class Funciones_MySQL
    {
        private string Conexion = "Server=127.0.0.1;Database=hotel;User ID=root;Password=;";
        
        
        public MySqlConnection obtenerconexion()
        {
            MySqlConnection con = new MySqlConnection(Conexion);

            try
            {
                con.Open();
                Console.WriteLine("La conexion fue exitosa");
            }
            catch(Exception no)
            {
                Console.WriteLine("Fallo la conexion" + no.Message);
            }
            return con;
        }
    }
}
