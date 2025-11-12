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
using System.Windows.Forms;

namespace MAP2A1HotelHeavens
{
    public partial class CheckOut : Form
    {

        
        public CheckOut()
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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }
    }
}
