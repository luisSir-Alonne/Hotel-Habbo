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
using System.Windows.Media;

namespace MAP2A1HotelHeavens
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            chkTyC.CheckedChanged += (s, e) => { };
            
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            lblMensaje.Text = "";
        }
        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            
        }


        private void Fail(Control ctrl, string msg)
        {
            errorProvider1.SetError(ctrl, msg);
            lblMensaje.Text = "❌ " + msg.ToString();
            ctrl.Focus();
        }

        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            const string pat = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pat, RegexOptions.IgnoreCase);
        }
     
        private void btnRegresar_Click_1(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = System.Drawing.Color.White;
            cboEstado.Items.Add(new Funciones_MySQL() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new Funciones_MySQL() { Valor = 0, Texto = "Inactivo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;
            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgbUsuarios.Rows.Add(new object[] {"", item.id, item.nombre, item.correo, item.numeroTelefono, item.edad,item.sexo, item.membresia == true ? 1:0,item.membresia == true ? "Activo":"Inactivo", item.fecha_registro });

            }
            foreach (DataGridViewColumn clm in dgbUsuarios.Columns)
            {
                if (clm.Visible == true && clm.Name != "btnSeleccionar")
                {
                    string texto = clm.HeaderText;
                    cbobusqueda.Items.Add(new Funciones_MySQL() { Valor = clm.Name, Texto = Convert.ToString(texto)});
                }
                cbobusqueda.DisplayMember = "Texto";
                cbobusqueda.ValueMember = "Valor";

                Console.WriteLine(clm.HeaderText);
                Console.WriteLine("jijijija");

            }

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { Fail(txtNombre, "Escribe tu nombre completo."); return; }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            { Fail(txtCorreo, "Escribe tu correo."); return; }

            if (!EsEmailValido(txtCorreo.Text))
            { Fail(txtCorreo, "Correo no válido."); return; }

            if (string.IsNullOrWhiteSpace(txtCorreo2.Text))
            { Fail(txtCorreo2, "Confirma tu correo."); return; }

            if (!txtCorreo.Text.Equals(txtCorreo2.Text, StringComparison.OrdinalIgnoreCase))
            { Fail(txtCorreo2, "Los correos no coinciden."); return; }

            if (!mtbTelefono.MaskFull)
            { Fail(mtbTelefono, "Completa el teléfono (10 dígitos)."); return; }
            if (!chkTyC.Checked)
            { Fail(chkTyC, "Debes aceptar los Términos y Condiciones."); return; }

            btnRegistrar.Enabled = false;
            int id = Convert.ToInt32(txtId.Text);
            string tele = mtbTelefono.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            string genero = "", edad = "", fecha_registro = "" ;
            bool encontrado = false;
            if (id == 0)
            {
                foreach (DataGridViewRow row in dgbUsuarios.Rows)
                {
                    if (Convert.ToString(row.Cells["Nombre"].Value) == txtNombre.Text && Convert.ToString(row.Cells["Correo"].Value) == txtCorreo.Text && Convert.ToString(row.Cells["telefono"].Value) == tele)
                    {
                        id = Convert.ToInt32(row.Cells["Id"].Value);
                        genero = Convert.ToString(row.Cells["sexo"].Value);
                        edad = Convert.ToString(row.Cells["edad"].Value);
                        fecha_registro = Convert.ToString(row.Cells["fecha_registro"].Value);
                        Console.WriteLine("Este es el id");
                        Console.WriteLine(id);
                        txtId.Text = id.ToString();
                        encontrado = true;
                    }
                }
            }
            else
            {

                foreach (DataGridViewRow row in dgbUsuarios.Rows)
                {
                    if (Convert.ToString(row.Cells["Nombre"].Value) == txtNombre.Text && Convert.ToString(row.Cells["Correo"].Value) == txtCorreo.Text && Convert.ToString(row.Cells["telefono"].Value) == tele)
                    {
                        id = Convert.ToInt32(row.Cells["Id"].Value);
                        Console.WriteLine("Estes es el id del else: " + id.ToString());

                        if (Convert.ToString(row.Cells["Id"].Value) == id.ToString())
                        {
                            genero = Convert.ToString(row.Cells["sexo"].Value);
                            edad = Convert.ToString(row.Cells["edad"].Value);
                            fecha_registro = Convert.ToString(row.Cells["fecha_registro"].Value);
                            txtId.Text = id.ToString();
                            encontrado = true;
                        }
                    }
                }

            }
            if (!encontrado)
            {
                
                   
                MessageBox.Show("No se encontro al usuario especificado, inserte los datos correctamente", "Usuario no Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRegistrar.Enabled = true;
                Limpiar();
                return;

                
            }
                Usuario obj_usuario = new Usuario()
                {
                    id = id,
                    nombre = txtNombre.Text,
                    correo = txtCorreo.Text,
                    numeroTelefono = tele,
                    sexo = genero,
                    edad = edad,
                    fecha_registro = fecha_registro,
                    membresia = Convert.ToInt32((((Funciones_MySQL)cboEstado.SelectedItem).Valor)) == 1 ? true : false
                    
                };
            string mensaje = string.Empty;
            bool resultado = new CN_Usuario().ImplementarMembresia(obj_usuario, out mensaje);
            Console.WriteLine("Este es el mensaje: " + mensaje);

            if (resultado)
            {
                foreach (DataGridViewRow row in dgbUsuarios.Rows)
                {
                    if (Convert.ToString(row.Cells["Id"].Value) == id.ToString())
                    {
                        row.Cells["membresia"].Value = (((Funciones_MySQL)cboEstado.SelectedItem).Texto);
                        row.Cells["estado"].Value = (((Funciones_MySQL)cboEstado.SelectedItem).Valor);

                    }
                }
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                MessageBox.Show($"Membresia modificada correctamente",
                                "Cambios establecidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
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
                    foreach (Funciones_MySQL fc in cboEstado.Items)
                    {
                        if (Convert.ToInt32(fc.Valor) == Convert.ToInt32(dgbUsuarios.Rows[indice].Cells["estado"].Value.ToString()))
                        {
                            int indice_estado = cboEstado.Items.IndexOf(fc);
                            cboEstado.SelectedIndex = indice_estado;
                            break;
                        }
                       
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
            cboEstado.SelectedIndex = 0;

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
