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

        private void HabitacionesDisponibles_Load(object sender, EventArgs e)
        {
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
                int indice = checkedListBoxOcupadas.Items.Add(hab2);
                if(!hab2.disponible)
                {
                    checkedListBoxOcupadas.SetItemChecked(indice, true);
                }
            }
        }
    }
}
