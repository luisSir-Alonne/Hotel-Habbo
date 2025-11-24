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

namespace MAP2A1HotelHeavens
{
    public partial class HabitacionesDisponibles : Form
    {
        CN_Habitaciones hola = new CN_Habitaciones();
        public HabitacionesDisponibles()
        {
            InitializeComponent();
        }
        public void cargar()
        {
            List<Hotel> gertrudis = new CN_Hotel().Listar();
            foreach (Hotel obj in gertrudis)
            {
                dgbUsuarios.Rows.Add(new object[] {"",  obj.idUsuario, obj.nombre, obj.tipo_habitacion, obj.numero_habitacion});

            }
        }
        private void HabitacionesDisponibles_Load(object sender, EventArgs e)
        {
            cargar();
            this.BackColor = Color.Black;
            comboBoxTipo.SelectedIndex = 0;
            CargarHabitacion(comboBoxTipo.SelectedItem.ToString());
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboBoxTipo.SelectedItem.ToString();
            CargarHabitacion(seleccion);

        }
        private void CargarHabitacion(string tipo)
        {
            checkedListBoxOcupadas.Items.Clear();
            List<Habitaciones> listas = hola.Listar();

            var filtradas = listas.Where(h => h.tipo == tipo).ToList();

            foreach(var hab2 in filtradas)
            {
                if(hab2.disponible)
                {
                    int indice = checkedListBoxOcupadas.Items.Add(hab2);

                }
            }
        }

        private void dgbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgbUsuarios.Rows[indice].Cells["Id"].Value.ToString();
                }
            }
        }
        private void Fail(Control ctrl, string msg)
        {
            errorProvider1.SetError(ctrl, msg);
            lblMensaje.Text = "❌ " + msg.ToString();
            ctrl.Focus();
        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblMensaje.Text = "";

            if (txtId.Text == "0")
            {
                Fail(btnCambiar, "Elije un Cliente");
                return;
            }
            int total = 0;
            bool checado = false;
            Habitaciones habitacion = null;
            for (int i = 0; i < checkedListBoxOcupadas.Items.Count; i++)
            {
                checado = checkedListBoxOcupadas.GetItemChecked(i);
    
                if (checado)
                {
                    total++;
                    if(total > 1)
                    {
                        Fail(checkedListBoxOcupadas, "No se puede seleccionar mas de dos habitaciones");
                        return;
                    }
                    habitacion = (Habitaciones)checkedListBoxOcupadas.Items[i];
                    Console.WriteLine("Esta es la habitacion" + habitacion.habitacion);
                    break;


                }
            }
            if (!checado)
            {
                Fail(checkedListBoxOcupadas, "Selecciona una habitacion");
                return;
            }
            string numero = habitacion.habitacion, tipo = habitacion.tipo, numeroActual = dgbUsuarios.Rows[Convert.ToInt32(txtIndice.Text)].Cells["numHabitacion"].Value.ToString(), tipoActual = dgbUsuarios.Rows[Convert.ToInt32(txtIndice.Text)].Cells["tipohabitacion"].Value.ToString() ;
            int id = Convert.ToInt32(txtId.Text), idhabitacion = habitacion.idhabitacion;

            Console.WriteLine("Este es el numero actual de habitacion del usuario: " + numeroActual);
            Console.WriteLine("Este es el tipo de habtacion actual del usuario: " + tipoActual);

            Hotel cliente = new Hotel()
            {
                idUsuario = id,
                numero_habitacion = numero,
                tipo_habitacion = tipo
            };
            Habitaciones hab = new Habitaciones()
            {
                idhabitacion = idhabitacion,
                habitacion = numeroActual,
                tipo = tipoActual
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Hotel().actualizarhabitacion(cliente,  hab, out mensaje);
            if (respuesta)
            {
                dgbUsuarios.Rows.Clear();
                cargar();
                comboBoxTipo.SelectedIndex = 0;
                checkedListBoxOcupadas.Items.Clear();
                CargarHabitacion(comboBoxTipo.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
