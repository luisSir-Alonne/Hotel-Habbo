using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MAP2A1HotelHeavens
{
    public partial class Form1 : Form
    {

        private static Empleado empleadoActual; 
        // Esto es para llamar al usuario actual, es practicamente un nuevo objeto pero en si el objeto que se va a utilizar en el programa para cargar los privilegios
        public Form1(Empleado obj_empleado = null)
        {
            if (obj_empleado == null)
            {
                empleadoActual = new Empleado() { nombre = "Luis Angel Ponce Prieto", idEmpleado = 1}; 
            }
            else
            {
                empleadoActual = obj_empleado; 

            }

                InitializeComponent();
          

        }
      
        

        private static IconMenuItem MenuActivo = null;
        private static Form FormActivo = null;

        private void abrirFormulario(IconMenuItem item, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = System.Drawing.Color.White;
            }
            item.BackColor = System.Drawing.Color.Silver;
            MenuActivo = item;
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
            FormActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = System.Drawing.Color.White;
            panMostrar.Controls.Add(formulario);
            formulario.Show();
            Console.WriteLine("Se mostro el formulario");
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void imiCheckIn_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiCheckIn, new CheckIn());
            cambiarColor();
        }

        private void imiCheckOut_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiCheckOut, new Checkout());
            cambiarColor();


        }

        private void imiControlUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiControlUsuario, new ControlUsuarios());
            cambiarColor();

        }

        private void imiHotel_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiHotel, new HabitacionesDisponibles());
            cambiarColor();

        }

        private void imiVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiVentas, new Ventas());
            cambiarColor();

        }

        private void panMostrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Permiso> lista = new CN_Permiso().Listar(empleadoActual.idEmpleado);
            foreach (IconMenuItem iconmenu in msAreas.Items)
            {
                bool encontrado = lista.Any(m => m.descripcion == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;

                }
            }
            lblUsuario.Text = empleadoActual.nombre;

        }

        private void imiAdmin_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiAdmin, new Control_de_Jefes());
            cambiarColor();

        }

        private void imiControlEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiControlEmpleados, new Control_de_Empleados());
            cambiarColor();
        }

        private void msAreas_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cambiarColor();
        }
        public void cambiarColor()
        {
            foreach (IconMenuItem item in msAreas.Items)
            {
                item.BackColor = Color.FromArgb(93, 64, 55);
                if (item.Selected)
                {
                    item.BackColor = Color.FromArgb(62, 39, 35);

                }
            }
        }

        private void imiMembresia_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiMembresia, new SignIn());
            cambiarColor();
        }
    }
}
