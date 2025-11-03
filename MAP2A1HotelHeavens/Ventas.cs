using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MAP2A1HotelHeavens
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void CargarDatosVentas()
        {
            Funciones_MySQL usar = new Funciones_MySQL();
            using (MySqlConnection cone = usar.obtenerconexion())
            {
                string info = "SELECT idUsuario,monto_bruto,impuesto,servicios,monto_total FROM ingresos";
                MySqlDataAdapter adaptar = new MySqlDataAdapter(info, cone);
                DataTable si = new DataTable();
                adaptar.Fill(si);
                dataGridView1.DataSource = si;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarDatosVentas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
