using CapaEntidad;
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

namespace MAP2A1HotelHeavens
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            List<Empleado> listaUsuarios = new CN_Empleado().Listar();
            Empleado ousuario = new CN_Empleado().Listar().Where(u => u.nombre == textBoxUsuario.Text && u.clave == textBoxContraseña.Text).FirstOrDefault();
            if (ousuario != null)
            {
                var n = new Form1();
                n.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("No se encontro al usuario");
                return;
            }
        }

        private void checkBoxOcultar1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOcultar1.Checked)
            {
                textBoxUsuario.PasswordChar = '*';
            }
            else
            {
                textBoxUsuario.PasswordChar = ' ';
            }
        }

        private void checkBoxOcultar2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOcultar2.Checked)
            {
                textBoxContraseña.PasswordChar = '*';
            }
            else
            {
                
            }
        }
    }
}
