using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP2A1HotelHeavens.Modales
{
    public partial class mdClave : Form
    {
        public mdClave()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string clave = txtClave.Text, mensaje = string.Empty;
            bool respuesta = new CN_Empleado().Llave(clave, out mensaje);
            if (respuesta)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
                Console.WriteLine(mensaje);

        }
    }
}
