namespace MAP2A1HotelHeavens
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMenuCerrar = new System.Windows.Forms.Label();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.chkMostrarPass = new System.Windows.Forms.CheckBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtbPass2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbPass = new System.Windows.Forms.MaskedTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.chkTyC = new System.Windows.Forms.CheckBox();
            this.txtCorreo2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblConfirmarPass = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblConfirmarCorreo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuCerrar
            // 
            this.lblMenuCerrar.BackColor = System.Drawing.Color.Peru;
            this.lblMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.lblMenuCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuCerrar.Name = "lblMenuCerrar";
            this.lblMenuCerrar.Size = new System.Drawing.Size(883, 53);
            this.lblMenuCerrar.TabIndex = 6;
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Peru;
            this.picMinimizar.Image = global::MAP2A1HotelHeavens.Properties.Resources.menos;
            this.picMinimizar.Location = new System.Drawing.Point(769, 0);
            this.picMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(45, 53);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 8;
            this.picMinimizar.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.Peru;
            this.picCerrar.Image = global::MAP2A1HotelHeavens.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(823, 0);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(45, 53);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 7;
            this.picCerrar.TabStop = false;
            // 
            // chkMostrarPass
            // 
            this.chkMostrarPass.AutoSize = true;
            this.chkMostrarPass.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(227)))), ((int)(((byte)(220)))));
            this.chkMostrarPass.Location = new System.Drawing.Point(37, 468);
            this.chkMostrarPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMostrarPass.Name = "chkMostrarPass";
            this.chkMostrarPass.Size = new System.Drawing.Size(209, 26);
            this.chkMostrarPass.TabIndex = 39;
            this.chkMostrarPass.Text = "Mostrar contraseñas";
            this.chkMostrarPass.UseVisualStyleBackColor = true;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.mtbTelefono.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefono.Location = new System.Drawing.Point(155, 428);
            this.mtbTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTelefono.Mask = "000-000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(127, 33);
            this.mtbTelefono.TabIndex = 38;
            // 
            // mtbPass2
            // 
            this.mtbPass2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.mtbPass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbPass2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPass2.Location = new System.Drawing.Point(288, 378);
            this.mtbPass2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbPass2.Name = "mtbPass2";
            this.mtbPass2.Size = new System.Drawing.Size(529, 33);
            this.mtbPass2.TabIndex = 37;
            this.mtbPass2.UseSystemPasswordChar = true;
            // 
            // mtbPass
            // 
            this.mtbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.mtbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbPass.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPass.Location = new System.Drawing.Point(353, 325);
            this.mtbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.Size = new System.Drawing.Size(463, 33);
            this.mtbPass.TabIndex = 36;
            this.mtbPass.UseSystemPasswordChar = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(230)))), ((int)(((byte)(202)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(66)))), ((int)(((byte)(46)))));
            this.btnRegistrar.Location = new System.Drawing.Point(617, 454);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(147, 41);
            this.btnRegistrar.TabIndex = 34;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // chkTyC
            // 
            this.chkTyC.AutoSize = true;
            this.chkTyC.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTyC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.chkTyC.Location = new System.Drawing.Point(37, 500);
            this.chkTyC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTyC.Name = "chkTyC";
            this.chkTyC.Size = new System.Drawing.Size(333, 28);
            this.chkTyC.TabIndex = 33;
            this.chkTyC.Text = "Acepto los términos y condiciones";
            this.chkTyC.UseVisualStyleBackColor = true;
            // 
            // txtCorreo2
            // 
            this.txtCorreo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.txtCorreo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo2.Location = new System.Drawing.Point(169, 270);
            this.txtCorreo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo2.Name = "txtCorreo2";
            this.txtCorreo2.Size = new System.Drawing.Size(647, 33);
            this.txtCorreo2.TabIndex = 32;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(235, 167);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(582, 33);
            this.txtNombre.TabIndex = 31;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(207)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(235, 220);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(582, 33);
            this.txtCorreo.TabIndex = 30;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(143)))));
            this.lblTelefono.Location = new System.Drawing.Point(39, 432);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(105, 26);
            this.lblTelefono.TabIndex = 29;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblConfirmarPass
            // 
            this.lblConfirmarPass.AutoSize = true;
            this.lblConfirmarPass.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(143)))));
            this.lblConfirmarPass.Location = new System.Drawing.Point(32, 380);
            this.lblConfirmarPass.Name = "lblConfirmarPass";
            this.lblConfirmarPass.Size = new System.Drawing.Size(239, 26);
            this.lblConfirmarPass.TabIndex = 28;
            this.lblConfirmarPass.Text = "Confirmar contraseña:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(143)))));
            this.lblPass.Location = new System.Drawing.Point(24, 272);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(134, 26);
            this.lblPass.TabIndex = 27;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblConfirmarCorreo
            // 
            this.lblConfirmarCorreo.AutoSize = true;
            this.lblConfirmarCorreo.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(143)))));
            this.lblConfirmarCorreo.Location = new System.Drawing.Point(24, 327);
            this.lblConfirmarCorreo.Name = "lblConfirmarCorreo";
            this.lblConfirmarCorreo.Size = new System.Drawing.Size(308, 26);
            this.lblConfirmarCorreo.TabIndex = 26;
            this.lblConfirmarCorreo.Text = "Confirmar correo electrónico:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(143)))));
            this.lblCorreo.Location = new System.Drawing.Point(24, 223);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(203, 26);
            this.lblCorreo.TabIndex = 25;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(221)))), ((int)(((byte)(143)))));
            this.lblNombre.Location = new System.Drawing.Point(24, 170);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(194, 26);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre completo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(225, 79);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(547, 63);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Registro de usuario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMensaje.Location = new System.Drawing.Point(39, 532);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 26);
            this.lblMensaje.TabIndex = 40;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(465, 518);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 28);
            this.btnRegresar.TabIndex = 41;
            this.btnRegresar.Text = "button1";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(46)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(883, 580);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.chkMostrarPass);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.mtbPass2);
            this.Controls.Add(this.mtbPass);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkTyC);
            this.Controls.Add(this.txtCorreo2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblConfirmarPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblConfirmarCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.lblMenuCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignIn";
            this.Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label lblMenuCerrar;
        private System.Windows.Forms.CheckBox chkMostrarPass;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.MaskedTextBox mtbPass2;
        private System.Windows.Forms.MaskedTextBox mtbPass;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.CheckBox chkTyC;
        private System.Windows.Forms.TextBox txtCorreo2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblConfirmarPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblConfirmarCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnRegresar;
    }
}