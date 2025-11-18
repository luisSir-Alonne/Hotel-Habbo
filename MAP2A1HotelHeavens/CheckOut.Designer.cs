namespace MAP2A1HotelHeavens
{
    partial class Checkout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgbUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diasdeestancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diasrestantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMenuCerrar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbUsuarios
            // 
            this.dgbUsuarios.AllowUserToAddRows = false;
            this.dgbUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.dgbUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.Id,
            this.nombre,
            this.NumerHabitacion,
            this.NumeroHabitacion,
            this.NumPersonas,
            this.Reserva,
            this.Salida,
            this.Diasdeestancia,
            this.Diasrestantes});
            this.dgbUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.dgbUsuarios.Location = new System.Drawing.Point(495, 222);
            this.dgbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgbUsuarios.Name = "dgbUsuarios";
            this.dgbUsuarios.RowHeadersWidth = 51;
            this.dgbUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbUsuarios.Size = new System.Drawing.Size(1313, 470);
            this.dgbUsuarios.TabIndex = 99;
            this.dgbUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbUsuarios_CellContentClick);
            // 
            // btnSeleccionar
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle10;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Width = 50;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.Id.DefaultCellStyle = dataGridViewCellStyle11;
            this.Id.HeaderText = "id Usuario ";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.nombre.DefaultCellStyle = dataGridViewCellStyle12;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // NumerHabitacion
            // 
            this.NumerHabitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.NumerHabitacion.DefaultCellStyle = dataGridViewCellStyle13;
            this.NumerHabitacion.HeaderText = "Numero de Habitación";
            this.NumerHabitacion.MinimumWidth = 6;
            this.NumerHabitacion.Name = "NumerHabitacion";
            this.NumerHabitacion.ReadOnly = true;
            // 
            // NumeroHabitacion
            // 
            this.NumeroHabitacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.NumeroHabitacion.DefaultCellStyle = dataGridViewCellStyle14;
            this.NumeroHabitacion.HeaderText = "Tipo de Habitación";
            this.NumeroHabitacion.MinimumWidth = 6;
            this.NumeroHabitacion.Name = "NumeroHabitacion";
            this.NumeroHabitacion.ReadOnly = true;
            // 
            // NumPersonas
            // 
            this.NumPersonas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.NumPersonas.DefaultCellStyle = dataGridViewCellStyle15;
            this.NumPersonas.HeaderText = "Numero de personas";
            this.NumPersonas.MinimumWidth = 6;
            this.NumPersonas.Name = "NumPersonas";
            this.NumPersonas.ReadOnly = true;
            // 
            // Reserva
            // 
            this.Reserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.Reserva.DefaultCellStyle = dataGridViewCellStyle16;
            this.Reserva.HeaderText = "Reserva ";
            this.Reserva.MinimumWidth = 6;
            this.Reserva.Name = "Reserva";
            this.Reserva.ReadOnly = true;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.MinimumWidth = 6;
            this.Salida.Name = "Salida";
            this.Salida.Width = 125;
            // 
            // Diasdeestancia
            // 
            this.Diasdeestancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.Diasdeestancia.DefaultCellStyle = dataGridViewCellStyle17;
            this.Diasdeestancia.HeaderText = "Dias de estancia";
            this.Diasdeestancia.MinimumWidth = 6;
            this.Diasdeestancia.Name = "Diasdeestancia";
            this.Diasdeestancia.ReadOnly = true;
            // 
            // Diasrestantes
            // 
            this.Diasrestantes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.Diasrestantes.DefaultCellStyle = dataGridViewCellStyle18;
            this.Diasrestantes.HeaderText = "Dias restantes ";
            this.Diasrestantes.MinimumWidth = 6;
            this.Diasrestantes.Name = "Diasrestantes";
            this.Diasrestantes.ReadOnly = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(20, 564);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 25);
            this.lblMensaje.TabIndex = 97;
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 18;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(1381, 138);
            this.btnlimpiarbuscador.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(72, 28);
            this.btnlimpiarbuscador.TabIndex = 96;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(493, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1005, 54);
            this.label10.TabIndex = 91;
            this.label10.Text = "Lista De Usuarios";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIndice
            // 
            this.txtIndice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.txtIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIndice.ForeColor = System.Drawing.Color.White;
            this.txtIndice.Location = new System.Drawing.Point(597, 70);
            this.txtIndice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(75, 30);
            this.txtIndice.TabIndex = 90;
            this.txtIndice.Text = "0";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(500, 70);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(75, 30);
            this.txtId.TabIndex = 89;
            this.txtId.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 18;
            this.btnbuscar.Location = new System.Drawing.Point(1301, 138);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(72, 28);
            this.btnbuscar.TabIndex = 95;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(1113, 140);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(179, 22);
            this.txtbusqueda.TabIndex = 94;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(891, 139);
            this.cbobusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(187, 24);
            this.cbobusqueda.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(801, 144);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 92;
            this.label11.Text = "Buscar Por: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(495, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Usuarios:";
            // 
            // lblMenuCerrar
            // 
            this.lblMenuCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.lblMenuCerrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuCerrar.Name = "lblMenuCerrar";
            this.lblMenuCerrar.Size = new System.Drawing.Size(1821, 53);
            this.lblMenuCerrar.TabIndex = 79;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(495, 716);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 46);
            this.btnEliminar.TabIndex = 100;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1821, 784);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgbUsuarios);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMenuCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgbUsuarios;
        private System.Windows.Forms.Label lblMensaje;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMenuCerrar;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diasdeestancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diasrestantes;
        private System.Windows.Forms.Button btnEliminar;
    }
}