namespace MAP2A1HotelHeavens
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.checkBoxOcultar1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOcultar2 = new System.Windows.Forms.CheckBox();
            this.notifyIconMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTipInfoLogin = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuCerrar
            // 
            this.lblMenuCerrar.BackColor = System.Drawing.Color.Peru;
            this.lblMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.lblMenuCerrar.Name = "lblMenuCerrar";
            this.lblMenuCerrar.Size = new System.Drawing.Size(379, 43);
            this.lblMenuCerrar.TabIndex = 3;
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Peru;
            this.picMinimizar.Image = global::MAP2A1HotelHeavens.Properties.Resources.menos;
            this.picMinimizar.Location = new System.Drawing.Point(305, 0);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(34, 43);
            this.picMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimizar.TabIndex = 5;
            this.picMinimizar.TabStop = false;
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.Peru;
            this.picCerrar.Image = global::MAP2A1HotelHeavens.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(345, 0);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 43);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 4;
            this.picCerrar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(148, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(131, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxUsuario.Location = new System.Drawing.Point(87, 120);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PasswordChar = '*';
            this.textBoxUsuario.Size = new System.Drawing.Size(197, 25);
            this.textBoxUsuario.TabIndex = 8;
            this.toolTipInfoLogin.SetToolTip(this.textBoxUsuario, "Usuario");
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxContraseña.Location = new System.Drawing.Point(87, 191);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(197, 25);
            this.textBoxContraseña.TabIndex = 9;
            this.toolTipInfoLogin.SetToolTip(this.textBoxContraseña, "Contraseña");
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.Chocolate;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIniciar.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonIniciar.Location = new System.Drawing.Point(112, 247);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(153, 41);
            this.buttonIniciar.TabIndex = 10;
            this.buttonIniciar.Text = "Iniciar Sesion";
            this.toolTipInfoLogin.SetToolTip(this.buttonIniciar, "Presiona el boton una vez\r\ninsertado los datos");
            this.buttonIniciar.UseVisualStyleBackColor = false;
            // 
            // checkBoxOcultar1
            // 
            this.checkBoxOcultar1.AutoSize = true;
            this.checkBoxOcultar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkBoxOcultar1.Location = new System.Drawing.Point(300, 124);
            this.checkBoxOcultar1.Name = "checkBoxOcultar1";
            this.checkBoxOcultar1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOcultar1.TabIndex = 11;
            this.checkBoxOcultar1.UseVisualStyleBackColor = true;
            // 
            // checkBoxOcultar2
            // 
            this.checkBoxOcultar2.AutoSize = true;
            this.checkBoxOcultar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkBoxOcultar2.Location = new System.Drawing.Point(300, 195);
            this.checkBoxOcultar2.Name = "checkBoxOcultar2";
            this.checkBoxOcultar2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOcultar2.TabIndex = 12;
            this.checkBoxOcultar2.UseVisualStyleBackColor = true;
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Visible = true;
            // 
            // toolTipInfoLogin
            // 
            this.toolTipInfoLogin.BackColor = System.Drawing.Color.Black;
            this.toolTipInfoLogin.ForeColor = System.Drawing.Color.Goldenrod;
            this.toolTipInfoLogin.IsBalloon = true;
            this.toolTipInfoLogin.ToolTipTitle = "Login";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MAP2A1HotelHeavens.Properties.Resources.imgLoginHotelHeavensLP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 398);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxOcultar2);
            this.Controls.Add(this.checkBoxOcultar1);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.lblMenuCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label lblMenuCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.CheckBox checkBoxOcultar1;
        private System.Windows.Forms.CheckBox checkBoxOcultar2;
        private System.Windows.Forms.NotifyIcon notifyIconMenu;
        private System.Windows.Forms.ToolTip toolTipInfoLogin;
    }
}