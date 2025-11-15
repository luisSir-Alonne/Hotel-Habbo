using CapaEntidad;
using CapaNegocio;
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
    public partial class ControlUsuarios : Form
    {
        public ControlUsuarios()
        {
            InitializeComponent();
            
            epValidacion.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            lblMensaje.Text = "";
        }

        private void ControlUsuarios_Load(object sender, EventArgs e)
        {

            lblMensaje.ForeColor = System.Drawing.Color.White;

            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgbUsuarios.Rows.Add(new object[] { "", item.id, item.nombre, item.correo, item.numeroTelefono, item.edad, item.sexo });

            }
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

        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Se ejecuto el boton de registrar");
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

            if (!mtbTelefono.MaskFull)
            { Fail(mtbTelefono, "Completa el teléfono (10 dígitos)."); return; }
            btnRegistrar.Enabled = false;

            string nombre = txtNombre.Text, edad = Convert.ToString(nudEdad.Value), tele = mtbTelefono.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""), correo = txtCorreo.Text, sexo = "";
            RadioButton[] radio = { rbFemenino, rbMasculino };
            foreach (RadioButton rb in radio)
            {
                if (rb.Checked)
                {
                    sexo = rb.Text;
                }
            }
            if (string.IsNullOrWhiteSpace(sexo))
            {
                Fail(gpbSexo, "Selecciona un sexo");
                return;
            }

            /**
             * Comienza el codigo para poder Registrar un usuario
             */
            string Mensaje = string.Empty;
            Usuario obj_usuario = new Usuario()
            {
                id = Convert.ToInt32(txtId.Text),
                nombre = txtNombre.Text,
                correo = txtCorreo.Text,
                numeroTelefono = tele,
                sexo = sexo,
                membresia = false,
                edad = edad,
                fecha_registro = ""

            };
            if (obj_usuario.id == 0)
            {
                int usuariogenerado = new CN_Usuario().Registrar(obj_usuario, out Mensaje);
                Console.WriteLine("Este es el id generado aplicado" + usuariogenerado);
                if (usuariogenerado != 0)
                {
                    dgbUsuarios.Rows.Add(new object[] { "", usuariogenerado, nombre, correo, tele, edad, sexo });

                }
                else
                {

                    MessageBox.Show(Mensaje, "El usuario ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                bool resultado = new CN_Usuario().Editar(obj_usuario, out Mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgbUsuarios.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["nombre"].Value = nombre;
                    row.Cells["telefono"].Value = tele;
                    row.Cells["Correo"].Value = correo;
                    row.Cells["edad"].Value = edad;
                    row.Cells["sexo"].Value = sexo;

                }
                else
                {

                    MessageBox.Show(Mensaje, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            btnRegistrar.Enabled = true;
            Limpiar();


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
                    mtbTelefono.Text = dgbUsuarios.Rows[indice].Cells["telefono"].Value.ToString();
                    nudEdad.Value = Convert.ToDecimal(dgbUsuarios.Rows[indice].Cells["edad"].Value);
                    string sexo = dgbUsuarios.Rows[indice].Cells["sexo"].Value.ToString();
                    RadioButton[] radio = { rbFemenino, rbMasculino };
                    foreach (RadioButton rb in radio)
                    {
                        if (rb.Text == sexo)
                        {
                            rb.Checked = true;
                        }
                    }
                }
            }
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
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtCorreo2.Text = "";
            txtId.Text = "0";
            txtIndice.Text = "";
            txtbusqueda.Text = "";
            mtbTelefono.Text = "";
            RadioButton[] radio = { rbFemenino, rbMasculino };
            foreach (RadioButton rb in radio)
            {
                rb.Checked = false;

            }
            nudEdad.Value = 0M;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                Fail(btnEliminar, "Selecciona el Usuario a Eliminar");
                return;
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el Usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario obj_usuario = new Usuario()
                    {
                        id = Convert.ToInt32(txtId.Text)

                    };
                    bool resultado = new CN_Usuario().Eliminar(obj_usuario, out mensaje);
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

        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgbUsuarios.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
