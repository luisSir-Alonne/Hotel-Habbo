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
           

        }


        private void CheckOut_Load(object sender, EventArgs e)
        {
          
        




            /*Cargar datos*/
            List<Hotel> gertrudis = new CN_Hotel().Listar();
            foreach (Hotel obj in gertrudis)
            {
                dgbUsuarios.Rows.Add(new object[] { "", obj.idUsuario, obj.nombre, obj.numero_habitacion, obj.tipo_habitacion, obj.numeroPersonas, obj.menores, obj.reserva, obj.salida, obj.dias_estancia, obj.dias_restantes });
                
            }


            foreach (DataGridViewColumn clm in dgbUsuarios.Columns)
            {
                if (clm.Visible == true && clm.Name != "btnSeleccionar")
                {
                    string texto = clm.HeaderText;
                    cboBuscar.Items.Add(new Funciones_MySQL() { Valor = clm.Name, Texto = Convert.ToString(texto) });
                }
                cboBuscar.DisplayMember = "Texto";
                cboBuscar.ValueMember = "Valor";

                Console.WriteLine(clm.HeaderText);
                Console.WriteLine("jijijija");

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

        private void dgbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbUsuarios.Columns[e.ColumnIndex].Name== "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgbUsuarios.Rows[indice].Cells["Id"].Value.ToString();
                }
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Hotel semen = new Hotel()
            {
                idUsuario= Convert.ToInt32(txtId.Text)

            };
            string pene = string.Empty;



            bool EL = new CN_Hotel().Eliminar(semen, out pene);
            if (EL)
            {
                MessageBox.Show("Usuario eliminado correctamente");
                dgbUsuarios.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario: " + pene);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboBuscar.Text))
            {
                Fail(cboBuscar, "Selecciona una opcion");
                return;
            }
            string columnaFiltro = (((Funciones_MySQL)cboBuscar.SelectedItem).Valor.ToString());
            if (dgbUsuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgbUsuarios.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
        private void Fail(Control ctrl, string msg)
        {
            errorProvider1.SetError(ctrl, msg);
            lblMensaje.Text = "❌ " + msg.ToString();
            ctrl.Focus();
        }
        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgbUsuarios.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
