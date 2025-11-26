using CapaEntidad;
using CapaNegocio;
using MAP2A1HotelHeavens.Modales;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP2A1HotelHeavens
{
    public partial class Control_de_Empleados : Form
    {
        public Control_de_Empleados()
        {
            InitializeComponent();
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            revisar();
            btnRegistrar.Enabled = false;
            string nombre = txtNombre.Text.Trim(), clave = txtClave.Text.Trim(), correo = txtCorreo.Text.Trim();
            string mensaje = string.Empty;
            Empleado usr = new Empleado()
            {
                oRol = new Rol() { IdRol = 2, descripcion = "EMPLEADO" },
                idEmpleado = Convert.ToInt32(txtId.Text),
                nombre = nombre,
                correo = correo,
                clave = clave,
                fecha = DateTime.Now.ToString()

            };

            if (usr.idEmpleado == 0)
            {
                int idusuario = new CN_Empleado().Registrar(usr, out mensaje);
                Console.WriteLine("Este es el id del usuario" + idusuario.ToString());
                Console.WriteLine("Este es el mensaje " + mensaje.ToString());
                if (idusuario != 0)
                {
                    dgbUsuarios.Rows.Clear();
                    cargar();

                }
                else
                {
                    MessageBox.Show(mensaje, "El usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                bool resultado = new CN_Empleado().Editar(usr, out mensaje);
                if (resultado)
                {
                    dgbUsuarios.Rows.Clear();
                    cargar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            btnRegistrar.Enabled = true;
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtCorreo2.Text = "";
            txtId.Text = "0";
            txtIndice.Text = "";
            txtbusqueda.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";

        }
        public void cargar()
        {
            List<Empleado> listaempleados = new CN_Empleado().Listar();
            foreach (Empleado emp in listaempleados)
            {
                if (emp.oRol.IdRol == 2)
                {
                    dgbUsuarios.Rows.Add(new object[] { "", emp.idEmpleado, emp.nombre, emp.correo, emp.clave, emp.oRol.IdRol, emp.oRol.descripcion, emp.fecha });
                }

            }
        }
        private void Fail(Control ctrl, string msg)
        {
            epValidacion.SetError(ctrl, msg);
            lblMensaje.Text = "❌ " + msg;
            ctrl.Focus();
        }

        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            const string pat = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pat, RegexOptions.IgnoreCase);
        }
        public void revisar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { Fail(txtNombre, "Escribe el nombre completo."); return; }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            { Fail(txtCorreo, "Escribe el correo."); return; }

            if (!EsEmailValido(txtCorreo.Text))
            { Fail(txtCorreo, "Correo no válido."); return; }

            if (string.IsNullOrWhiteSpace(txtCorreo2.Text))
            { Fail(txtCorreo2, "Confirma el correo."); return; }

            if (!txtCorreo.Text.Equals(txtCorreo2.Text, StringComparison.OrdinalIgnoreCase))
            { Fail(txtCorreo2, "Los correos no coinciden."); return; }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                Fail(txtClave, "Escribe una clave");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmarClave.Text))
            {
                Fail(txtConfirmarClave, "Confirma la clave");
                return;
            }
            if (!txtCorreo.Text.Equals(txtCorreo2.Text, StringComparison.OrdinalIgnoreCase))
            {
                Fail(txtCorreo2, "Los correos no coinciden"); return;
            }
        }

        private void Control_de_Empleados_Load(object sender, EventArgs e)
        {
            cargar();
            foreach (DataGridViewColumn clm in dgbUsuarios.Columns)
            {
                if (clm.Visible && clm.Name != "btnSeleccionar")
                {
                    string texto = clm.HeaderText;
                    cbobusqueda.Items.Add(new Funciones_MySQL() { Valor = clm.Name, Texto = Convert.ToString(texto) });

                }
                cbobusqueda.DisplayMember = "Texto";
                cbobusqueda.ValueMember = "Valor";
                Console.WriteLine(clm.HeaderText);

            }
        }

        private void btnVerClaves_Click(object sender, EventArgs e)
        {
            if (!dgbUsuarios.Columns["Clave"].Visible)
            {
                btnVerClaves.Enabled = false;
                using (var modal = new mdClave())
                {
                    var result = modal.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        if (!dgbUsuarios.Columns["Clave"].Visible)
                        {
                            dgbUsuarios.Columns["Clave"].Visible = true;
                        }
                        else
                        {
                            dgbUsuarios.Columns["Clave"].Visible = false;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Clave no valida");

                    }
                }
            }
            else
            {
                dgbUsuarios.Columns["Clave"].Visible = false;
            }
            btnVerClaves.Enabled = true;
                
        }

        private void dgbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                Console.WriteLine("Este es el indice" + indice.ToString());

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgbUsuarios.Rows[indice].Cells["Id"].Value.ToString();
                    txtCorreo.Text = dgbUsuarios.Rows[indice].Cells["Correo"].Value.ToString();
                    txtCorreo2.Text = dgbUsuarios.Rows[indice].Cells["Correo"].Value.ToString();
                    txtNombre.Text = dgbUsuarios.Rows[indice].Cells["nombre"].Value.ToString();
                    txtConfirmarClave.Text = dgbUsuarios.Rows[indice].Cells["clave"].Value.ToString();
                    txtClave.Text = dgbUsuarios.Rows[indice].Cells["clave"].Value.ToString();
                }
            }
        }

        private void btnAscender_Click(object sender, EventArgs e)
        {
            revisar();
            string nombre = txtNombre.Text, clave = txtClave.Text, correo = txtCorreo.Text;
            string mensaje = string.Empty;
            Empleado usr = new Empleado()
            {
                oRol = new Rol() { IdRol = 1, descripcion = "ADMINISTRADOR" },

                idEmpleado = Convert.ToInt32(txtId.Text)
            };
            if (usr.idEmpleado == 0)
            {
                MessageBox.Show("Elije un Administrador para Degradar", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                btnAscender.Enabled = false;

                bool resultado = new CN_Empleado().Ascender(usr, out mensaje);
                if (resultado)
                {
                    dgbUsuarios.Rows.Clear();
                    cargar();
                }
                else
                {
                    MessageBox.Show(mensaje, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            btnAscender.Enabled = true;
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((txtId.Text == "0"))
            {
                Fail(btnEliminar, "Selecciona el Usuario a Eliminar");
                return;
            }
            else
            {
                btnEliminar.Enabled = false;

                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el Empleado?", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Empleado obj_empleado = new Empleado()
                    {
                        idEmpleado = Convert.ToInt32(txtId.Text)

                    };
                    bool resultado = new CN_Empleado().Eliminar(obj_empleado, out mensaje);
                    if (resultado)
                    {
                        dgbUsuarios.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            btnEliminar.Enabled = true;
            Limpiar();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbobusqueda.Text))
            {
                Fail(cbobusqueda, "Selecciona una opcion");
                return;
            }
            string columnaFiltro = (((Funciones_MySQL)cbobusqueda.SelectedItem).Valor.ToString());
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

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgbUsuarios.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
