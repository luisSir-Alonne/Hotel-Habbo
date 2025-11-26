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
            cboNoDisponibles.SelectedIndex = 0;
            CargarHabitacion(comboBoxTipo.SelectedItem.ToString());
            cargarnodisponibles(cboNoDisponibles.SelectedItem.ToString());
            foreach (DataGridViewColumn clm in dgbUsuarios.Columns)
            {
                if (clm.Visible == true && clm.Name != "btnSeleccionar")
                {
                    string texto = clm.HeaderText;
                    cbobusqueda.Items.Add(new Funciones_MySQL() { Valor = clm.Name, Texto = Convert.ToString(texto) });
                }
                cbobusqueda.DisplayMember = "Texto";
                cbobusqueda.ValueMember = "Valor";

                Console.WriteLine(clm.HeaderText);
                Console.WriteLine("jijijija");

            }

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
        private void cargarnodisponibles(string tipo)
        {
            clbNoDisponibles.Items.Clear();
            List<Habitaciones> lista = new CN_Habitaciones().Listar();
            var filtradas = lista.Where(h => h.tipo == tipo).ToList();
            foreach (var item in filtradas)
            {
                if (!item.disponible)
                {
                    int indice = clbNoDisponibles.Items.Add(item);

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
                    else { 
                        habitacion = (Habitaciones)checkedListBoxOcupadas.Items[i];
                    Console.WriteLine("Esta es la habitacion" + habitacion.habitacion);
                        }

                }
            }
            if (habitacion == null)
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
                limpiarseleccion();
                limpiar();

            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cboNoDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarnodisponibles(cboNoDisponibles.SelectedItem.ToString());

        }

        private void btnDesalojar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblMensaje.Text = "";
             int total = 0;
            bool checado = false;
            Habitaciones habitacion = null;
            for (int i = 0; i < clbNoDisponibles.Items.Count; i++)
            {
                checado = clbNoDisponibles.GetItemChecked(i);

                if (checado)
                {
                    total++;
                    if (total > 1)
                    {
                        Fail(clbNoDisponibles, "No se puede seleccionar mas de dos habitaciones");
                        return;
                    }
                    habitacion = (Habitaciones)clbNoDisponibles.Items[i];
                    Console.WriteLine("Esta es la habitacion" + habitacion.habitacion);
                    break;


                }
            }
            if (habitacion == null)
            {
                Fail(clbNoDisponibles, "Selecciona una habitacion asignada");
                return;
            }
            string numeroActual = habitacion.habitacion, tipoActual = habitacion.tipo;
            int id = Convert.ToInt32(txtId.Text), idhabitacion = habitacion.idhabitacion;
            Console.WriteLine();
            Habitaciones hab = new Habitaciones()
            {
                habitacion = numeroActual,
                tipo = tipoActual,
                disponible = false
            };
           
            string mensaje = string.Empty;

            bool resultado = new CN_Hotel().editarhabitacion( hab, out mensaje);
            if (resultado)
            {
                limpiarseleccion();
                limpiar();

            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void limpiarseleccion()
        {
            dgbUsuarios.Rows.Clear();
            cargar();
            comboBoxTipo.SelectedIndex = 0;
            checkedListBoxOcupadas.Items.Clear();
            CargarHabitacion(comboBoxTipo.SelectedItem.ToString());
            cboNoDisponibles.SelectedIndex = 0;
            cargarnodisponibles(cboNoDisponibles.SelectedItem.ToString());

        }

        private void btnAlojar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblMensaje.Text = "";

            if (txtId.Text == "0")
            {
                Fail(btnAlojar, "Elije un Cliente");
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
                    if (total > 1)
                    {
                        Fail(checkedListBoxOcupadas, "No se puede seleccionar mas de dos habitaciones");
                        return;
                    }
                    habitacion = (Habitaciones)checkedListBoxOcupadas.Items[i];
                    Console.WriteLine("Esta es la habitacion" + habitacion.habitacion);
                    break;


                }
            }
            if (habitacion == null)
            {
                Fail(checkedListBoxOcupadas, "Selecciona una habitacion");
                return;
            }
            if (dgbUsuarios.Rows[Convert.ToInt32(txtIndice.Text)].Cells["numHabitacion"].Value.ToString() != "No asignada")
            {
                Fail(btnAlojar, "Habitacion ya asignada");
                return;
            }
            Console.WriteLine("Este es el estado de la habitacion" + habitacion.habitacion);
            string numero = habitacion.habitacion, tipo = habitacion.tipo;
                int id = Convert.ToInt32(txtId.Text), idhabitacion = habitacion.idhabitacion;


            Hotel cliente = new Hotel()
            {
                idUsuario = id,
            };
            Habitaciones hab = new Habitaciones()
            {
                idhabitacion = idhabitacion,
                habitacion = numero,
                tipo = tipo
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Hotel().alojar(hab, cliente, out mensaje);
            if (respuesta)
            {
                limpiarseleccion();
                limpiar();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void limpiar()
        {
            txtId.Text = "0";
            txtIndice.Text = "";
           
        }
    }
}
