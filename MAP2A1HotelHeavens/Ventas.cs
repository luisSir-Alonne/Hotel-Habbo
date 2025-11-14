using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;

namespace MAP2A1HotelHeavens
{
    public partial class Ventas : Form
    {
        CN_Impuestos ingresos = new CN_Impuestos();
        public Ventas()
        {
            InitializeComponent();
        }

        private void CargarDatosVentas()
        {
            List<Impuestos> lista = ingresos.Leer();
            dgbVentas.DataSource = lista;

            dgbVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgbVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
            dgbVentas.AllowUserToAddRows = false;
            dgbVentas.ReadOnly = true;
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarDatosVentas();

            dgbVentas.Columns["idImpuesto"].HeaderText = "ID";
            dgbVentas.Columns["impuesto"].HeaderText = "Impuesto";
            dgbVentas.Columns["costo"].HeaderText = "Costo";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgbVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
