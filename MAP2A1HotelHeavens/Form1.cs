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
        public Form1()
        {
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
        }

        private void imiCheckOut_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiCheckOut, new CheckOut());

        }

        private void imiControlUsuario_Click(object sender, EventArgs e)
        {

        }

        private void imiHotel_Click(object sender, EventArgs e)
        {
            abrirFormulario(imiHotel, new HabitacionesDisponibles());

        }
    }
}
