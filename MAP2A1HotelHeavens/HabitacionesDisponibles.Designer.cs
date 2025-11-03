namespace MAP2A1HotelHeavens
{
    partial class HabitacionesDisponibles
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxOcupadas = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuCerrar
            // 
            this.lblMenuCerrar.BackColor = System.Drawing.Color.Peru;
            this.lblMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.lblMenuCerrar.Name = "lblMenuCerrar";
            this.lblMenuCerrar.Size = new System.Drawing.Size(1366, 43);
            this.lblMenuCerrar.TabIndex = 3;
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.Peru;
            this.picMinimizar.Image = global::MAP2A1HotelHeavens.Properties.Resources.menos;
            this.picMinimizar.Location = new System.Drawing.Point(1292, 0);
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
            this.picCerrar.Location = new System.Drawing.Point(1332, 0);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(34, 43);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 4;
            this.picCerrar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MAP2A1HotelHeavens.Properties.Resources.Gemini_Generated_Image_ubow9ubow9ubow9u;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Imagen de las habitaciones.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(544, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de habitacion:";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Normal",
            "Suite",
            "Presidencial"});
            this.comboBoxTipo.Location = new System.Drawing.Point(547, 125);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(378, 38);
            this.comboBoxTipo.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBoxTipo, "Tipo de habitaciones.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(544, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Habitaciones disponibles:";
            // 
            // checkedListBoxOcupadas
            // 
            this.checkedListBoxOcupadas.BackColor = System.Drawing.Color.Black;
            this.checkedListBoxOcupadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxOcupadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.checkedListBoxOcupadas.FormattingEnabled = true;
            this.checkedListBoxOcupadas.Location = new System.Drawing.Point(549, 271);
            this.checkedListBoxOcupadas.Name = "checkedListBoxOcupadas";
            this.checkedListBoxOcupadas.Size = new System.Drawing.Size(363, 394);
            this.checkedListBoxOcupadas.TabIndex = 10;
            this.toolTip1.SetToolTip(this.checkedListBoxOcupadas, "Habitaciones ocupadas en el hotel.");
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::MAP2A1HotelHeavens.Properties.Resources.imgLogoHotelHeavensLP;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1225, 52);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(129, 111);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxLogo, "Logo del hotel.");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "Hotel Havens";
            // 
            // HabitacionesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MAP2A1HotelHeavens.Properties.Resources.imgHabitacionPresidencialLP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 705);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.checkedListBoxOcupadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picMinimizar);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.lblMenuCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HabitacionesDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HabitacionesDisponibles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label lblMenuCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxOcupadas;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}