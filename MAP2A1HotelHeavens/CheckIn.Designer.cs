namespace MAP2A1HotelHeavens
{
    partial class CheckIn
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumdehabitacion = new System.Windows.Forms.Label();
            this.lblTipodehabitacion = new System.Windows.Forms.Label();
            this.lblNumdePersonas = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblDiasdeEstancia = new System.Windows.Forms.Label();
            this.lblDiasRestantes = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbTipodeHabitacion = new System.Windows.Forms.GroupBox();
            this.radHabPresidencial = new System.Windows.Forms.RadioButton();
            this.radHabSuit = new System.Windows.Forms.RadioButton();
            this.radHabNormal = new System.Windows.Forms.RadioButton();
            this.lblNumdeAdultos = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblCantdeMenores = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtpInicioEstancia = new System.Windows.Forms.DateTimePicker();
            this.dtpFinaldeEstancia = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dtpHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.grbTipodeHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuCerrar
            // 
            this.lblMenuCerrar.BackColor = System.Drawing.Color.Peru;
            this.lblMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.lblMenuCerrar.Name = "lblMenuCerrar";
            this.lblMenuCerrar.Size = new System.Drawing.Size(1386, 43);
            this.lblMenuCerrar.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblNombre.Location = new System.Drawing.Point(28, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(121, 43);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseCompatibleTextRendering = true;
            // 
            // lblNumdehabitacion
            // 
            this.lblNumdehabitacion.AutoSize = true;
            this.lblNumdehabitacion.BackColor = System.Drawing.Color.Transparent;
            this.lblNumdehabitacion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumdehabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblNumdehabitacion.Location = new System.Drawing.Point(31, 124);
            this.lblNumdehabitacion.Name = "lblNumdehabitacion";
            this.lblNumdehabitacion.Size = new System.Drawing.Size(316, 37);
            this.lblNumdehabitacion.TabIndex = 8;
            this.lblNumdehabitacion.Text = "Número de Habitación:";
            // 
            // lblTipodehabitacion
            // 
            this.lblTipodehabitacion.AutoSize = true;
            this.lblTipodehabitacion.BackColor = System.Drawing.Color.Transparent;
            this.lblTipodehabitacion.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodehabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTipodehabitacion.Location = new System.Drawing.Point(95, 216);
            this.lblTipodehabitacion.Name = "lblTipodehabitacion";
            this.lblTipodehabitacion.Size = new System.Drawing.Size(256, 43);
            this.lblTipodehabitacion.TabIndex = 9;
            this.lblTipodehabitacion.Text = "Tipo de Habitación:";
            this.lblTipodehabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTipodehabitacion.UseCompatibleTextRendering = true;
            this.lblTipodehabitacion.Click += new System.EventHandler(this.lblTipodehabitacion_Click);
            // 
            // lblNumdePersonas
            // 
            this.lblNumdePersonas.AutoSize = true;
            this.lblNumdePersonas.BackColor = System.Drawing.Color.Transparent;
            this.lblNumdePersonas.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumdePersonas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblNumdePersonas.Location = new System.Drawing.Point(565, 79);
            this.lblNumdePersonas.Name = "lblNumdePersonas";
            this.lblNumdePersonas.Size = new System.Drawing.Size(280, 43);
            this.lblNumdePersonas.TabIndex = 10;
            this.lblNumdePersonas.Text = "Número de personas:";
            this.lblNumdePersonas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumdePersonas.UseCompatibleTextRendering = true;
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.BackColor = System.Drawing.Color.Transparent;
            this.lblReserva.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblReserva.Location = new System.Drawing.Point(492, 240);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(114, 43);
            this.lblReserva.TabIndex = 11;
            this.lblReserva.Text = "Reserva:";
            this.lblReserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReserva.UseCompatibleTextRendering = true;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.BackColor = System.Drawing.Color.Transparent;
            this.lblSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSalida.Location = new System.Drawing.Point(723, 240);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(92, 43);
            this.lblSalida.TabIndex = 12;
            this.lblSalida.Text = "Salida:";
            this.lblSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalida.UseCompatibleTextRendering = true;
            // 
            // lblDiasdeEstancia
            // 
            this.lblDiasdeEstancia.AutoSize = true;
            this.lblDiasdeEstancia.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasdeEstancia.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasdeEstancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDiasdeEstancia.Location = new System.Drawing.Point(1030, 114);
            this.lblDiasdeEstancia.Name = "lblDiasdeEstancia";
            this.lblDiasdeEstancia.Size = new System.Drawing.Size(318, 37);
            this.lblDiasdeEstancia.TabIndex = 13;
            this.lblDiasdeEstancia.Text = "Dia de inicio de estancia \r\n";
            // 
            // lblDiasRestantes
            // 
            this.lblDiasRestantes.AutoSize = true;
            this.lblDiasRestantes.BackColor = System.Drawing.Color.Transparent;
            this.lblDiasRestantes.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasRestantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDiasRestantes.Location = new System.Drawing.Point(1048, 199);
            this.lblDiasRestantes.Name = "lblDiasRestantes";
            this.lblDiasRestantes.Size = new System.Drawing.Size(271, 43);
            this.lblDiasRestantes.TabIndex = 14;
            this.lblDiasRestantes.Text = "Dia final de estancia ";
            this.lblDiasRestantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDiasRestantes.UseCompatibleTextRendering = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(150, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 22);
            this.txtNombre.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtNombre, "Nombre del cliente que se\r\nva a quedar en el hotel");
            // 
            // grbTipodeHabitacion
            // 
            this.grbTipodeHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.grbTipodeHabitacion.Controls.Add(this.radHabPresidencial);
            this.grbTipodeHabitacion.Controls.Add(this.radHabSuit);
            this.grbTipodeHabitacion.Controls.Add(this.radHabNormal);
            this.grbTipodeHabitacion.Location = new System.Drawing.Point(28, 256);
            this.grbTipodeHabitacion.Name = "grbTipodeHabitacion";
            this.grbTipodeHabitacion.Size = new System.Drawing.Size(412, 59);
            this.grbTipodeHabitacion.TabIndex = 17;
            this.grbTipodeHabitacion.TabStop = false;
            this.toolTip1.SetToolTip(this.grbTipodeHabitacion, "Tipo de habitacion a elegir");
            // 
            // radHabPresidencial
            // 
            this.radHabPresidencial.AutoSize = true;
            this.radHabPresidencial.BackColor = System.Drawing.Color.Transparent;
            this.radHabPresidencial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHabPresidencial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radHabPresidencial.Location = new System.Drawing.Point(282, 19);
            this.radHabPresidencial.Name = "radHabPresidencial";
            this.radHabPresidencial.Size = new System.Drawing.Size(110, 28);
            this.radHabPresidencial.TabIndex = 2;
            this.radHabPresidencial.TabStop = true;
            this.radHabPresidencial.Text = "Presidencial";
            this.radHabPresidencial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHabPresidencial.UseCompatibleTextRendering = true;
            this.radHabPresidencial.UseVisualStyleBackColor = false;
            // 
            // radHabSuit
            // 
            this.radHabSuit.AutoSize = true;
            this.radHabSuit.BackColor = System.Drawing.Color.Transparent;
            this.radHabSuit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHabSuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radHabSuit.Location = new System.Drawing.Point(152, 19);
            this.radHabSuit.Name = "radHabSuit";
            this.radHabSuit.Size = new System.Drawing.Size(51, 28);
            this.radHabSuit.TabIndex = 1;
            this.radHabSuit.TabStop = true;
            this.radHabSuit.Text = "Suit";
            this.radHabSuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHabSuit.UseCompatibleTextRendering = true;
            this.radHabSuit.UseVisualStyleBackColor = false;
            this.radHabSuit.CheckedChanged += new System.EventHandler(this.radHabSuit_CheckedChanged);
            // 
            // radHabNormal
            // 
            this.radHabNormal.AutoSize = true;
            this.radHabNormal.BackColor = System.Drawing.Color.Transparent;
            this.radHabNormal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHabNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radHabNormal.Location = new System.Drawing.Point(10, 19);
            this.radHabNormal.Name = "radHabNormal";
            this.radHabNormal.Size = new System.Drawing.Size(78, 28);
            this.radHabNormal.TabIndex = 0;
            this.radHabNormal.TabStop = true;
            this.radHabNormal.Text = "Normal";
            this.radHabNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radHabNormal.UseCompatibleTextRendering = true;
            this.radHabNormal.UseVisualStyleBackColor = false;
            // 
            // lblNumdeAdultos
            // 
            this.lblNumdeAdultos.AutoSize = true;
            this.lblNumdeAdultos.BackColor = System.Drawing.Color.Transparent;
            this.lblNumdeAdultos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumdeAdultos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblNumdeAdultos.Location = new System.Drawing.Point(625, 124);
            this.lblNumdeAdultos.Name = "lblNumdeAdultos";
            this.lblNumdeAdultos.Size = new System.Drawing.Size(62, 27);
            this.lblNumdeAdultos.TabIndex = 19;
            this.lblNumdeAdultos.Text = "Adultos";
            this.lblNumdeAdultos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumdeAdultos.UseCompatibleTextRendering = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(716, 123);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown1.TabIndex = 20;
            this.toolTip1.SetToolTip(this.numericUpDown1, "Numero de personas adultas en el hotel");
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantdeMenores
            // 
            this.lblCantdeMenores.AutoSize = true;
            this.lblCantdeMenores.BackColor = System.Drawing.Color.Transparent;
            this.lblCantdeMenores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantdeMenores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblCantdeMenores.Location = new System.Drawing.Point(552, 169);
            this.lblCantdeMenores.Name = "lblCantdeMenores";
            this.lblCantdeMenores.Size = new System.Drawing.Size(147, 27);
            this.lblCantdeMenores.TabIndex = 21;
            this.lblCantdeMenores.Text = "Menores(<12 años)";
            this.lblCantdeMenores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCantdeMenores.UseCompatibleTextRendering = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(716, 169);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown2.TabIndex = 22;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Tan;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Check-In";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // dtpInicioEstancia
            // 
            this.dtpInicioEstancia.Enabled = false;
            this.dtpInicioEstancia.Location = new System.Drawing.Point(1075, 154);
            this.dtpInicioEstancia.Name = "dtpInicioEstancia";
            this.dtpInicioEstancia.Size = new System.Drawing.Size(220, 20);
            this.dtpInicioEstancia.TabIndex = 25;
            this.toolTip1.SetToolTip(this.dtpInicioEstancia, "Dia del inicio de \r\ntu estancia en el hotel");
            // 
            // dtpFinaldeEstancia
            // 
            this.dtpFinaldeEstancia.Enabled = false;
            this.dtpFinaldeEstancia.Location = new System.Drawing.Point(1075, 256);
            this.dtpFinaldeEstancia.Name = "dtpFinaldeEstancia";
            this.dtpFinaldeEstancia.Size = new System.Drawing.Size(220, 20);
            this.dtpFinaldeEstancia.TabIndex = 26;
            this.toolTip1.SetToolTip(this.dtpFinaldeEstancia, "Dia ultimo de tu\r\nestancia en el hotel");
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Tan;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 2);
            this.monthCalendar1.ForeColor = System.Drawing.Color.Black;
            this.monthCalendar1.Location = new System.Drawing.Point(61, 345);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Black;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toolTip1.SetToolTip(this.monthCalendar1, "Agregar de que dia a que dia \r\ndurara tu estancia en el hotel");
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-15, -15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1140, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 99);
            this.button2.TabIndex = 29;
            this.button2.Text = "Agregar reserva ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dtpHoraReserva
            // 
            this.dtpHoraReserva.Enabled = false;
            this.dtpHoraReserva.Location = new System.Drawing.Point(470, 279);
            this.dtpHoraReserva.Name = "dtpHoraReserva";
            this.dtpHoraReserva.Size = new System.Drawing.Size(160, 20);
            this.dtpHoraReserva.TabIndex = 30;
            this.toolTip1.SetToolTip(this.dtpHoraReserva, "Dia ultimo de tu\r\nestancia en el hotel");
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Enabled = false;
            this.dtpHoraSalida.Location = new System.Drawing.Point(686, 279);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(159, 20);
            this.dtpHoraSalida.TabIndex = 31;
            this.toolTip1.SetToolTip(this.dtpHoraSalida, "Dia ultimo de tu\r\nestancia en el hotel");
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::MAP2A1HotelHeavens.Properties.Resources.imgcheckinLP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.ControlBox = false;
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpHoraReserva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dtpFinaldeEstancia);
            this.Controls.Add(this.dtpInicioEstancia);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.lblCantdeMenores);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblNumdeAdultos);
            this.Controls.Add(this.grbTipodeHabitacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDiasRestantes);
            this.Controls.Add(this.lblDiasdeEstancia);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.lblNumdePersonas);
            this.Controls.Add(this.lblTipodehabitacion);
            this.Controls.Add(this.lblNumdehabitacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMenuCerrar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.grbTipodeHabitacion.ResumeLayout(false);
            this.grbTipodeHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenuCerrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumdehabitacion;
        private System.Windows.Forms.Label lblTipodehabitacion;
        private System.Windows.Forms.Label lblNumdePersonas;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblDiasdeEstancia;
        private System.Windows.Forms.Label lblDiasRestantes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbTipodeHabitacion;
        private System.Windows.Forms.RadioButton radHabPresidencial;
        private System.Windows.Forms.RadioButton radHabSuit;
        private System.Windows.Forms.RadioButton radHabNormal;
        private System.Windows.Forms.Label lblNumdeAdultos;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCantdeMenores;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpInicioEstancia;
        private System.Windows.Forms.DateTimePicker dtpFinaldeEstancia;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DateTimePicker dtpHoraReserva;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
    }
}