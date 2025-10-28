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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            chkTyC.CheckedChanged += (s, e) => { };
            chkMostrarPass.CheckedChanged += chkMostrarPass_CheckedChanged;
            btnRegistrar.Click += btnRegistrar_Click;
            btnRegresar.Click += (s, e) => this.Close();

            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            mtbPass.UseSystemPasswordChar = true;
            mtbPass2.UseSystemPasswordChar = true;
            lblMensaje.Text = "";
        }
        private void chkMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = chkMostrarPass.Checked;
            mtbPass.UseSystemPasswordChar = !mostrar;
            mtbPass2.UseSystemPasswordChar = !mostrar;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
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

            var passMsg = ValidaPassword(mtbPass.Text);
            if (passMsg != null)
            { Fail(mtbPass, passMsg); return; }

            if (string.IsNullOrEmpty(mtbPass2.Text))
            { Fail(mtbPass2, "Confirma tu contraseña."); return; }

            if (mtbPass.Text != mtbPass2.Text)
            { Fail(mtbPass2, "Las contraseñas no coinciden."); return; }


            if (!chkTyC.Checked)
            { Fail(chkTyC, "Debes aceptar los Términos y Condiciones."); return; }

            MessageBox.Show($"¡Registro exitoso!\n\nBienvenido/a, {txtNombre.Text}.",
                            "Aerolínea", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void Fail(Control ctrl, string msg)
        {
            errorProvider1.SetError(ctrl, msg);
            lblMensaje.Text = "❌ " + msg;
            ctrl.Focus();
        }

        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            const string pat = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pat, RegexOptions.IgnoreCase);
        }

        private string ValidaPassword(string p)
        {
            if (string.IsNullOrEmpty(p)) return "Escribe una contraseña.";
            if (p.Length < 8) return "La contraseña debe tener al menos 8 caracteres.";
            bool may = false, min = false, dig = false;
            foreach (char c in p)
            {
                if (char.IsUpper(c)) may = true;
                else if (char.IsLower(c)) min = true;
                else if (char.IsDigit(c)) dig = true;
            }
            if (!may || !min || !dig)
                return "Incluye mayúsculas, minúsculas y números.";
            return null; 
        }
     
        private void btnRegresar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
