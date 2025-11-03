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
            this.lblMenuCerrar = new System.Windows.Forms.Label();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Image = global::MAP2A1HotelHeavens.Properties.Resources.imgHabitacionSuitLP;
            this.pictureBox1.Location = new System.Drawing.Point(227, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HabitacionesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 705);
            this.ControlBox = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label lblMenuCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}