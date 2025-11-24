using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP2A1HotelHeavens
{
    public partial class CheckIn : Form
    {
        string tradicinal = "", suit = "", presidencial = "";
        RadioButton[] select;
        public CheckIn()
        {
            InitializeComponent();

            select=new RadioButton[]{radHabNormal,radHabPresidencial,radHabSuit};
        }
        public void cargar()
        {
            List<Hotel> gertrudis = new CN_Hotel().Listar();
            foreach (Hotel obj in gertrudis)
            {
                dgbUsuarios.Rows.Add(new object[] { "", obj.idUsuario, obj.nombre,obj.tipo_habitacion, obj.numero_habitacion, obj.numeroPersonas,obj.menores, obj.reserva, obj.salida, obj.dias_estancia, obj.dias_restantes });

            }
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            dtpInicioEstancia.MinDate = DateTime.Today;
            dtpFinaldeEstancia.MinDate = DateTime.Today.AddDays(1);
            dtpFinaldeEstancia.Value = dtpFinaldeEstancia.MinDate;
            mtcFecha.MinDate = DateTime.Today;
            cargar();
            cargarhabitaciones(radHabNormal.Text);

        }

        private void lblTipodehabitacion_Click(object sender, EventArgs e)
        {

        }

        private void radHabSuit_CheckedChanged(object sender, EventArgs e)
        {
            if (radHabSuit.Checked)
            {
                cargarhabitaciones(radHabSuit.Text);

            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dtpInicioEstancia.Value = mtcFecha.SelectionRange.Start;
            if (mtcFecha.SelectionRange.Start != mtcFecha.SelectionRange.End)
            {
                dtpFinaldeEstancia.Value = mtcFecha.SelectionRange.End;
            }
            else
            {
                dtpFinaldeEstancia.Value = DateTime.Now.AddDays(1);

            }
        }

        private void gpbFecha_Enter(object sender, EventArgs e)
        {

        }

        private void Fail(Control ctrl, string msg)
        {
            epValidacion.SetError(ctrl, msg);
            lblMensaje.Text = "❌ " + msg;
            ctrl.Focus();
        }

        private void radHabNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radHabNormal.Checked)
            {
                cargarhabitaciones(radHabNormal.Text);
            }
        }

        private void radHabPresidencial_CheckedChanged(object sender, EventArgs e)
        {
            if (radHabPresidencial.Checked)
            {
                cargarhabitaciones(radHabPresidencial.Text);

            }
        }

        private void dgbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                Fail(txtNombre, "Inserta el nombre del huesped");
                return;
            }
            if (nudAdultos.Value < 1)
            {
                Fail(nudAdultos, "Al menos un adulto debe ingresar");
                return;
            }
            RadioButton[] radio = { radHabNormal, radHabPresidencial, radHabSuit };
            string tipo = "";

            foreach (RadioButton rb in radio)
            {
                if (rb.Checked)
                {
                    tipo = rb.Text;
                }
            }
            if (tipo == "")
            {
                Fail(grbTipodeHabitacion, "Es necesario el tipo de habitacion");
                return;
            }
            if (cboHabitacion.SelectedItem == null)
            {
                Fail(cboHabitacion, "Es necesario el numero de habitacion");

            }
            string nombre = txtNombre.Text;
            int numeroAdultos = Convert.ToInt32(nudAdultos.Value );
            int numeroMenores = Convert.ToInt32(nudMenores.Value );
            DateTime reserva = dtpInicioEstancia.Value, salida = dtpFinaldeEstancia.Value;
            int estancia = salida.Day - reserva.Day;
            int restantes = 0;
            string numerohabitacion = cboHabitacion.Text;
            Console.WriteLine("Este es el numero de habitacion: " + numerohabitacion);


            if (reserva <= DateTime.Today)
            {
                restantes = estancia - DateTime.Now.Day;
            }
            Hotel obj = new Hotel()
            {
                nombre = nombre,
                salida = salida,
                reserva = reserva,
                numeroPersonas = numeroAdultos,
                menores = numeroMenores,
                dias_estancia = estancia,
                dias_restantes = restantes,
                numero_habitacion = numerohabitacion,
                tipo_habitacion = tipo,
                



            };
            Console.WriteLine(estancia);
            string mensaje = string.Empty;
            int idgenerado = new CN_Hotel().Registrar(obj, out mensaje);

            Console.WriteLine(mensaje);
            if (idgenerado != 0)
            {
                
                    dgbUsuarios.Rows.Clear();
                cargar();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void cargarhabitaciones(string tipo)
        {
            cboHabitacion.Items.Clear();
            List<Habitaciones> listas = new CN_Habitaciones().Listar();

            var filtradas = listas.Where(h => h.tipo == tipo).ToList();
            foreach (var hab in filtradas)
            {
                cboHabitacion.Items.Add(new Funciones_MySQL() { Valor = hab.habitacion, Texto = hab.habitacion });

            }
            cboHabitacion.DisplayMember = "Texto";
            cboHabitacion.ValueMember = "Texto";


        }

    }
}
