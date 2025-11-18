using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MAP2A1HotelHeavens
{
    public partial class Checkout : Form
    {

        
        public Checkout()
        {
            InitializeComponent();
        }

        private void btnConfimar_Click(object sender, EventArgs e)
        {
            List<Hotel> hotel = new List<Hotel>();
            Hotel objusuario = new Hotel();
            string mensaje = string.Empty;
            bool respuesta = new CN_Hotel().Registrar(objusuario,out mensaje);
           hotel = new CN_Hotel().Listar();

            if (!respuesta)
            {
                MessageBox.Show(mensaje);

            }

        }


        private void CheckOut_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(93, 64, 55);
            List<Impuestos> LImpuestos = new CN_Impuestos().Leer();

            decimal totalImpuestos = 0;

            foreach (Impuestos item in LImpuestos)
            {
                totalImpuestos += item.costo;
            }

        




            /*Cargar datos*/
            List<Hotel> gertrudis = new CN_Hotel().Listar();
            foreach (Hotel obj in gertrudis)
            {
                dgbUsuarios.Rows.Add(new object[] { "", obj.idUsuario, obj.nombre, obj.numero_habitacion, obj.tipo_habitacion, obj.numeroPersonas, obj.reserva, obj.salida, obj.dias_estancia, obj.dias_restantes });
                
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }

        private void lvwConsumos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
