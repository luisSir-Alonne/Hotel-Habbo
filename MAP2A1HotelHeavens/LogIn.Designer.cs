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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.checkBoxOcultar1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOcultar2 = new System.Windows.Forms.CheckBox();
            this.notifyIconMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTipInfoLogin = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuCerrar
            // 
            this.lblMenuCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.lblMenuCerrar.Name = "lblMenuCerrar";
            this.lblMenuCerrar.Size = new System.Drawing.Size(380, 43);
            this.lblMenuCerrar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(28, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(9, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxUsuario.Location = new System.Drawing.Point(89, 123);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(201, 23);
            this.textBoxUsuario.TabIndex = 8;
            this.toolTipInfoLogin.SetToolTip(this.textBoxUsuario, "Usuario");
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContraseña.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxContraseña.Location = new System.Drawing.Point(89, 162);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(201, 23);
            this.textBoxContraseña.TabIndex = 9;
            this.toolTipInfoLogin.SetToolTip(this.textBoxContraseña, "Contraseña");
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIniciar.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonIniciar.Location = new System.Drawing.Point(22, 210);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(153, 31);
            this.buttonIniciar.TabIndex = 10;
            this.buttonIniciar.Text = "Iniciar Sesion";
            this.toolTipInfoLogin.SetToolTip(this.buttonIniciar, "Inicia Sesion");
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // checkBoxOcultar1
            // 
            this.checkBoxOcultar1.AutoSize = true;
            this.checkBoxOcultar1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOcultar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkBoxOcultar1.Location = new System.Drawing.Point(312, 127);
            this.checkBoxOcultar1.Name = "checkBoxOcultar1";
            this.checkBoxOcultar1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOcultar1.TabIndex = 11;
            this.toolTipInfoLogin.SetToolTip(this.checkBoxOcultar1, "Ocultar");
            this.checkBoxOcultar1.UseVisualStyleBackColor = false;
            this.checkBoxOcultar1.CheckedChanged += new System.EventHandler(this.checkBoxOcultar1_CheckedChanged);
            // 
            // checkBoxOcultar2
            // 
            this.checkBoxOcultar2.AutoSize = true;
            this.checkBoxOcultar2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOcultar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkBoxOcultar2.Location = new System.Drawing.Point(312, 168);
            this.checkBoxOcultar2.Name = "checkBoxOcultar2";
            this.checkBoxOcultar2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOcultar2.TabIndex = 12;
            this.toolTipInfoLogin.SetToolTip(this.checkBoxOcultar2, "Ocultar");
            this.checkBoxOcultar2.UseVisualStyleBackColor = false;
            this.checkBoxOcultar2.CheckedChanged += new System.EventHandler(this.checkBoxOcultar2_CheckedChanged);
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
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCancelar.Location = new System.Drawing.Point(206, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.toolTipInfoLogin.SetToolTip(this.btnCancelar, "Inicia Sesion");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MAP2A1HotelHeavens.Properties.Resources.imgLoginHotelHeavensLP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(380, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkBoxOcultar2);
            this.Controls.Add(this.checkBoxOcultar1);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMenuCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnCancelar;
    }
}